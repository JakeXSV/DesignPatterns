using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Builder.Test
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void EnglishTranslator()
        {
            var director = new MultiLanguageTranslator(new EnglishTranslator());

            Assert.AreEqual("english translation", director.TranslateWord("seofj"));
        }

        [TestMethod]
        public void RussianTranslator()
        {
            var director = new MultiLanguageTranslator(new RussianTranslator());

            Assert.AreEqual("russian translation", director.TranslateWord("seofj"));
        }
    }
}
