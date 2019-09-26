using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{
    class ovn37
    {
        public void printAntTal()
        {
            Console.WriteLine("Läs in antal tal du vill ange: ");
            int antal = Convert.ToInt32(Console.ReadLine());


            int[] nr_array = new int[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.Write("Skriv in ett tal: ");
                nr_array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{1} <-- tal nr {0}", i + 1, nr_array[i]);
            }


        }

    }
}
