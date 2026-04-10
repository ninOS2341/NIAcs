
using System.Speech.Recognition;
using System.Speech.Synthesis;

ReconocimientoHW reconocimientoHW = new ReconocimientoHW();
Logica logica = new Logica();
public class EscuchaActiva
{
    Logica logica = new Logica();
       public void Escucha() {
        
            var recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            recognizer.SpeechRecognized += (s, e) => {
                logica.nia = e.Result.Text;
                
            };
             Thread.Sleep(1000);

    }
        public void Hablar(string dialogoNia) {
        var synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(dialogoNia);

    }
}