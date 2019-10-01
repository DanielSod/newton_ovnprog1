using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.Arrays
{
    /*
    Övn66: En array innehåller personnr, med formatet YYMMDD-NNNN. 
    Kontrollera att födelsedatumet följ av en streck innan de fyra sista siffrorna, 
    skriv ut ett fel meddelande annars.
    */


    class ovn66
    {
        public void printOvn66()
        {
            string[] persnr = { "860103-8417"};

            char sub6_0 = Convert.ToChar(persnr[0].Substring(6,1));

                if (sub6_0 == '-')
                    Console.WriteLine("True!");
                else
                    Console.WriteLine("False!");
        }
    }
}

#region trial_error
/*
int array_length = 1;
string[] pers_nr = new string[array_length];
pers_nr[0] = "850505-1919";
//pers_nr[1] = "950715-1987";
//pers_nr[2] = "930520-3057";
*/


//for (int i = 0; i < array_length; i++)
//{
//}
/*char sub6_1 = Convert.ToChar(pers_nr[1].Substring(6));

if (sub6_1 == '-')
    Console.WriteLine("True!");
else
    Console.WriteLine("False!");

char sub6_2 = Convert.ToChar(pers_nr[2].Substring(6));

if (sub6_2 == '-')
    Console.WriteLine("True!");
else
    Console.WriteLine("False!");
    */

#endregion