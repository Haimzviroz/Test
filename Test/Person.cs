using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    //class of person with age method of get and set
    internal class Person
    {
        private int Age;
        public void SetAge(int num)
        { 
            Age = num;
        }
        public int GetAge() { return Age; }
    }
}
