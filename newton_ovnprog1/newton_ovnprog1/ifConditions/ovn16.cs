using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //      16.	En firma erbjuder sina kunder 10% rabatt om man vid ett köptillfälle handlar för minst 1000kr
    //          Antag för enkelhetens skull att man bara handlar varor av samma typ.Beräkna vad en kund ska betala, 
    //          indata är antal köpta enheter, samt pris  per enhet.

    class ovn16
    {
        public void printOvn16()
        {
            Console.Write("Hur många varor vill du köpa? ");
            double enheter = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nVad är pris/enhet? ");
            double prisEnhet = Convert.ToInt32(Console.ReadLine());

            double summaShop = enheter * prisEnhet;

            if (summaShop > 1000)
            {
                summaShop = summaShop * 0.9;
                Console.Write("\nSumman för köper är: " + summaShop);
                Console.Write("\nDu fick rabatt!!!");
            }
            else
            { 
                Console.Write("\nSumman för köper är: " + summaShop);
                Console.Write("\nDu fick ej rabatt");
            }

        }

    }
}


#region Teacher

//using System;
//namespace NewtonStudentExecies.ifConditions
//{
//    public class Övn16
//    {
//        int totPrice;

//        public int calcTotalPrice(int price, int units)
//        {
//            totPrice = price * units;

//            if (totPrice > 1000)
//            {
//                totPrice = (int)(totPrice * 0.9);
//            }
//            return totPrice;

//        }

//        public void printcalcTotalPrice()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Läs in pris för varan");
//            int p = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Läs in antal");
//            int a = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Totalpriset är: " + calcTotalPrice(p, a));
//        }
//    }
//}

#endregion