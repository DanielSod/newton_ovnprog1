using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn49
    {
        public void printAlgo()
        {
            Console.Write("Mata in x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double sum = Math.Pow(x,n);
            Console.Write("f(x) = {0}", sum);

        }
    }
}
