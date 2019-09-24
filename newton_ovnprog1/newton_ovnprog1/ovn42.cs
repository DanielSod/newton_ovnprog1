using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn42
    {
        public void printHelTal()
        {
            int sum = 0;
            for (int i = 1;i<21;i++)
            {
                sum = i + sum;
                Console.WriteLine("Omgång {0} är summan: {1}", i, sum);
            }


        }


    }
}
