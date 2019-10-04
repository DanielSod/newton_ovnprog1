using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn75: Skapa en array med fem heltal, beräkna summan av alla positiva och alla negativa tal och skriv ut dem.
   Med följande värden i en array:
   2, -3, -5, 8, 10
   så måste printen se ut på följande sätt:

   The sum of all positive nrs are: 20
   The sum of all negative nrs are: -8

 */
    class ovn75
    {
        public void printOvn75()
        {
            int sumPos = 0;
            int sumNeg = 0;

            int[] numbers = { 2, -3, -5, 8, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    sumNeg = numbers[i] + sumNeg;
                else
                    sumPos = numbers[i] + sumPos;
            }
            
            Console.WriteLine("The sum of all positive nrs are: {0}", sumPos);
            Console.WriteLine("The sum of all negative nrs are: {0}", sumNeg);
        }
    }
}
