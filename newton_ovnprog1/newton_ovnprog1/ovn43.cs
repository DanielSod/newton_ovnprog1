using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn43
    {
        public void printJamnHel()
        {
            int sum = 0;
            int omgang = 0;
            for (int i=2;i<32; i++)
            {
                sum = i + sum;
                i++;
                omgang++;
                Console.WriteLine("Omgång{0} är summan {1}", omgang, sum);
            }
        }

    }
}
