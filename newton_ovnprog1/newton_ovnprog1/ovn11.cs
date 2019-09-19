using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn11
    {
        public void printhej()
        {
            Console.Write("Läs in nr1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Läs in nr2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            storre(num1, num2);
            Console.ReadKey();
        }

        public void storre(int num1, int num2)
            {
                if (num1 > num2)
                    {
                        Console.Write("Yeaah" + num1);
                    }
                else
                    {
                        Console.Write("nooo!");
                    }

            }



    }
}
