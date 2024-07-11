using OtusPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes
{
    public class Car : Vehicle, IMyCloneable<Car>, ICloneable
    {
        public int NumberOfDoors { get; set; }
        public double CarTrunkSize { get; set; }

        public Car(int id, string name, int maxSpeed, FuelType fuelType, int numberOfDoors, double carTrunkSize)
            : base(id, name, maxSpeed, fuelType)
        {
            NumberOfDoors = numberOfDoors;
            CarTrunkSize = carTrunkSize;
        }

        public override Car Clone()
        {
            return new Car(Id, Name, MaxSpeed, FuelType, NumberOfDoors, CarTrunkSize);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
