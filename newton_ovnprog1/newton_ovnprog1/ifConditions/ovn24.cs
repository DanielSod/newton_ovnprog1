using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  24.	Läs in kropptempraturen, skriv “VARNING!!“” om temp är mindre än 35, 
    //      och om temp överstiger 42.

    class ovn24
    {
        public void printOvn24()
        {
            Console.Clear();
            Console.WriteLine("24.	Läs in kropptempraturen, skriv “VARNING!!“” om temp är "
                        + "mindre än 35 och om temp överstiger 42\n\n");

            Console.Write("Läs in kroppstemperatur: ");
            double kroppTemp = Convert.ToDouble(Console.ReadLine());

            if (kroppTemp<35 || kroppTemp>42)
            {
                Console.WriteLine("Varning!!");
            }
            else
                Console.WriteLine("Allt är bra");

        }

    }
}


#region Teacher


//using System;
//namespace algoritmer
//{
//    /*
//     Läs in kropptempraturen, skriv "VARNING!!"" om temp är mindre än 35, och
//     om temp överstiger 42
//     */
//    public class Övn24
//    {
//        public void checkTemp(decimal temp)
//        {
//            if (temp < 35 || temp > 42)
//            {
//                Console.WriteLine("VARNING");
//            }
//        }

//        public void printCheckTemp()
//        {
//            Console.WriteLine("Läs in tempraturen: ");
//            decimal t = decimal.Parse(Console.ReadLine());

//            checkTemp(t);
//        }
//    }
//}

#endregion