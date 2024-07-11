using OtusPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes
{
    public class ElectricCar : Car, IMyCloneable<ElectricCar>, ICloneable
    {
        public double BatteryCapacity { get; set; }
        public double DistanceRange { get; set; }

        public ElectricCar(int id, string name, int maxSpeed, FuelType fuelType, int numberOfDoors, double carTrunkSize, double batteryCapacity, double distanceRange)
            : base(id, name, maxSpeed, fuelType, numberOfDoors, carTrunkSize)
        {
            BatteryCapacity = batteryCapacity;
            DistanceRange = distanceRange;
        }

        public override ElectricCar Clone()
        {
            return new ElectricCar(Id, Name, MaxSpeed, FuelType, NumberOfDoors, CarTrunkSize, BatteryCapacity, DistanceRange);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
