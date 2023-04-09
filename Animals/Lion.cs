using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public class Lion : Panthera
    {
        public override string Name { get; set; } = "Lion";
        public override int Speed { get; set; } = 80;
        public override int MaxWeight { get; set; } = 250;
        public bool HaveMane { get; set; } = true;
    }
}
