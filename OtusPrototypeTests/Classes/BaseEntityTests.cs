using Xunit;
using OtusPrototype.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes.Tests
{
    public class BaseEntityTests
    {
        [Fact()]
        public void BaseEntityTest()
        {
            BaseEntity original = new Vehicle(1, "Moskvich", 200, BaseEntity.FuelType.Gasoline);
            BaseEntity cloned = original.Clone();

            Assert.Equal(original.Id, cloned.Id);
            Assert.Equal(original.Name, cloned.Name);
        }

    }
}