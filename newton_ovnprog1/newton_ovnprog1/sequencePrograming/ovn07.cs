using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    //  7. Beräkna vad du ska betala för en tank bensin.Indata är är antal liter, pris per liter och rabatt.
    //     Utdata är priset du ska betala.

    class ovn07
    {
        public void printOvn07()
        {

            Console.Write("\nMata in antal liter: ");
            double liter = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMata in pris/liter: ");
            double prisLit = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMata in rabatt: ");
            double rabatt = Convert.ToDouble(Console.ReadLine());
            rabatt = (100 - rabatt) / 100;


            double totPris = liter * prisLit * rabatt;

            Console.WriteLine("\nPriset du ska betala är: " + totPris);

        }

    }
}


#region Teacher

//using System;
//using static System.Console;

//namespace algoritmer
//{
//    /*
//     * Beräkna vad du ska betala för en tank bensin
//     Indata är är antal liter, pris per liter och rabatt.
//     Utdata är priset du ska betala.
//     */

//    public class Övn7
//    {
//        double literAntal, prisPerLiter, bruttoPris, nettoPris, rabatt;

//        public double calcPrice(double la, double ppl, double rab)
//        {
//            literAntal = la;
//            prisPerLiter = ppl;
//            rabatt = rab;
//            bruttoPris = literAntal * prisPerLiter;
//            //algorithm for net price
//            nettoPris = (100 - rabatt) / 100 * bruttoPris;
//            //Then return the value of net price
//            return nettoPris;
//        }

//        public void PrintPris()
//        {
//            OutputEncoding = System.Text.Encoding.UTF8;
//            WriteLine("Ange antal liter");
//            double la = Convert.ToDouble(ReadLine());
//            WriteLine("Ange pris per liter");
//            double ppl = Convert.ToDouble(ReadLine());
//            WriteLine("Ange rabatt");
//            double rab = Convert.ToDouble(ReadLine());
//            //Call method calcPrice, and put the value of it in local var totalPrice
//            double totalPrice = calcPrice(la, ppl, rab);
//            //Print the value of Total price
//            WriteLine("Nettopris: {0}", totalPrice);
//        }
//    }
//}

#endregion