using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public abstract class Animals : IAnimalsGroup, IComparable
    {
        public abstract string Name { get; set; }
        public abstract int Speed { get; set; }
        public virtual int MaxWeight { get; set; }

        public int CompareTo(object? obj)
        {
            return Name.CompareTo(((Animals)obj).Name);
        }
    }
}
