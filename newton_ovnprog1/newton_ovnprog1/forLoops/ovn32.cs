using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{
    class ovn32
    {
        public void printtwocountup()
        {
            Console.Write("Skriv en siffra mellan 1-100: ");
            int num = Convert.ToInt32(Console.ReadLine());

            twocountup(num);




            Console.ReadKey();
        }

        public void twocountup(int num)
        {
            for (int i = num; i <= 100; i += 2)
            {
                Console.Write("{0}, ", i);
                if (i == 100)

                  Console.WriteLine("Du har VUNNIT!!");


            }

        }

    }
}
