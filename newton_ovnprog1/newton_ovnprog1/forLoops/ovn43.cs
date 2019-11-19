using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  43.	Skriv ut summan av de jämna heltalen från 2 till 30.
    //      Svaret Måste vara i följande format:
    //      Omgång1 är summan: 2,
    //      Omgång2 är summan: 6,
    //      Omgång3 är summan: 12....och så vidare


    class ovn43
    {
        public void printJamnHel()
        {
            Console.Clear();

            int sum = 0;
            int omgang = 0;
            for (int i = 2; i < 32; i++)
            {
                sum = i + sum;
                i++;
                omgang++;
                Console.WriteLine("Omgång{0} är summan {1}", omgang, sum);
            }
        }
    }
}
