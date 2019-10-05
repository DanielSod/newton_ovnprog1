using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  37.	Läs in antal tal du vill ange, läs sedan in talen och printa ut de.
    //      OBS! Du ska inte kunna skriva in fler eller mindre tal än vad du först angav.
    //      Formatet ska vara följande om jag skrev in 4 för antal siffror som ska
    //      ska skrivas ut.
    //      Skriv in ett tal    23    1:a talet
    //      Skriv in ett tal    65    2:a talet
    //      Skriv in ett tal    8     3:a talet
    //      Skriv in ett tal    455   4:a talet


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
