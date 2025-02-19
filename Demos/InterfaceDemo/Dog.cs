using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Dog : IPettable
    {
        public void ReceivePets()
        {
            Console.WriteLine("Wags Tail");
        }

        public void GetPets()
        {
            Console.WriteLine("Slightly different but still cool");
        }
    }
}
