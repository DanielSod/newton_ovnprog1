using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{
    class ovn26
    {
        public void printStorst()
        {
            Console.Write("Skriv in ett tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv ett till tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            if (tal1 > tal2)
            { Console.Write("{0} är störst", tal1); }
            else if (tal1 < tal2)
            { Console.Write("{0} är störst", tal2); }
            else if (tal1 == tal2)
            { Console.Write("Talen är lika stora"); }
        }

    }
}
