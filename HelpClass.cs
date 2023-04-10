using SafariPark.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class HelpClass
    {
        private IAnimalsGroup[] _animals;
        private int _animalsLength = 0;
        public int CountAllAnimals { get; set; }
        public IAnimalsGroup[] AllAnimals { get { return _animals; } }

        public HelpClass()
        {
            _animals = new IAnimalsGroup[1];
        }

        public void Add(IAnimalsGroup animal)
        {
            _animalsLength++;
            Array.Resize(ref _animals, _animalsLength);

            for (var i = CountAllAnimals; i < _animalsLength; i++)
            {
                _animals[i] = animal;
                CountAllAnimals++;
                break;
            }
        }
        public void AnimalsCounter()
        {
            Console.WriteLine($"Total: {CountAllAnimals} animals");
        }
        public void DisplaySafari()
        {
            Console.WriteLine("Animals:".PadRight(17) + "Max speed:");
            foreach (var item in _animals)
            {
                Console.WriteLine(item.Name.PadRight(20) + item.Speed);
            }
            Console.WriteLine();
        }
        public void DisplaySort()
        {
            Array.Sort(AllAnimals);
            DisplaySafari();
            Console.WriteLine();
        }
    }
}
