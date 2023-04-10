using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public abstract class MouseFamily : Rodents
    {
        public bool EatAgricultural { get; set; } = true;
    }
}
