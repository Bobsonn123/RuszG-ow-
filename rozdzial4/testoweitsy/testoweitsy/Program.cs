using System;
using System.Linq;
using System.Collections.Generic;

namespace testoweitsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(true));
        }

        public static int MyMethod(bool add3)
        {
            int value = 12;

            if (add3)
            {
                value += 3;
            }
            else
            {
                value -= 2;
            }
            return value;
        }
    }
}
