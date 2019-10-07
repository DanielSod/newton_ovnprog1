using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  17.	Läs in två tal, och dividera det första talet med det andra talet, 
    //      Om det andra talet är 0, ska fel meddelande skrivas ut “ERROR!!!  
    //      Nämnaren är 0, noll division är inte tillåtet”  Annars skriv ut kvoten.

    class ovn17
    {
        public void printOvn17()
        {
            Console.WriteLine("Läs in 2 tal.");
            Console.Write("Tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            double sum = tal1 / tal2;

            if (tal2 == 0)
            {
                Console.WriteLine("ERROR!!!");
                Console.WriteLine("Nämnaren är noll (0), noll division är inte tillåtet");
            }
            else
                Console.Write("Summan (kvoten) är: " + sum);
        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Läs in två tal, och dividera det första talet med det andra talet,
//     Om det andra talet är 0, ska fel meddelande skrivas ut "ERROR!!!
//     Nämnaren är 0, noll division är inte tillåtet"
//     Annars skriv ut kvoten*/
//    public class Övn17
//    {
//        decimal Kvot;

//        public decimal calcDivision(decimal tal1, decimal tal2)
//        {
//            if (tal2 == 0)
//            {
//                Console.WriteLine("ERROR!!!Nämnaren är 0, noll division är inte tillåtet");
//            }
//            else
//            {
//                Kvot = tal1 / tal2;
//                //Kvot = decimal.Divide(tal1, tal2);
//            }
//            return Kvot;
//        }

//        public void printCalcDivision()
//        {
//            Console.WriteLine("Ange tal1: ");
//            decimal t1 = decimal.Parse(Console.ReadLine());


//            Console.WriteLine("Ange tal2: ");
//            decimal t2 = decimal.Parse(Console.ReadLine());


//            Console.WriteLine("Kvoten är: " + calcDivision(t1, t2));
//        }
//    }
//}

#endregion