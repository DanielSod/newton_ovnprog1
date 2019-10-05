using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    //  5. Läs in ett heltal motsvarande svenska kronor och omvandla till pund och dollar.
    //     Antag att kursen för närvarande är 1dollar är 11kr, 1pund är 13kr.

    class ovn05
    {
        public void printOvn05()
        {
            Console.Write("Läs in SEK: ");
            int SEK = Convert.ToInt32(Console.ReadLine());

            int dollar = 11 * SEK;
            int pund = 13 * SEK;

            Console.WriteLine("\nSEK till dollar: " + dollar);
            Console.WriteLine("SEK till pund: " + pund);

        }

    }
}


#region Teacher


//using System;

//namespace algoritmer
//{

//    /*Läs in ett heltal motsvarande svenska kronor och omvandla till pund och
//     dollar
//     Antag att kursen för närvarande är 1dollar är 11kr, 1pund är 13kr*/
//    public class övn5
//    {
//        int dollarRate = 11;

//        int PoundRate = 13;

//        public double SekToDollar(int Sek)
//        {

//            return (double)Sek / dollarRate;
//        }

//        public double SekToPound(int Sek)
//        {

//            return (double)Sek / PoundRate;
//        }

//        public void ConvertCurrency()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Ange antal kr");

//            int Sek = (int)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine("Dollar: {0}", SekToDollar((int)Sek));

//            Console.WriteLine("Pound: {0}", SekToPound((int)Sek));
//        }
//    }
//}

#endregion
