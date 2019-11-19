using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  33.	Skriv ut talen 100, 99, 98, …., 0.

    class ovn33
    {
        public void printTal()
        {
            Console.Clear();
            Console.WriteLine("33.	Skriv ut talen 100, 99, 98, …., 0. \n\n");


            for (int i = 100; i > 0; i--)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine("0  <--- Du nådde noll!!");
        }

    }
}
