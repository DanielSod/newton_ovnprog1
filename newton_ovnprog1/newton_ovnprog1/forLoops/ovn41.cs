﻿using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  41.	Skriv ut summan av talen 1 till 50.
    //      Svaret Måste vara i följande format:

    //      Omgång1 är summan: 1,
    //      Omgång2 är summan: 3,
    //      Omgång3 är summan: 6....och så vidare


    class ovn41
    {
        public void printsummaAvTal()
        {
            Console.Clear();

            Console.Write("Ange omgångar: ");
            int omgangar = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int sum = 0;
            //int prev=0;

            do
            {
                sum = i + sum;
                Console.WriteLine("Omgång {0} är summan: {1}", i, sum);
                i++;
            } while (i <= omgangar);


        }


    }
}
