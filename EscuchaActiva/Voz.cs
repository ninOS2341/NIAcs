using System.Speech.Synthesis;
/*
    No quiero que esta sea su voz, despues buscare una menos robotizada.
 */
public class Voz : IDisposable
{
    private readonly SpeechSynthesizer _synth;

    public Voz()
    {
        _synth = new SpeechSynthesizer();
        _synth.SetOutputToDefaultAudioDevice();
        Configuracion();
    }

    private void Configuracion()
    {
        // Nota: hacer cambiar la voz
        var spanishVoice = _synth.GetInstalledVoices()
            .FirstOrDefault(v => v.VoiceInfo.Culture.Name.StartsWith("es"));

        if (spanishVoice != null)
            _synth.SelectVoice(spanishVoice.VoiceInfo.Name);

        _synth.Rate = 3;
        _synth.Volume = 100;
    }

    public void Speak(string text)
    {
        Console.WriteLine(text);
        _synth.Speak(text);
    }

    public async Task SpeakAsync(string text)
    {
        Console.WriteLine(text);
         Task.Run(() => _synth.Speak(text));
        
    }

    public void Dispose() => _synth.Dispose();
}