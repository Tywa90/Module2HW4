﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Struct
{
    public class Lynx : LynxCats
    {
        public override string Name { get; set; } = "Lynx canadian";
        public override int Speed { get; set; } = 40;
        public override float MaxWeight { get; set; } = 25;
        public bool IsBigEars { get; set; } = true;
    }
}
