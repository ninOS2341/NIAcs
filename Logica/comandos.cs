using System.Diagnostics;
using NAudio.CoreAudioApi;
/*
    Mejorar el codigo, que es una basura
 */
public class comandos
{
    private readonly ConexionIA _ia;
    private readonly Voz _voz;

    public comandos(ConexionIA ia, Voz voz)
    {
        _ia = ia;
        _voz = voz;
    }

    public async Task ProcesarAsync(string texto)
    {
        texto = texto.ToLower().Trim();
        Console.WriteLine($"[REGISTRO] Procesando: {texto}");

        bool fueComando = await IntentarComandoLocalAsync(texto);

        if (!fueComando)
        {
            Console.WriteLine("[REGISTRO] → IA");
            var respuesta = await _ia.ResponderAsync(texto);
            await _voz.SpeakAsync(respuesta);
        }
    }

    private async Task<bool> IntentarComandoLocalAsync(string texto)
    {
        // ─── Aplicaciones ───────────────────────────────────────
        if (texto.Contains("abre el bloc") || texto.Contains("abrir bloc"))
        {
            Process.Start("notepad.exe");
            await _voz.SpeakAsync("Abriendo bloc de notas.");
            return true;
        }

        if (texto.Contains("abre la calculadora") || texto.Contains("abrir calculadora"))
        {
            Process.Start("calc.exe");
            await _voz.SpeakAsync("Abriendo calculadora.");
            return true;
        }

        if (texto.Contains("abre el navegador") || texto.Contains("abrir navegador"))
        {
            Process.Start(new ProcessStartInfo("https://www.google.com")
            { UseShellExecute = true });
            await _voz.SpeakAsync("Abriendo navegador.");
            return true;
        }

        if (texto.Contains("abre el explorador") || texto.Contains("abrir explorador"))
        {
            Process.Start("explorer.exe");
            await _voz.SpeakAsync("Abriendo explorador de archivos.");
            return true;
        }

        // ─── Sistema ────────────────────────────────────────────
        if (texto.Contains("que hora es") || texto.Contains("qué hora es"))
        {
            var hora = DateTime.Now.ToString("hh:mm tt");
            await _voz.SpeakAsync($"Son las {hora}.");
            return true;
        }

        if (texto.Contains("que dia es") || texto.Contains("qué día es"))
        {
            var fecha = DateTime.Now.ToString("dddd d 'de' MMMM",
                new System.Globalization.CultureInfo("es-MX"));
            await _voz.SpeakAsync($"Hoy es {fecha}.");
            return true;
        }

       
        if (texto.Contains("apaga la pc") || texto.Contains("apagar pc"))
        {
            await _voz.SpeakAsync("Apagando la PC en 10 segundos.");
            Process.Start("shutdown", "/s /t 10");
            return true;
        }

        if (texto.Contains("cancela apagado") || texto.Contains("cancelar apagado"))
        {
            Process.Start("shutdown", "/a");
            await _voz.SpeakAsync("Apagado cancelado.");
            return true;
        }

        if (texto.Contains("reinicia la pc") || texto.Contains("reiniciar pc"))
        {
            await _voz.SpeakAsync("Reiniciando la PC en 10 segundos.");
            Process.Start("shutdown", "/r /t 10");
            return true;
        }

        // ─── Volumen con NAudio ──────────────────────────────────
        if (texto.Contains("sube el volumen"))
        {
            AjustarVolumen(subir: true);
            await _voz.SpeakAsync("Subiendo volumen.");
            return true;
        }

        if (texto.Contains("baja el volumen"))
        {
            AjustarVolumen(subir: false);
            await _voz.SpeakAsync("Bajando volumen.");
            return true;
        }

        // ─── Historial ──────────────────────────────────────────
        if (texto.Contains("limpia el historial") || texto.Contains("limpiar historial")
            || texto.Contains("olvida todo"))
        {
            _ia.LimpiarHistorial();
            await _voz.SpeakAsync("Historial limpiado, empezamos de cero.");
            return true;
        }

        // ─── Google ─────────────────────────────────────────────
        if (texto.Contains("busca en google") || texto.Contains("buscar en google"))
        {
            var query = texto.Replace("busca en google", "")
                             .Replace("buscar en google", "").Trim();
            if (!string.IsNullOrWhiteSpace(query))
            {
                var url = $"https://www.google.com/search?q={Uri.EscapeDataString(query)}";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                await _voz.SpeakAsync($"Buscando {query} en Google.");
                return true;
            }
        }

        return false;
    }

  
    // ← Ahora usa NAudio en lugar de WinForms
    private void AjustarVolumen(bool subir)
    {
        using var enumerator = new MMDeviceEnumerator();
        var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

        float actual = device.AudioEndpointVolume.MasterVolumeLevelScalar;
        float nuevo = subir
            ? Math.Min(actual + 0.1f, 1.0f)
            : Math.Max(actual - 0.1f, 0.0f);

        device.AudioEndpointVolume.MasterVolumeLevelScalar = nuevo;
        Console.WriteLine($"[Volumen] {actual * 100:F0}% → {nuevo * 100:F0}%");
    }
}