namespace AbstractFactory.Factories
{
    using Models.Sedan;
    using Models.Sportscar;
    using Models.Supercar;

    public abstract class AbstractManufacturerFactory
    {
        public abstract string Style { get; }

        public string GetStyle()
        {
            return Style;
        }

        public abstract AbstractSedan GetSedan();
        public abstract AbstractSportscar GetSportscar();
        public abstract AbstractSupercar GetSupercar();
    }
}
