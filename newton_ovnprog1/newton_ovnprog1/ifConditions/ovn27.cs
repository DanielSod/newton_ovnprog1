using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  27.	Läs in tre tal, skriv ut det minsta talet.

    class ovn27
    {
        public void printSmall()
        {
            int num1, num2, num3;

            Console.Write("Skriv in 3 nummer: \n");
            Console.Write("Nr1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr3: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            small(num1, num2, num3);

        }

        public void small(int num1, int num2, int num3)
        {
            if (num2 < num3 && num2 < num1)
            {
                Console.Write("Nr 2 är minst: " + num2);
            }

            if (num3 < num1 && num3 < num2)
            {
                Console.Write("Nr 3 är minst: " + num3);
            }

            if (num1 < num3 && num1 < num2)
            {
                Console.Write("Nr 1 är minst: " + num1);
            }


        }



    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Läs in tre tal, skriv ut det minsta talet
//     */
//    public class Övn27
//    {
//        public static void SmallestNum(decimal num1, decimal num2, decimal num3)
//        {
//            decimal number1 = num1;
//            decimal number2 = num2;
//            decimal number3 = num3;

//            if (num1 < num2 && num1 < num3)
//            {
//                Console.WriteLine($"{number1} är minst");
//            }
//            else if (num2 < num1 && num2 < num3)
//            {
//                Console.WriteLine($"{number2} är minst");
//            }
//            else
//            {
//                Console.WriteLine($"{number3} är minst");
//            }
//        }

//        public void printSmallestNum()
//        {
//            Console.WriteLine("Läs in tal1: ");
//            decimal t1 = decimal.Parse(Console.ReadLine());

//            Console.WriteLine("Läs in tal2: ");
//            decimal t2 = decimal.Parse(Console.ReadLine());

//            Console.WriteLine("Läs in tal3: ");
//            decimal t3 = decimal.Parse(Console.ReadLine());

//            SmallestNum(t1, t2, t3);
//        }
//    }
//}

#endregion