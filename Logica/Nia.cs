public class Logica
{/*
    Parte de este codigo no fue escrito por mi, es solo provicional para probar el habla y conexiones.
    En la siguiente version voy a reescribirlo para que sea mejor y mas organizado.
  */
    public async Task Nia()
    {
        Console.WriteLine("1. Iniciando Nia...");
        var nia = new Voz();
        Console.WriteLine("2. Voz lista");

        var niaIA = new ConexionIA("llama3.2");
        Console.WriteLine("3. IA lista");

        var router = new comandos(niaIA, nia);
        Console.WriteLine("4. Router listo");

        string modelPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Models", "\\vosk-model-small-es-0.42");

        Console.WriteLine($"5. Ruta modelo: {modelPath}");
        Console.WriteLine($"   ¿Existe? {Directory.Exists(modelPath)}");

        var usuario = new Escucha(modelPath);
        Console.WriteLine("6. Escucha lista");

        usuario.OnTextRecognized += async (texto) =>
        {
            Console.WriteLine($"\n Escuché: {texto}");
            usuario.DejarDeEscuchar();
            await router.ProcesarAsync(texto);
            usuario.Escuchando();
        };

        Console.WriteLine("7. Verificando Ollama...");
        bool ollamaOk = await VerificarOllama();
        Console.WriteLine($"   Ollama corriendo: {ollamaOk}");

        if (!ollamaOk)
        {
            nia.Speak("No encontré Ollama corriendo. Ábrelo primero.");
            Console.WriteLine("Abre una terminal y escribe: ollama serve");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("8. Calentando modelo, espera...");
        nia.Speak("Un momento, cargando.");
        await niaIA.ResponderAsync("hola");
        Console.WriteLine("   Modelo listo!");

        Console.WriteLine("9. Todo listo, iniciando escucha...");
        nia.Speak("Hola, soy Nia. ¿En qué te ayudo?");
        usuario.Escuchando();

        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();

        usuario.DejarDeEscuchar();
        usuario.Dispose();
        niaIA.Dispose();
        nia.Dispose();
    }

    private async Task<bool> VerificarOllama()
    {
        try
        {
            using var http = new HttpClient();
            var response = await http.GetAsync("http://localhost:11434");
            return response.IsSuccessStatusCode;
        }
        catch { return false; }
    }
}