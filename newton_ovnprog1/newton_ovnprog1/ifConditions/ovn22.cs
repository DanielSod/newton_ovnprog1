using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{
    class ovn22
    {
        public void printtwonumbers()
        {
            Console.Write("Mata in ett nr: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            twonumber(num1);

        }

        public void twonumber(int num1)
        {
            if (num1 > 0 && num1 < 9 && num1 != 5)
            {
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine("Fel!");
            }

        }


    }
}
