using Xunit;
using OtusPrototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes.Tests
{
    public class ElectricCarTests
    {
        [Fact()]
        public void ElectricCarTest()
        {
            ElectricCar original = new ElectricCar(1, "Tesla Coupe", 450, BaseEntity.FuelType.Electric, 3, 800, 100, 200);
            ElectricCar cloned = original.Clone();

            Assert.Equal(original.Id, cloned.Id);
            Assert.Equal(original.Name, cloned.Name);
            Assert.Equal(original.MaxSpeed, cloned.MaxSpeed);
            Assert.Equal(original.FuelType, cloned.FuelType);
            Assert.Equal(original.NumberOfDoors, cloned.NumberOfDoors);
            Assert.Equal(original.DistanceRange, cloned.DistanceRange);
            Assert.Equal(original.BatteryCapacity, cloned.BatteryCapacity);
            Assert.Equal(original.DistanceRange, cloned.DistanceRange);
        }
    }
}