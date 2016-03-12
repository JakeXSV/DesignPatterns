namespace AbstractFactory.Factories
{
    using Models.Sedan;
    using Models.Sportscar;
    using Models.SUV;
    using Models.Truck;

    public abstract class AbstractManufacturerFactory
    {
        public abstract AbstractSedan GetSedan();
        public abstract AbstractSportscar GetSportscar();
        public abstract AbstractSUV GetSUV();
        public abstract AbstractTruck GetTruck();
    }
}
