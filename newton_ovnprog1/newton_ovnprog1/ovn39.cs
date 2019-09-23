using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn39
    {
        public void printPrice()
        {
            Double pris;
            

            Console.Write("Skriv in ett pris: ");
            pris = Convert.ToDouble(Console.ReadLine());


            totprice(pris);


        }

        public void totprice(Double pris)
        {

            if (pris != 0)
            {
                pris = pris * 1.25;
                Console.Write("\nPris inkl. moms: {0}kr", pris);
            }

        }

    }
}
