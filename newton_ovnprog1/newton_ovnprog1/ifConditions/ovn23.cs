using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  23.	Läs in ett tal, testa om talet är jämt delbart med 3, 
    //      men inte med 30, I så fall divideras talet med 3.

    class ovn23
    {
        public void printOvn23()
        {
            Console.Clear();
            Console.WriteLine("23.	Läs in ett tal, testa om talet är jämt delbart med 3," 
                        + "men inte med 30, I så fall divideras talet med 3.\n\n");

            Console.Write("Läs in ett tal: ");
            double tal = Convert.ToDouble(Console.ReadLine());

            if (tal % 3 == 0 && tal % 30 != 0)
            {
                tal = tal / 3; 
                Console.WriteLine("Talet är delbart med 3 men ej 30");
                Console.WriteLine("Talet delat med 3 = "+tal);
            }
            else
                Console.WriteLine("uppfyller ej krav");

        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Läs in ett tal, testa om talet är jämt delbart med 3, men inte med 30,
//     I så fall divideras talet med 3
//     */
//    public class Övn23
//    {
//        decimal Kvot;

//        public int CalcKvot(int num)
//        {
//            if (num % 3 == 0 && num % 30 != 0)
//            {
//                Kvot = num / 3;
//            }
//            return (int)Kvot;
//        }

//        public void printCalcKvot()
//        {
//            Console.WriteLine("Läs in ett tal: ");
//            int t = int.Parse(Console.ReadLine());

//            Console.WriteLine("Kvoten är: " + CalcKvot(t));
//        }

//    }
//}

#endregion