using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn28
    {
        public void printTemp()
        {



            Console.Write("Läs in temperatur: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp<=18)
            {
                Console.Write("För kallt!");
            }
            else if (temp>18 && temp<=25)
            {
                Console.Write("Lagom!");
            }
            else if (temp>25)
            {
                Console.Write("För varmt!");
            }

        }
    }
}
