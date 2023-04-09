using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Animals
{
    public class Leopard : Panthera
    {
        public override string Name { get; set; } = "Leopard";
        public override int Speed { get; set; } = 58;
        public override int MaxWeight { get; set; } = 70;
        public bool IsDotPainted { get; set; } = true;
    }
}
