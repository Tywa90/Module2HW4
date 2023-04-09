using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public abstract class LynxCats : CatsFamily
    {
        public bool IsWinterHunter { get; set; } = true;
    }
}
