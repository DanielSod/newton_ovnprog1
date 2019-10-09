using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays.w3resource
{

        //    8. Write a program in C# Sharp to count the frequency of each element of an array. Go to the editor
        //Test Data :
        //Input the number of elements to be stored in the array :3
        //Input 3 elements in the array :
        //element - 0 : 25
        //element - 1 : 12
        //element - 2 : 43
        //Expected Output :
        //Frequency of all elements of array :
        //25 occurs 1 times
        //12 occurs 1 times
        //43 occurs 1 times

    class ovn08w3
    {
        public void printOvn08w3()
        {

        }

    }
}


#region Solution

//using System;  
//public class Exercise8
//{
//    public static void Main()
//    {
//        int[] arr1 = new int[100];
//        int[] fr1 = new int[100];
//        int n, i, j, ctr;


//        Console.Write("\n\nCount the frequency of each element of an array:\n");
//        Console.Write("----------------------------------------------------\n");

//        Console.Write("Input the number of elements to be stored in the array :");
//        n = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input {0} elements in the array :\n", n);
//        for (i = 0; i < n; i++)
//        {
//            Console.Write("element - {0} : ", i);
//            arr1[i] = Convert.ToInt32(Console.ReadLine());
//            fr1[i] = -1;
//        }
//        for (i = 0; i < n; i++)
//        {
//            ctr = 1;
//            for (j = i + 1; j < n; j++)
//            {
//                if (arr1[i] == arr1[j])
//                {
//                    ctr++;
//                    fr1[j] = 0;
//                }
//            }

//            if (fr1[i] != 0)
//            {
//                fr1[i] = ctr;
//            }
//        }
//        Console.Write("\nThe frequency of all elements of the array : \n");
//        for (i = 0; i < n; i++)
//        {
//            if (fr1[i] != 0)
//            {
//                Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
//            }
//        }
//    }
//}


#endregion