﻿using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn 70: Skapa en array av både positiva och negativa tal, skriv ut alla positiva tal.
Med följande värden i arrayn:
  2, 3, -5, 8, -10
  så borde printen se ut på följande sätt:

  Enter array elements : 
  Element[1]: 56
  Element[2]: 34
  Element[3]: -234
  Element[4]: -43
  Element[5]: 4
  List of positive numbers : 
  56 34 4 

 */
    class ovn70
    {
        public void printOvn70()
        {
            int[] nums = { 2, 3, -5, -1, 10 };

            Array.Sort(nums);
            
            

            Console.WriteLine("Negativa nr: ");
            for (int i = 0; i < 5; i++)
            {
                if (nums[i] < 0)
                    Console.Write("{0}  ", nums[i]);
            }

            Console.WriteLine("\nPostiva nr: ");

            for (int i = 0; i < 5; i++)
            {
                if (nums[i] > 0)
                    Console.Write("{0}  ", nums[i]);
            }
        }
    }
}
