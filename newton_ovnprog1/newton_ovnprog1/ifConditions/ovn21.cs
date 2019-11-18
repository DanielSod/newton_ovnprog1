using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  21.	Läs in ett tal, testa om talet är mindre än -10 eller större än 10, 
    //      i så  fall skriv ut “Talet är minst två siffrigt.

    class ovn21
    {
        public void printOvn21()
        {
            Console.Clear();
            Console.WriteLine("21.	Läs in ett tal, testa om talet är mindre än -10 " +
                "   eller \nstörre än 10 i så  fall skriv ut “Talet är minst två siffrigt\n\n");


            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if (tal>10 || tal<-10)
            {
                Console.WriteLine("Talet är tvåsiffrigt");
            }
            else
                Console.WriteLine("is not");
        }

    }
}


#region Teacher


//using System;
//namespace algoritmer
//{
//    /*
//     Läs in ett ta, testa om talet är mindre än -10 eller större än 10, i så
//     fall skriv ut "Talet är minst två siffrigt
//     */
//    public class Övn21
//    {
//        public void testNum(int num)
//        {
//            if (num < -10 || num > 10)
//            {
//                Console.WriteLine("Talet är minst tvåsiffrigt");
//            }
//        }

//        public void printTestNum()
//        {
//            Console.WriteLine("Skriv in ett tal: ");
//            int n = int.Parse(Console.ReadLine());

//            testNum(n);
//        }
//    }
//}

#endregion