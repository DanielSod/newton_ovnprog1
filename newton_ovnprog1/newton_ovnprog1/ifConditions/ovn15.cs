using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  15.	Läs in två tal och avgör om det första talet är jämt delbart delbart med det andra talet.

    class ovn15
    {

        public void printOvn15()
        {
            Console.WriteLine("Läs in 2 tal: ");
            Console.Write("Tal1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tal2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal1 % tal2 == 0)
                Console.WriteLine("Tal1 är delbart med tal2!");

        }

    }
}


#region Teacher

//using System;
//namespace NewtonStudentExecies.ifConditions
//{
//    public class Övn15
//    {
//        public void IsEquallyDividable(int tal1, int tal2)
//        {
//            if (tal1 % tal2 == 0)
//            {
//                Console.WriteLine("Jämt tal");
//            }

//        }

//        public void printIsEquallyDividable()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Läs in tal1");
//            int num1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Läs in tal2");
//            int num2 = Convert.ToInt32(Console.ReadLine());

//            IsEquallyDividable(num1, num2);
//        }
//    }
//}

#endregion