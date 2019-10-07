using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  25.	Läs in ett tal och skriv ut om det är positivt eller negativt.

    class ovn25
    {
        public void printNegPos()
        {
            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal >= 0)
            {
                Console.Write("Positivt");
            }
            else
            {
                Console.Write("Negativt");
            }
        }


    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    //Läs in ett tal och skriv ut om det är positivt eller negativt
//    public class Övn25
//    {
//        public void checkPosNeg(decimal num)
//        {
//            if (num > 0)
//            {
//                Console.WriteLine("Positivt tal");
//            }
//            else
//            {
//                if (num < 0)
//                {
//                    Console.WriteLine("Negativt tal");
//                }
//            }
//        }

//        public void printCheckPosNeg()
//        {
//            Console.WriteLine("Skriv in ett tal: ");
//            decimal t = decimal.Parse(Console.ReadLine());

//            checkPosNeg(t);
//        }
//    }
//}

#endregion