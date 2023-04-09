using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public class Wolf : Wolfs
    {
        public override string Name { get; set; } = "Wolf Alaskian";
        public override int Speed { get; set; } = 60;
        public override int MaxWeight { get; set; } = 65;
        public bool IsHowl { get; set; } = true;
    }
}
