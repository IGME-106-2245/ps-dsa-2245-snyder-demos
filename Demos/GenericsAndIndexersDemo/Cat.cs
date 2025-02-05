using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndIndexersDemo
{
    internal class Cat : IActionable
    {
        string actionName = "Meow";
        public string ActionName { get; }

        public void DoAction()
        {
            Console.WriteLine("Cat goes meow");
        }
    }
}
