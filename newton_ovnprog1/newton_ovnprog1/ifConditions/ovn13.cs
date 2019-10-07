using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  13.	Läs in ett tal, är talet jämt, skriv Jämt tal, använd modulus operatorn %.

    class ovn13
    {
        public void printOvn13()
        {
            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal % 2==0)
                Console.WriteLine("Jämnt tal");
            
        }

    }
}


#region Teacher

//using System;
//namespace NewtonStudentExecies.ifConditions
//{
//    public class Övn13
//    {
//        public void IsEven(int num)
//        {
//            if (num % 2 == 0)
//            {
//                Console.WriteLine("Talet är jämt delbart");
//            }
//        }

//        public void printIsEven()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Läs in tal");
//            int num = Convert.ToInt32(Console.ReadLine());

//            IsEven(num);

//        }
//    }
//}

#endregion