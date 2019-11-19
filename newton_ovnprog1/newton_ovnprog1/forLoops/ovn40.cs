using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

//    40. Skriv ut svaret för följande algoritm.
//        a.f(x)=3x3-5x2+2x-20
//        b.Skriv ut resultatet om x är ett heltal mellan -10 och 10.


    class ovn40
    {
        public void printOvn40()
        {
            Console.Clear();
            Console.WriteLine("Skriv ut svaret för följande algoritm: \n   a.f(x)=3x3-5x2+2x-20\n   " +
                "b.Skriv ut resultatet om x är ett heltal mellan -10 och 10. \n\n");

            Console.WriteLine("f(x) = 3x3-5x2+2x-20");
            Console.Write("\nMata in x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            double sum = (3 * x * 3) - (5*x*2) + (2*x) - (20);

            if (sum <= 10 && sum >= -10 && sum%1==0)
            {
                Console.WriteLine("Svaret är: "+sum);
            }
            else
            Console.WriteLine("Jag skriver ut svaret fast jag inte får: "+sum);


        }
    }
}
