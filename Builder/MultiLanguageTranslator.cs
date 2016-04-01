using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Director
    public class MultiLanguageTranslator
    {
        private AbstractTranslator Translator { get; set; }

        public MultiLanguageTranslator(AbstractTranslator translator)
        {
            Translator = translator;
        }

        public string TranslateWord(string word)
        {
            return Translator.GetWord(word);
        }
    }
}
