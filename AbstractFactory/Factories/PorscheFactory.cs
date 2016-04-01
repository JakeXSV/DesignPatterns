namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models.Sedan;
    using Models.Sportscar;
    using Models.Supercar;

    public class PorscheFactory : AbstractManufacturerFactory
    {
        private const string PorscheStyle = "Luxury Sport";

        public override string Style
        {
            get
            {
                return PorscheStyle;
            }
        }

        public override AbstractSedan GetSedan()
        {
            return new Panamera();
        }

        public override AbstractSportscar GetSportscar()
        {
            return new Cayman();
        }

        public override AbstractSupercar GetSupercar()
        {
            return new The918();
        }
    }
}
