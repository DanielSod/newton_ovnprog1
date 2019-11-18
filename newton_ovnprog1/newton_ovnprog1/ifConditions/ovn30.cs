using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  30.	Läs in ett tal, Printa ut om talet är 
    //      mindre än 10, mindre än 100, eller större än 100.

    class ovn30
    {
        public void printOvn30()
        {
            Console.Clear();
            Console.WriteLine("30.	Läs in ett tal, Printa ut om talet är "
                        + "mindre än 10, mindre än 100, eller större än 100.\n\n");

            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            if(tal>100)
            {
                Console.WriteLine("Talet är större än 100");
            }
            else if (tal<100 && tal>10)
            { 
                Console.WriteLine("Talet är mindre än 100");
            }
            else if(tal<10)
            { 
                Console.WriteLine("Talet är mindre än 10"); 
            }
        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{

//    /*
//     Läs in ett tal, Printa ut om talet är mindre än 10, mindre än 100, eller
//     större än 100
//     */
//    public class Övn30
//    {
//        public void CheckNumber(int num)
//        {
//            if (num < 10)
//            {
//                Console.WriteLine("Talet är mindre än 10");
//            }
//            else if (num < 100)
//            {
//                Console.WriteLine("Talet är mindre än 100");
//            }
//            else
//            {
//                Console.WriteLine("Talet är större än 100");
//            }
//        }

//        public void printCheckNumber()
//        {
//            Console.WriteLine("Mata in ett heltal");
//            int t = int.Parse(Console.ReadLine());

//            CheckNumber(t);
//        }
//    }
//}

#endregion