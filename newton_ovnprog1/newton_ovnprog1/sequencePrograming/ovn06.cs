using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    // 6. Beräkna resultatet av funktionen ax^3+7. Variablerna a och x ska läsas in.

    class ovn06
    {
        public void printOvn06()
        {
            Console.WriteLine("Funktionen ax^3+7 = ???");
            Console.WriteLine("Läs in variabel a och x");
            Console.Write("\n  a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("  x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            double pwrTo = Math.Pow(x, 3);

            double resultat = (a * pwrTo) + 7;

            Console.Write("\n\nSvaret är: " + resultat);

        }

    }
}


#region Teacher

//using System;
//using static System.Console;

//namespace algoritmer
//{

//    /*
//     Beräkna resultatet av funktionen ax^3+7
//     Variablerna a och x ska läsas in
//     */
//    public class övn6
//    {

//        public int Algo(int a, int x)
//        {
//            return (a * x * x * x) + 7;
//        }

//        public void PrintAlgo()
//        {
//            OutputEncoding = System.Text.Encoding.UTF8;
//            WriteLine("Ange värdet för a");
//            int a = (int)Convert.ToDecimal(ReadLine());
//            WriteLine("Ange värdet för x");
//            int x = (int)Convert.ToDecimal(ReadLine());
//            WriteLine("Svar: {0}", Algo((int)a, (int)x));
//        }

//    }
//}

#endregion