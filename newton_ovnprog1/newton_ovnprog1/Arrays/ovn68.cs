using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn68: Skapa en array med fem tal, fördubbla värdet på talen på varje indexplats i arrayn. 
    Exempel utprinten ska vara på följande sätt, 
    era värden kan dock variear beroende på siffrorna i eran array, 
    får enbart lösas med någon typ av for loop:

                Index value is  2, the double value is: 4
                Index value is  3, the double value is: 6
                Index value is  5, the double value is: 10
                Index value is  8, the double value is: 16
                Index value is 10, the double value is: 20

 */

    class ovn68
    {
        public void printOvn68()
        {

            Console.WriteLine("Lägg till 5 nr");
            Console.Write("Nr1: "); int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr2: "); int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr3: "); int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr4: "); int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr5: "); int num5 = Convert.ToInt32(Console.ReadLine());

            
            int[] num = { num1, num2, num3, num4, num5 };
            int i = 0;
            do
            {
                
                Console.WriteLine("Index value is {0}, the double value is: {1}",num[i], num[i]*2);
                i++;

            }while(i < 5) ;
            


            #region missförstod uppgift
            /*
            Console.Write("Vilken siffra vill du börja från? ");
            int start = Convert.ToInt32(Console.ReadLine());
            
            

            for (int i = 0; i < 5; i++)
            {
                int[] num = new int[5];
                num[i] = start;
                start++;
                

                Console.WriteLine("Index value is {0}, the double value is: {1}", num[i], num[i] * 2);
            }
            */
            #endregion

        }


    }
}
