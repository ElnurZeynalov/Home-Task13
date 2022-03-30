using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Farm
    {
        private Animal[] _animals = new Animal[0];
        public Animal[] Animals { get =>_animals;}
        public Animal[] AddAnimal(Animal animal)
        {
            Array.Resize(ref _animals, _animals.Length+1);
            _animals[_animals.Length - 1] = animal;
            return _animals;
        }
    }
}
