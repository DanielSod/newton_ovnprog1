using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{
    class ovn25
    {
        public void printNegPos()
        {
            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal >= 0)
            {
                Console.Write("Positivt");
            }
            else
            {
                Console.Write("Negativt");
            }
        }


    }
}
