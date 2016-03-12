namespace DesignPatterns.AbstractFactory.Models
{
    public abstract class AbstractAutomobile
    {
        public virtual int DoorCount { get; set; }
        public virtual int Weight { get; set; }
        public virtual int TopSpeed { get; set; }
        public virtual int WheelCount { get; set; }
        public virtual int Transmission { get; set; }
        public virtual int DriveTrain { get; set; }
    }
}
