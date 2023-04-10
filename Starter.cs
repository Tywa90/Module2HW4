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
        private HelpClass help = new HelpClass();
        public void Run()
        {
            AddingAnimals();
            Console.WriteLine();
            help.DisplaySafari();
            help.AnimalsCounter();
        }
        public void AddingAnimals()
        {
            Lynx lynx = new Lynx();
            Leopard leopard = new Leopard();
            Lion lion = new Lion();
            Wolf wolf = new Wolf();

            help.Add(lynx);
            help.Add(leopard);
            help.Add(lion);
            help.Add(wolf);

        }
    }
}
