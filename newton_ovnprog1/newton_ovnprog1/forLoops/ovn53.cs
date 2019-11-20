using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  53.	Läs in tio korrekta tal, korrekta tal är tal mellan 5ooo<n< 10000. 
    //      Skriv ut summan och medelvärdet.


    class ovn53
    {
        public void printOvn53()
        {
            Console.Clear();
            Console.WriteLine("53.	Läs in tio korrekta tal, korrekta tal är tal mellan 5ooo<n< 10000. "
            +"Skriv ut summan och medelvärdet. \n\n");

            int tal = 0;
            int sum = 0;
            int count = 0;
            int average = 0;

            while(count<10)
            {
                
                Console.Write("Läs in tal mellan 5000-10000: ");
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal < 5000 && tal > 10000)
                {
                    Console.WriteLine("Inkorrekt tal");
                }
                else
                {
                    count++;
                    sum += tal;
                }
            }
            average = sum / count;
            
            Console.WriteLine("Summan är: " + sum);
            Console.WriteLine("Antal inmatningar: " + count);
            Console.WriteLine("Genomsnittet är: " + average);
        }
    }
}
