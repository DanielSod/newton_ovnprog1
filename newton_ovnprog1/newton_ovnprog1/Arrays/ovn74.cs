using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn74: Skapa fem tal i en array, leta upp det största och minsta talen och skriv ut dem.

Med följande värden i en array:
   2, 3, 5, 8, 10
   så måste printen se ut på följande sätt:

    Biggest value is: 10
    Smallest value is: 2

 */
    class ovn74
    {
        public void printOvn74()
        {
            int[] numbers = { 2, 3, 5, 8, 10 };

            int smallest = numbers.Min();
            int biggest = numbers.Max();
            
            Console.WriteLine("Biggest value is: ", biggest);
            Console.WriteLine("Smallest value is: ", smallest);
        }
    }
}
