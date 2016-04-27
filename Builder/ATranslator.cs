namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class ATranslator
    {
        public TranslationResult Translation { get; set; }
        public abstract void TranslateWord(string word);
        public abstract void SetSpeechVelocity();
        public abstract void SetSpeechDifficulty();

        public virtual TranslationResult GetTranslation()
        {
            return this.Translation;
        }
    }
}
