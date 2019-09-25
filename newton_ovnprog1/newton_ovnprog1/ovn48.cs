using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn48
    {
        public void printFakulteten()
        {
            
            Console.Write("Mata in n (fakulteten): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            int tal = 1;

            Console.Write("{0}!=", n);

            for(i=0;i<n;i++)
            {
                Console.Write("{0}",tal);
                
                tal++;
                if (i<n-1)
                Console.Write("*");
                
            }
            

        }



    }
}
