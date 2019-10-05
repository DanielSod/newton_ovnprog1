using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  48.	Skriv ut n! (fakulteten). n ska läsas in.
    //      a.ex: 3!=1*2*3
    //      b.ex: 5!=1*2*3*4*5


    class ovn48
    {
        public void printFakulteten()
        {

            Console.Write("Mata in n (fakulteten): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            int tal = 1;

            Console.Write("{0}!=", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("{0}", tal);

                tal++;
                if (i < n - 1)
                    Console.Write("*");

            }


        }

    }
}
