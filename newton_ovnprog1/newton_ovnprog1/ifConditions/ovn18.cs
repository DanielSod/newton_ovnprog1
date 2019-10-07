using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  18.	Läs in värden av två tal, X och Y.Tilldela sedan variablen A värdet 2 om X är större än 5 + Y.
    //      I annat fall så tilldelas variablen A värdet 5.

    class ovn18
    {
        public void printOvn18()
        {
            Console.WriteLine("Läs in 2 tal");
            Console.Write("Tal 1 (X): ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 2 (Y): ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = tal2 + 5;
            int A = 0;

            if (tal1 > sum1)
                A = 2;
            else
                A = 5;

            Console.WriteLine("\nTal 1 = " + tal1);
            Console.WriteLine("Tal 2 = " + tal2);
            Console.WriteLine("A = " + A);
        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{

//    /*
//     Läs in värden av två tal, X och Y. Tilldela sedan variablen A värdet 2 om
//     X är större än 5 + Y.
//     I annat fall så tilldelas variablen A värdet 5
//     */
//    public class Övn18
//    {
//        int A;

//        public int CalcA(int x, int y)
//        {
//            if (x > 5 + y)
//            {
//                A = 2;
//            }
//            else
//            {
//                A = 5;
//            }
//            return A;
//        }

//        public void printCalcA()
//        {
//            Console.WriteLine("Läs in X: ");
//            int x = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Läs in Y: ");
//            int y = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Värdet på A är: " + CalcA(x, y));
//        }
//    }
//}

#endregion