using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public abstract class Animals
    {
        public abstract string Name { get; set; }
        public abstract int Speed { get; set; }
        public virtual int MaxWeight { get; set; }
    }
}
