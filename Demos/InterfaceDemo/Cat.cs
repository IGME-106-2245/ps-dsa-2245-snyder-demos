using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Cat : IPettable
    {
        public void ReceivePets()
        {
            Console.WriteLine("Scratches You");
        }
    }
}
