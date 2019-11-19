using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  47.	Beräkna och skriv ut produkten av dem ojämna heltalen mellan 1 till 15. 
    //      a.dvs, 1*3*5*… *15


    class ovn47
    {
        public void printOvn47()
        {
            Console.Clear();
            Console.WriteLine("47.	Beräkna och skriv ut produkten av dem ojämna heltalen mellan 1 till 15.\n   " +
                " a.dvs, 1*3*5*… *15 \n\n");

            int tal = 1;
            int sum = 1;

            while(tal <= 15)
            { 
                if (tal % 2 != 0)
                {
                    sum = tal * sum;
                    tal++;
                }
            else
                tal++;
            }
            Console.WriteLine("Produkten = "+sum);
           
        }
    }
}
