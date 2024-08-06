using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Animal
    {
        protected string? species;
     
        public string? GetSpecies() { return species; }
     

    }
    internal class Dog : Animal
    {
        public void Dogspecies()
        {
            species = "Dog";
        }
    }
}
