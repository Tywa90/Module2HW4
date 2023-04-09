using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Struct;

namespace SafariPark
{
    public class Starter
    {
        public void Run()
        {
            Lynx lynx = new Lynx();
            Leopard leopard = new Leopard();
            Lion lion = new Lion();
            Wolf wolf = new Wolf();

            IAnimalsGroup[] _animals = {lynx, leopard, lion, wolf};
            Console.WriteLine(_animals[0].Name);
        }
    }
}
