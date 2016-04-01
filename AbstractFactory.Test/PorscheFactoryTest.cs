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
    public class PorscheFactoryTest
    {
        public PorscheFactory porsche = new PorscheFactory();

        [TestMethod]
        public void GetStyle()
        {
            Assert.AreEqual("Luxury Sport", porsche.GetStyle());
        }

        [TestMethod]
        public void SedanIsOfTypeAbstractSedan()
        {
            Assert.IsInstanceOfType(porsche.GetSedan(), typeof(Panamera));
        }

        [TestMethod]
        public void SportscarIsOfTypeAbstractSportscar()
        {
            Assert.IsInstanceOfType(porsche.GetSportscar(), typeof(Cayman));
        }

        [TestMethod]
        public void SupercarIsOfTypeSupercar()
        {
            Assert.IsInstanceOfType(porsche.GetSupercar(), typeof(The918));
        }
    }
}
