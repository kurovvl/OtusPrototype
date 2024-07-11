using Xunit;
using OtusPrototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes.Tests
{
    public class CarTests
    {
        [Fact()]
        public void CarTest()
        {
            Car original = new Car(1, "UAZ", 150, BaseEntity.FuelType.Diesel, 5, 2500);
            Car cloned = original.Clone();

            Assert.Equal(original.Id, cloned.Id);
            Assert.Equal(original.Name, cloned.Name);
            Assert.Equal(original.MaxSpeed, cloned.MaxSpeed);
            Assert.Equal(original.FuelType, cloned.FuelType);
            Assert.Equal(original.NumberOfDoors, cloned.NumberOfDoors);
            Assert.Equal(original.CarTrunkSize, cloned.CarTrunkSize);
        }
    }
}