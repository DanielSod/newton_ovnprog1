using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{
    class ovn11
    {
        public void printhej()
        {
            Console.Write("Läs in nr1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Läs in nr2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            storre(num1, num2);
            Console.ReadKey();
        }

        public void storre(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.Write("Yeaah" + num1);
            }
            else
            {
                Console.Write("nooo!");
            }

        }



    }
}


#region Teacher

//using System;
//namespace NewtonStudentExecies.ifConditions
//{
//    public class Övn11
//    {
//        public void IsVal1Bigger(double t1, double t2)
//        {
//            if (t1 > t2)
//            {
//                Console.WriteLine("Tal1 är större än tal2");
//            }
//        }

//        public void printIsVal1Bigger()
//        {
//            Console.WriteLine("Läs in tal1");
//            double tal1 = (double)Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Läs in tal2");
//            double tal2 = (double)Convert.ToDouble(Console.ReadLine());

//            IsVal1Bigger(tal1, tal2);
//        }
//    }
//}

#endregion

