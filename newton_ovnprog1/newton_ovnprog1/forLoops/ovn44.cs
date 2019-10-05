using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //44. Bestäm hur många tal du vill summera.Läs in detta antal och summera dem, printa ut dem.
    //    Tex om du skriver in 5, så Måste printen se ut på följande vis:
    //    Skriv in antal ggr för Summa beräkningen 5
    //    Omgång1 är summan: 5,
    //    Omgång2 är summan: 10,
    //    Omgång3 är summan: 15,
    //    Omgång4 är summan: 20,
    //    Omgång5 är summan: 25


    class ovn44
    {
        public void printsummaBer()
        {
            Console.Write("Ange omgångar: ");
            int omgangar = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int sum = 0;
            //int prev=0;

            do
            {
                sum = i * omgangar;
                Console.WriteLine("Omgång {0} är summan: {1}", i, sum);
                i++;
            } while (i <= omgangar);


        }

    }
}
