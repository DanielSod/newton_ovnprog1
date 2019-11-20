using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

//      56.	Läs in ett antal tal.Inläsningar stoppas av talet 9999. Skriv ut medelvärdet av de inlästa talen.
//          a.Hantera inläsningen om det första inlästa talet är stopvärdet.


    class ovn56
    {
        public void printOvn56()
        {
            Console.Clear();
            Console.WriteLine("56.	Läs in ett antal tal.Inläsningar stoppas av talet 9999. Skriv ut medelvärdet av de inlästa talen."
                            +"a.Hantera inläsningen om det första inlästa talet är stopvärdet. \n\n");

            Console.Write("Läs in tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            int average = 0;
            int sum = 0;
            int count = 0; 

            if (tal == 9999)
            {
                Console.WriteLine("Det här talet avbryter programmet\n" +
                    "början med ett annat tal");
            }
            else
            { 
                while(tal !=9999)
                {
                    count++;
                    sum += tal;
                    Console.Write("Läs in tal: ");
                    tal = Convert.ToInt32(Console.ReadLine());
                    

                }
                average = sum / count;
            }
            Console.WriteLine("Summan är: "+sum);
            Console.WriteLine("Antal inmatningar: "+count);
            Console.WriteLine("Genomsnittet är: "+average);
        }


    }
}
