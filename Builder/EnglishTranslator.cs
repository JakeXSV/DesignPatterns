namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnglishTranslator : AbstractTranslator
    {
        public override string GetWord(string word)
        {
            return "english translation";
        }
    }
}
