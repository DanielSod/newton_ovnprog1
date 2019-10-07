using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{
    
    //  12. Läs in två tal, kontrollera om det första talet är mer än dubbelt så stort som det andra talet.

    class ovn12
    {
        public void printOvn12()
        {
            Console.WriteLine("Mata in 2 tal");
            Console.Write("Tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int compare = tal2 * 2;

            if (tal1 >= compare)
                Console.WriteLine("Tal 1 ÄR mer än dubbelt så stort som tal2");
            else
                Console.WriteLine("Tal 1 är INTE dubbelt så stort som tal2");
        }
    }
}


#region Teacher

//using System;
//namespace NewtonStudentExecies.ifConditions
//{
//    public class Övn12
//    {
//        public void isVal1DoubleSize(double t1, double t2)
//        {
//            if (t1 * 2 > t2)
//            {
//                Console.WriteLine("Tal1 är dubbelt så stort som tal2");
//            }
//        }

//        public void printisVal1DoubleSize()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Läs in tal1");
//            double tal1 = (double)Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Läs in tal2");
//            double tal2 = (double)Convert.ToDouble(Console.ReadLine());

//            isVal1DoubleSize(tal1, tal2);
//        }
//    }
//}

#endregion
