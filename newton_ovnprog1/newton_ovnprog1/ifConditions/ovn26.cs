using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  26.	Läs in två tal, och skriv ut det största talet, följt av orden “är störst”.  
    //      Om talet är lika, skriv ut “Talen är lika”.

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


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Läs in två tal, och skriv ut det största talet, följt av orden "är störst"
//     Om talet är lika, skriv ut "Talen är lika"
//     */
//    public class Övn26
//    {
//        public void CheckBigNum(decimal num1, decimal num2)
//        {
//            if (num1 > num2)
//            {
//                Console.WriteLine("Tal1 är störst");
//            }
//            else if (num2 > num1)
//            {
//                Console.WriteLine("Tal2 är störst");
//            }
//            else
//            {
//                Console.WriteLine("Talen är lika");
//            }
//        }

//        public void printCheckBigNum()
//        {
//            Console.WriteLine("Skriv in tal1");
//            decimal t1 = decimal.Parse(Console.ReadLine());

//            Console.WriteLine("Skriv in tal2");
//            decimal t2 = decimal.Parse(Console.ReadLine());

//            CheckBigNum(t1, t2);
//        }
//    }
//}

#endregion