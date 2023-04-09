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

            Animals[] animals = new Animals[4];
            animals[0] = lynx;
            animals[1] = leopard;
            animals[2] = lion;
            animals[3] = wolf;

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Name);
            }
        }
    }
}
