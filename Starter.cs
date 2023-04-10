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
        private readonly HelpClass _help = new HelpClass();

        public void Run()
        {
            AddingAnimals();
            _help.DisplaySafari();
            _help.AnimalsCounter();

            _help.DisplaySort();
            _help.FindName("lion");
        }

        public void AddingAnimals()
        {
            Wolf wolf = new Wolf();
            Lynx lynx = new Lynx();
            Leopard leopard = new Leopard();
            Lion lion = new Lion();
            Mice mice = new Mice();
            Rat rat = new Rat();
            Gepard gepard = new Gepard();

            _help.Add(lynx);
            _help.Add(leopard);
            _help.Add(lion);
            _help.Add(wolf);
            _help.Add(mice);
            _help.Add(rat);
            _help.Add(gepard);
        }
    }
}
