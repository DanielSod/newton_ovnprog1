﻿using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn27
    {
        public void printSmall()
        {
            int num1, num2, num3;

            Console.Write("Skriv in 3 nummer: \n");
            Console.Write("Nr1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            
            small(num1, num2, num3);

        }

        public void small(int num1, int num2, int num3)
        {
            if (num2<num3 && num2 < num1)
            {
                Console.Write("Nr 2 är minst: "+num2);
            }

            if (num3 < num1 && num3 < num2)
            {
                Console.Write("Nr 3 är minst: " +num3);
            }

            if (num1 < num3 && num1 < num2)
            {
                Console.Write("Nr 1 är minst: " +num1);
            }


        }       

        

    }
}
