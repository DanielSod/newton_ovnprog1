using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
     Övn67: Avgör med personnr om det är en man eller kvinna, med formatet YYMMDD-NNNN.
Om nästsista nr är jämnt delbart så är det en kvinna, annars en man.
Printa ut Man eller Kvinna.


     */
    class ovn67
    {
        public void printOvn67()
        {
            string pers_nr = "870505-1533";
            int fyrasista1 = Convert.ToInt32(pers_nr.Substring(7,4));

            if (fyrasista1 % 2 == 0)
                Console.Write("Quinna");
            else
                Console.Write("Karlslok");

        }
    }
}
