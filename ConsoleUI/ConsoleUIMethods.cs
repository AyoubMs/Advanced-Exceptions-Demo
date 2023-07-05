using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class ConsoleUIMethods
    {
        internal static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");
        }

        internal static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly.");
        }

        internal static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                //throw new InsufficientMemoryException("Tim is too tall for this method.");
                //throw new OutOfMemoryException("This is an out of memory exception");
                throw new SystemException("I am a system exception");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim.");
            }
        }
    }
}
