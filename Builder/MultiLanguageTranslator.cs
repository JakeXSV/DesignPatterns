namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Director
    public class MultiLanguageTranslator
    {
        private ATranslator Translator { get; set; }

        public MultiLanguageTranslator(ATranslator translator)
        {
            this.Translator = translator;
        }

        public void Translate(string word)
        {
            this.Translator.Translation = new TranslationResult();
            this.Translator.TranslateWord(word);
            this.Translator.SetSpeechDifficulty();
            this.Translator.SetSpeechVelocity();
        }
    }
}
