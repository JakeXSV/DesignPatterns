namespace DesignPatterns.AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DesignPatterns.AbstractFactory.Models.Sedan;
    using DesignPatterns.AbstractFactory.Models.Sportscar;
    using DesignPatterns.AbstractFactory.Models.SUV;
    using DesignPatterns.AbstractFactory.Models.Truck;

    public class PorscheFactory : AbstractManufacturerFactory
    {
        public override AbstractSedan GetSedan()
        {
            throw new NotImplementedException();
        }

        public override AbstractSportscar GetSportscar()
        {
            throw new NotImplementedException();
        }

        public override AbstractSUV GetSUV()
        {
            throw new NotImplementedException();
        }

        public override AbstractTruck GetTruck()
        {
            throw new NotImplementedException();
        }
    }
}
