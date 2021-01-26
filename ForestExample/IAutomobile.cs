using System;

namespace LearnInterfaces
{
    interface IAutomobile
    {
        string LicensePlate { get; }
        double MaxSpeed { get; }
        int Wheels { get; }
        int Doors { get; }
        string Transmission { get; }
        void Honk();
    }
}
