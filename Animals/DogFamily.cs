﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public abstract class DogFamily : Predators
    {
        public bool IsSheds { get; set; } = true;
    }
}
