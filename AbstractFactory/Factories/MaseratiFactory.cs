namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models.Supercar;
    using Models.Sedan;
    using Models.Sportscar;

    public class MaseratiFactory : AbstractManufacturerFactory
    {
        private const string MaseratiStyle = "Luxury With $10000 repair bill";

        public override string Style
        {
            get
            {
                return MaseratiStyle;
            }
        }

        public override AbstractSedan GetSedan()
        {
            return new Ghibli();
        }

        public override AbstractSportscar GetSportscar()
        {
            return new GranTurismo();
        }

        public override AbstractSupercar GetSupercar()
        {
            return new TheMC12();
        }
    }
}
