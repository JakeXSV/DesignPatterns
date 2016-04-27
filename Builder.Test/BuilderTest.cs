namespace Builder.Test
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Builder;

    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void EnglishTranslator()
        {
            var english = new EnglishTranslator();
            var director = new MultiLanguageTranslator(english);

            director.Translate("hey");

            var translation = english.GetTranslation();

            Assert.AreEqual(translation.SpeechDifficulty, 5);
            Assert.AreEqual(translation.SpeechVelocity, 15);
            Assert.AreEqual(translation.TranslatedWord, "english hey");
        }

        [TestMethod]
        public void RussianTranslator()
        {
            var russian = new RussianTranslator();
            var director = new MultiLanguageTranslator(russian);

            director.Translate("hey");

            var translation = russian.GetTranslation();

            Assert.AreEqual(translation.SpeechDifficulty, 99);
            Assert.AreEqual(translation.SpeechVelocity, 5);
            Assert.AreEqual(translation.TranslatedWord, "russian hey");
        }
    }
}
