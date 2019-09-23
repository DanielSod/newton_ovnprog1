using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn46
    {
        public void printDayToMill()
        {

            int i= 1;
            double sum = 1;
            double totspar = 0;
            do
            {
                sum = sum * 2;
                totspar = totspar + sum;
                Console.Write("\n Antal dagar: {0} och summa: {1} kr", i, totspar/100);
                i++;

            } while (totspar < 100000000);

            //Console.Write("Antal dagar: " + i);




        }




    }
}
