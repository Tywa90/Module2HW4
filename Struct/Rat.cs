using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public class Rat : MouseFamily
    {
        public override string Name { get; set; } = "Rat";
        public override int Speed { get; set; } = 10;
        public override float MaxWeight { get; set; } = 0.5F;
        public bool IsDangerous { get; set; } = true;
    }
}
