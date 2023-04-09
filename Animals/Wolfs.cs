using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public abstract class Wolfs : DogFamily
    {
        public bool HuntInPack { get; set; } = true;
    }
}
