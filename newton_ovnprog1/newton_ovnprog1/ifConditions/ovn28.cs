using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  28.	Läs in tempratur, om temp är mellan 18 till 25 grader, så ska Lagom skrivas ut.
    //      Om det är varmare än 25 grader så ska För varmt skrivas ut.
    //      Om det är under 18 grader så ska det skrivas ut, För kallt.

    class ovn28
    {
        public void printTemp()
        {



            Console.Write("Läs in temperatur: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp <= 18)
            {
                Console.Write("För kallt!");
            }
            else if (temp > 18 && temp <= 25)
            {
                Console.Write("Lagom!");
            }
            else if (temp > 25)
            {
                Console.Write("För varmt!");
            }

        }
    }
}
