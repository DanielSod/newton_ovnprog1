using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn73: Skapa en array av 5 positiva tal, skriv ut summan och medel av de fem talen, 
    svaret ska vara med 2 decimaler tex med nedanstående array värden:
    2, 3.5, 5, 8, 10 

   The sum of all array items is: 28,5
   The avverage of all array items is: 5,70

    */

    class ovn73
    {
        public void printOvn73()
        {
            double sum = 0;
            double average = 0;

            double[] numbers = {2, 3.5, 5, 8, 10};

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i] + sum;
            }

            average = sum / (numbers.Length);

            Console.Write("The sum of all array items is: {0}\n", sum);
            Console.Write("The average of all array items is: {0}", average);

        }
    }
}
