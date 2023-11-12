using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Speechh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var _synthesizer = new SpeechSynthesizer();
            // _synthesizer.SetOutputToDefaultAudioDevice();
            // _synthesizer.Speak("All we need to do is to make sure we keep talking");
            
            
            
            
            
            
            
            
            // using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            // {
            //     // show installed voices
            //     foreach (var v in synthesizer.GetInstalledVoices().Select(v => v.VoiceInfo))
            //     {
            //         Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
            //             v.Description, v.Gender, v.Age);
            //     }
            //
            //     // select male senior (if it exists)
            //     synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            //
            //     // select audio device
            //     synthesizer.SetOutputToDefaultAudioDevice();
            //
            //     // build and speak a prompt
            //     PromptBuilder builder = new PromptBuilder();
            //     builder.AppendText("Found this on Stack Overflow.");
            //     synthesizer.Speak(builder);
            // }
            
            
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.NotSet , VoiceAge.Teen); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)
            // Synchronous
            synthesizer.Speak("Now I'm speaking, no other function'll work");
            // Asynchronous
            synthesizer.SpeakAsync("Welcome" + args); // here args = pran
        }
    }
}
