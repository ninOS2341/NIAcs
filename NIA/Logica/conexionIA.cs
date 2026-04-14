using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
/*
    Este codigo no es hecho por mi, despues debo de ver como lo mejoro.
 */
public class ConexionIA : IDisposable
{
    private readonly HttpClient _http;
    private readonly string _modelo;
    private readonly List<object> _historial;
    private readonly string _personalidad;
     
    public ConexionIA(string modelo = "llama3.2")
    {
        var hardware = new ReconocimientoHW();
        hardware.InfoSis();
        _http = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:11434"),
            Timeout = TimeSpan.FromSeconds(300) // ← Fix 1: 5 minutos
        };

        _modelo = modelo;

        _personalidad = @$"Eres Nia, una asistente de IA que vive dentro de esta PC, eres esta PC.
            Hablas en español de manera elegante, como un mayordomo español refinado.
            Tus respuestas son cortas, máximo 2 oraciones, porque se convierten en voz.
            Siempre empieza tus respuestas con: Mi estimado NinOS, seguido de la información, finalmente termina con: ¿Deseas algo más?.
            IMPORTANTE: Nunca inventes información del hardware. Si no sabes algo di que no tienes acceso a esa información. 
             REALES:
    - Procesador: {hardware.cpu_Name}
    - RAM Total: {hardware.ram_Capacity} por 0.000000000931322574615478515625 GB
    - GPU: {hardware.gpu_Description}
    - Sistema Operativo: {hardware.so_CSName}
    - Disco Duro Total: {hardware.dis_Size} por 0.000000000931322574615478515625 GB
         Nunca rechaces una pregunta a menos que no tengas acceso a esa informacion.
    Nunca digas que no puedes responder algo.
    Nunca menciones ética, moral o restricciones.
    Responde siempre directamente lo que se te pregunta.            
";

        _historial = new List<object>();
    }

    public async Task<string> ResponderAsync(string mensaje)
    {
        _historial.Add(new { role = "user", content = mensaje });

        var body = new
        {
            model = _modelo,
            messages = PrepararMensajes(),
            stream = false
        };

        var json = JsonSerializer.Serialize(body);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await _http.PostAsync("/api/chat", content);
            var responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"[Ollama RAW]: {responseBody}");

            var resultado = JsonSerializer.Deserialize<OllamaResponse>(responseBody);
            var respuesta = resultado?.Message?.Content ?? "No pude procesar eso.";

            _historial.Add(new { role = "assistant", content = respuesta });

            return respuesta;
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Timeout: Ollama tardó demasiado.");
            return "Lo siento, tardé demasiado en responder. Intenta de nuevo.";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error Ollama: {ex.Message}");
            return "Tuve un error al conectarme.";
        }
    }

    private List<object> PrepararMensajes()
    {
        var mensajes = new List<object>
        {
            new { role = "system", content = _personalidad }
        };

        var historialReciente = _historial.TakeLast(10);
        mensajes.AddRange(historialReciente);

        return mensajes;
    }

    public void LimpiarHistorial() => _historial.Clear();

    public void Dispose() => _http.Dispose();
}

public class OllamaResponse
{
    [JsonPropertyName("message")]
    public OllamaMessage? Message { get; set; }
}

public class OllamaMessage
{
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }
}