namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RussianTranslator : AbstractTranslator
    {
        public override string GetWord(string word)
        {
            return "russian translation";
        }
    }
}
