using NAudio.Wave;
using Newtonsoft.Json;
using Vosk;
/*
    El modelo de vosk es aun de prueba, por ahora esta dando buenos resultados junto con NAudio. 
 */
public class Escucha : IDisposable
{
    private readonly Model _model;
    private readonly WaveInEvent _waveIn;
    private readonly VoskRecognizer _recognizer;

    public event Action<string>? OnTextRecognized;

    public Escucha(string modelPath)
    {

        Vosk.Vosk.SetLogLevel(-1);

        _model = new Model(modelPath);
        _recognizer = new VoskRecognizer(_model, 16000f);
        _recognizer.SetMaxAlternatives(0);
        _recognizer.SetWords(true);

        _waveIn = new WaveInEvent
        {
            WaveFormat = new WaveFormat(16000, 1),
            BufferMilliseconds = 250
        };

        _waveIn.DataAvailable += OnAudioData;
    }

    private void OnAudioData(object? sender, WaveInEventArgs e)
    {
        if (_recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
        {
            var result = JsonConvert.DeserializeObject<VoskResult>(_recognizer.Result());

            if (!string.IsNullOrWhiteSpace(result?.Text))
            {
                Console.WriteLine(); 
                OnTextRecognized?.Invoke(result.Text); 
            }
        }
        else
        {
            var partial = JsonConvert.DeserializeObject<VoskPartialResult>(_recognizer.PartialResult());
            if (!string.IsNullOrWhiteSpace(partial?.Partial))
                Console.Write($"\r{partial.Partial}...");
        }
    }

    public void Escuchando()
    {

        _waveIn.StartRecording();
        Console.WriteLine("Escuchando... (habla cuando quieras)");
    }

    public void DejarDeEscuchar() => _waveIn.StopRecording();

    public void Dispose()
    {
        _waveIn.Dispose();
        _recognizer.Dispose();
        _model.Dispose();
    }
}

public class VoskResult
{
    [JsonProperty("text")]
    public string? Text { get; set; }
}

public class VoskPartialResult
{
    [JsonProperty("partial")]
    public string? Partial { get; set; }
}