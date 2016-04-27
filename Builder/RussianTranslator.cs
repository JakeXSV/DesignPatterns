namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RussianTranslator : ATranslator
    {
        public override void TranslateWord(string word)
        {
            this.Translation.TranslatedWord = "russian " + word;
        }

        public override void SetSpeechDifficulty()
        {
            this.Translation.SpeechDifficulty = 99;
        }

        public override void SetSpeechVelocity()
        {
            this.Translation.SpeechVelocity = 5;
        }
    }
}
