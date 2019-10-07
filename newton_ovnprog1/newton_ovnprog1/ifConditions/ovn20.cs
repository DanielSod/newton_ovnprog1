using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  20.	Läs in ett tal, testa om talet är mellan 0 till 9, 
    //      i så fall skriv ut kvadraten.Annars generera en felmeddalnde.

    class ovn20
    {
        public void printkvad()
        {
            Console.WriteLine("Mata in ett nr: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            int kvadrat = num1 * num1;
            kvad(num1, kvadrat);
            Console.ReadKey();
        }


        public void kvad(int num1, int kvadrat)
        {
            if (num1 > 0 && num1 < 9)
            {
                Console.Write("Talet i kvadrat är: " + kvadrat);
            }
            else
            {
                Console.Write("Felmeddelande");
            }




        }





    }
}


#region Teacher

//using System;
//namespace algoritmer
//{

//    /*Läs in ett tal, testa om talet är mellan 0 till 9, i så fall skriv ut
//     kvadraten.
//     Annars generera en felmeddalnde
//     */
//    public class Övn20
//    {
//        double Kvadrat;

//        public double calcKvadrat(double tal)
//        {
//            //if(tal <= 0 && tal <= 9)
//            if (0 <= tal && tal <= 9)
//            {
//                Kvadrat = tal * tal;
//            }
//            else
//            {
//                Console.WriteLine("ERROR!!!, talet måste vara mellan 0 till 9");
//                ;
//            }
//            return Kvadrat;
//        }

//        public void printCalcKvadrat()
//        {
//            Console.WriteLine("Skiv in ett tal");
//            double t = double.Parse(Console.ReadLine());

//            Console.WriteLine("Svar: " + calcKvadrat(t));
//        }
//    }
//}

#endregion