using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public class Gepard : Gepards
    {
        public override string Name { get; set; } = "Cheetah";
        public override int Speed { get; set; } = 110;
        public override float MaxWeight { get; set; } = 71;
        public bool HasCammo { get; set; } = true;
    }
}
