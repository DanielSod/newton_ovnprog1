using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class ovn55
    {
        public void printCompare()
        {

            Console.Write("Input first number to compare to others: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minst ett av de följande talen måste vara \nstörre samt ett mindre än det första");

            Console.Write("Input number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 4: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 5: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 6: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 7: ");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 8: ");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 9: ");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 10: ");
            int num10 = Convert.ToInt32(Console.ReadLine());
            
            

            numbers(num,num1,num2, num3, num4, num5, num6, num7, num8, num9, num10);

            
            


        }

        public void numbers(int num, int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10)
        {

            int[] num_arr = new int[10];
            num_arr[0] = num1;
            num_arr[1] = num2;
            num_arr[2] = num3;
            num_arr[3] = num4;
            num_arr[4] = num5;
            num_arr[5] = num6;
            num_arr[6] = num7;
            num_arr[7] = num8;
            num_arr[8] = num9;
            num_arr[9] = num10;

            
            int sumsmall = 0;
            int sumbig = 0;
            int i = 0;
            do
            {
                if (num > num_arr[i])
                {
                    //Console.WriteLine(num_arr[i]);
                    sumsmall = sumsmall + num_arr[i];
                    
                    i++;
                }
                else if (num < num_arr[i])
                {
                    //Console.WriteLine(num_arr[i]);
                    sumbig = sumbig + num_arr[i];
                    i++;
                }
            } while (i < 10);
            
            Console.WriteLine("Sum of numbers bigger than {0} is {1} ", num, sumbig);
            Console.WriteLine("Sum of numbers smaller than {0} is {1}", num, sumsmall);

        }



    }
}
