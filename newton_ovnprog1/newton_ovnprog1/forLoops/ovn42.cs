using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  42.	Läs in och addera 20 heltal, summan ska skrivas ut.
    //      Svaret Måste vara i följande format:
    //      Omgång1 är summan: 1,
    //      Omgång2 är summan: 3,
    //      Omgång3 är summan: 6....och så vidare


    class ovn42
    {
        public void printHelTal()
        {
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                sum = i + sum;
                Console.WriteLine("Omgång {0} är summan: {1}", i, sum);
            }


        }
    }
}
