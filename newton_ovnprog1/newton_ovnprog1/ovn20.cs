﻿using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn20
    {
        public void printkvad()
        {
            Console.WriteLine("Mata in ett nr: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            int kvadrat = num1 * num1;
            kvad(num1, kvadrat);
            Console.ReadKey();
        }


        public void kvad(int num1, int kvadrat)
        {
            if (num1>0 && num1<9)
            {
                Console.Write("Talet i kvadrat är: " + kvadrat);
            }
            else
            {
                Console.Write("Felmeddelande");
            }




        }




    }
}
