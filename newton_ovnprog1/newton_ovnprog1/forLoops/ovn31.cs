using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  31.	Läs in ett antal tal som skrivs ut, avsluta med 0.

    class ovn31
    {
        public void printOvn31()
        {
            Console.Clear();
            Console.WriteLine("31.	Läs in ett antal tal som skrivs ut, avsluta med 0. \n\n");

            int tal1 = 1;

            while (tal1 !=0)
            {
                Console.Write("Läs in ett tal: ");
                tal1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Du tryckte på 0, nu får du inte leka mera!");



        }

    }
}


#region Teacher



#endregion