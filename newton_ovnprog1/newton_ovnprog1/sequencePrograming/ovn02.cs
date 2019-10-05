using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.sequencePrograming
{

    // 2. En försäljare har delvis prestationslön, Han får 8000kr/månaden i grundlön och 9% av försäljningssumman.
    //    Beräkna lönesumman under en period, försäljningssumman ska läsas in


    class ovn02
    {
        public void printOvn02()
        {
            int grundLon = 8000;
            
            Console.Write("Mata in säljsumma: ");
            double sell = Convert.ToInt32(Console.ReadLine());
            double provision = sell * 0.09;

            Console.Write("\nGrundlön: " + grundLon);
            Console.Write("\nSäljsumma: " + sell);
            Console.Write("\nProvision: " + provision);

            double totLon = grundLon + provision;
            Console.Write("\n\nTotal lön: "+totLon);
        }
    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     En försäljare har delvis prestationslön, Han får 8000kr/månaden i grundlön
//     och 9% av försäljningssumman
//     Beräkna lönesumman under en period, försäljningssumman ska läsas in*/
//    public class övn2
//    {
//        double Salary;
//        double Bonus = 0.09;
//        double Sales;
//        double StartSalary = 8000;

//        public double CalcSalary()
//        {
//            return Salary = Bonus * Sales + StartSalary;
//        }

//        public void PrintSalary()
//        {
//            //För att ange svenska tecken i konsolprogram
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Ange försälning denna månad");

//            Sales = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine("Slutlön: {0}", CalcSalary());
//        }
//    }
//}

#endregion