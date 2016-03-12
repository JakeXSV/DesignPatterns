namespace AbstractFactory.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models.Sedan;
    using Models.Sportscar;
    using Models.SUV;
    using Models.Truck;

    public class MaseratiFactory : AbstractManufacturerFactory
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
