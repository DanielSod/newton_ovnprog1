using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{

    /*
    Övn72: Skapa en array av 5 tal, skriv ut indexet för det sista negativa talet i arrayn. 
    Ett litet tips, om ni löser det med en for loop, börja loopen omvänd.
    Med följande talföjd:
    2, 3, -5, 8, 10
    så SKA print vara i följande format:

    The last negative nr -5 was on index: 2

 */
    class ovn72
    {
        public void printOvn72()
        {
            int[] num = { 2, 3, -5, 8, 10 };

            int lastNegative = 0;
            int lastIndex = 1; 

            for (int i = 0; i < num.Length; i++)
            {
                 if(num[i] <0)
                    {
                        lastNegative = num[i];
                        lastIndex++;
                    }
            }
            
            Console.WriteLine("The last negative nr {0} was on index: {1}", lastNegative, lastIndex);

            // heje hejejehhejeheje nu kör vi igen!
        }
    }
}
//Array.ForEach(num, Console.Write);
//Array.Sort(num);
//Array.Reverse(num);