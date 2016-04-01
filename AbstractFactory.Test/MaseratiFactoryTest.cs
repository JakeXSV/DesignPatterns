namespace AbstractFactory.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Factories;
    using Models.Sedan;
    using Models.Supercar;
    using Models.Sportscar;

    [TestClass]
    public class MaseratiFactoryTest
    {
        public MaseratiFactory maserati = new MaseratiFactory();

        [TestMethod]
        public void GetStyle()
        {
            Assert.AreEqual("Luxury With $10000 repair bill", maserati.GetStyle());
        }

        [TestMethod]
        public void SedanIsOfTypeAbstractSedan()
        {
            Assert.IsInstanceOfType(maserati.GetSedan(), typeof(Ghibli));
        }

        [TestMethod]
        public void SportscarIsOfTypeAbstractSportscar()
        {
            Assert.IsInstanceOfType(maserati.GetSportscar(), typeof(GranTurismo));
        }

        [TestMethod]
        public void SupercarIsOfTypeSupercar()
        {
            Assert.IsInstanceOfType(maserati.GetSupercar(), typeof(TheMC12));
        }
    }
}
