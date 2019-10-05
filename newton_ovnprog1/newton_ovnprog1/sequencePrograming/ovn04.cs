using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    // 4. Läs in tre tal, beräkna sedan medelvärdet av dess och summan

    class ovn04
    {
        public void printOvn04()
        {
            Console.WriteLine("Mata in 3 tal\n");

            Console.Write("Mata in tal1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in tal2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in tal3: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());

            double sum = tal1 + tal2 + tal3;
            double average = sum / 3;
            

            Console.Write("\nSumman är: " + sum);
            Console.Write("\nGenomsnittet är: " + average);
        }
    }
}


#region Teacher

    
//using System;
//namespace algoritmer
//{

//    //Läs in tre tal, beräkna sedan medelvärdet av dess och summan
//    public class övn4
//    {
//        double Average;
//        double Sum;

//        /*
//         Man kan också ange argument i en funktion eller metod, nedan har vi
//         tre olika argument, som vi sedan använder i vår beräkning*/
//        public double CalcAverage(double val1, double val2, double val3)
//        {
//            Sum = val1 + val2 + val3;
//            Console.WriteLine("Summan:" + $"{Sum}");
//            return Average = Sum / 3;
//        }


//        public void PrintResult()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Ange första talet");
//            double val1 = (double)Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("Ange andra talet");
//            double val2 = (double)Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("Ange tredje talet");
//            double val3 = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine("Medeltal: {0}", CalcAverage(val1, val2, val3));
//        }


//    }
//}

#endregion