using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  34.	Läs in ett tecken i taget tills en * skrivs in.

    class ovn34
    {
        public void printOvn34()
        {
            Console.Clear();
            Console.WriteLine("34.	Läs in ett tecken i taget tills en * skrivs in. \n\n");

            char tecken = 'a';

            while (tecken != '*')
            {
                Console.Write("Skriv in ett tecken: ");
                tecken = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Du tryckte på *, nu får du inte leka mera!");
        }

    }
}
