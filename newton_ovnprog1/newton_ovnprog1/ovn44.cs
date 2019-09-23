using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
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
