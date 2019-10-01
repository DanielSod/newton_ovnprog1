using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn69: Skapa en array på 11 tal, Addera 2 till talen som befinner sig på indexplats
 0, 2, 4, 6, 8, 10.
 Utprinten ska ha följande format, värden i arrayn kan bero på era värden:

  Index 0 has value 4
  Index 2 has value 7
  Index 4 has value 12
  Index 6 has value 1030
  Index 8 has value 100002
  Index 10 has value 4

 */
    class ovn69
    {
        public void printOvn69()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            
            
                
            Console.WriteLine($"Index 0 has value {num[0] + 2}");
            Console.WriteLine($"Index 2 has value {num[2] + 2}");
            Console.WriteLine($"Index 4 has value {num[4] + 2}");
            Console.WriteLine($"Index 6 has value {num[6] + 2}");
            Console.WriteLine($"Index 8 has value {num[8] + 2}");
            Console.WriteLine($"Index 10 has value {num[10] + 2}");


        }
    }
}
