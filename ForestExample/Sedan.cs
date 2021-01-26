using System;

namespace LearnInterfaces
{
    class Sedan : IAutomobile //implements automobiles interface
    {
        //properties
        public string LicensePlate
        { get; }

        public int Doors
        { get; }

        public int Wheels
        { get; }

        public int MaxSpeed
        { get; private set; }

        public string Transmission
        { get; private set; }

        //constructor
        public Sedan(double speed, string transmission)
        {
            this.MaxSpeed = speed;
            Transmission = transmission;
            LicensePlate = Tools.GenerateLicensePlate();
            this.Wheels = 4;
            this.Doors = 4;
        }

        //methods
        public void Honk()
        {
            Console.WriteLine("honk!");
        }
    }
}