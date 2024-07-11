using OtusPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes
{
    public class Vehicle : BaseEntity, IMyCloneable<Vehicle>, ICloneable
    {
        public int MaxSpeed { get; set; }
        public FuelType FuelType { get; set; }

        public Vehicle(int id, string name, int maxSpeed, FuelType fuelType)
            : base(id, name)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        public override Vehicle Clone()
        {
            return new Vehicle(Id, Name, MaxSpeed, FuelType);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
