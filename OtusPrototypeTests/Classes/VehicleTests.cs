using Xunit;
using OtusPrototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes.Tests
{
    public class VehicleTests
    {
        [Fact()]
        public void VehicleTest()
        {
            Vehicle original = new Vehicle(1, "UAZ", 200, BaseEntity.FuelType.Diesel);
            Vehicle cloned = original.Clone();

            Assert.Equal(original.Id, cloned.Id);
            Assert.Equal(original.Name, cloned.Name);
            Assert.Equal(original.MaxSpeed, cloned.MaxSpeed);
            Assert.Equal(original.FuelType, cloned.FuelType);
        }
    }
}