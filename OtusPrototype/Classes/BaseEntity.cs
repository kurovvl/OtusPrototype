using OtusPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype.Classes
{
    public abstract class BaseEntity : IMyCloneable<BaseEntity>, ICloneable
    {
        public enum FuelType { Gasoline, Electric, Diesel}
        public int Id { get; set; }
        public string Name { get; set; }

        public BaseEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract BaseEntity Clone();

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
