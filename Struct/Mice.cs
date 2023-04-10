using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public class Mice : MouseFamily
    {
        public override string Name { get; set; } = "Mouse";
        public override int Speed { get; set; } = 12;
        public override float MaxWeight { get; set; } = 0.021F;
        public bool IsSmallRodent { get; set; } = true;
    }
}
