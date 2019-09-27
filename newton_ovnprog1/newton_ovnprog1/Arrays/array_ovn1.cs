using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    class array_ovn1
    {
        public void ArrayEx()
        {
            double[] laps_arr = new double[3];
            laps_arr[0] = 3.25;
            laps_arr[1] = 2.25;
            laps_arr[2] = 3.89;

            double[] machSpeed = { 2.1, 1.8, 3.5 };

            Console.WriteLine($"First Laptime is : {laps_arr[0]}");
            Console.WriteLine($"Second Laptime is : {laps_arr[1]}");
            Console.WriteLine($"Third Laptime is : {laps_arr[2]}");

            Console.WriteLine($"First Machspeed is : {machSpeed[0]}");
            Console.WriteLine($"Second Machspeed is : {machSpeed[1]}");
            Console.WriteLine($"Third Machspeed is : {machSpeed[2]}");

            for (int i = 0; i < laps_arr.Length; i++)
                Console.WriteLine("Lap {0} - Laptime is {1}", i+1, laps_arr[i]);

            Array.Sort(machSpeed);
            Array.Reverse(machSpeed);
            foreach (var mach in machSpeed)
                {
                Console.WriteLine($"Machspeed {mach}");
                }

            
        }

                

    }
}
