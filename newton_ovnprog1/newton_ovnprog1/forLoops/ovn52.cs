using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  52.	Läs in tio heltal och skriv summan av de positiva talen.
    //      Minst ett negativ tal måste förekomma bland de tio talen.

    class ovn52
    {
        public void printOvn52()
        {
            Console.Clear();
            Console.WriteLine("52.	Läs in tio heltal och skriv summan av de positiva talen."
              +"Minst ett negativ tal måste förekomma bland de tio talen. \n\n");

            int[] allaTal = new int[10];
            int sum = 0;

            for (int i = 0; i < allaTal.Length; i++)
            {
                Console.Write("Läs in ett tal: ");
                allaTal[i] = Convert.ToInt32(Console.ReadLine());

                if (allaTal[i] > 0)
                {
                    sum += allaTal[i];
                }
            }
            Console.WriteLine($"Summan av de positiva talen är: {sum}");
            

        }
    }
}
