namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnglishTranslator : ATranslator
    {
        public override void TranslateWord(string word)
        {
            this.Translation.TranslatedWord = "english " + word;
        }

        public override void SetSpeechDifficulty()
        {
            this.Translation.SpeechDifficulty = 5;
        }

        public override void SetSpeechVelocity()
        {
            this.Translation.SpeechVelocity = 15;
        }
    }
}
