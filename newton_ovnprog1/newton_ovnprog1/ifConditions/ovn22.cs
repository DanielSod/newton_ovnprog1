using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  22.	Läs in ett tal, testa om talet är mellan 0 till 9, men inte 5.  Printa ut Rätt eller Fel.

    class ovn22
    {
        public void printtwonumbers()
        {
            Console.Write("Mata in ett nr: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            twonumber(num1);

        }

        public void twonumber(int num1)
        {
            if (num1 > 0 && num1 < 9 && num1 != 5)
            {
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine("Fel!");
            }

        }


    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Läs in ett tal, testa om talet är mellan 0 till 9, men inte 5.
//     Printa ut Rätt eller Fel
//     */
//    public class Övn22
//    {
//        public void CheckNum(int num)
//        {
//            if (0 <= num && num <= 9 && num != 5)
//            {
//                Console.WriteLine("RÄTT!!!");
//            }
//            else
//            {
//                Console.WriteLine("FEL!!!");
//            }
//        }

//        public void printCheckNum()
//        {
//            Console.WriteLine("Mata in ett tal: ");

//            int n = int.Parse(Console.ReadLine());
//            CheckNum(n);
//        }
//    }
//}

#endregion