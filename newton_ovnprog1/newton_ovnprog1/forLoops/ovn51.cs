using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  51.	Läs in tio heltal, och skriv ut hur många ggr talet 7 har lästs in. 
    //      Talet 7 måste förekomma minst en gång.

    class ovn51
    {
        public void printOvn51()
        {
            Console.Clear();
            Console.WriteLine("51.	Läs in tio heltal, och skriv ut hur många ggr talet 7 har lästs in. \n" +
                "Talet 7 måste förekomma minst en gång. \n\n");

            int[] talen = new int[9];
            int sjuor = 0; 

            for (int i = 0; i < talen.Length; i++)
            {
                Console.Write("Mata in tal: ");
                talen[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var tal in talen)
            {
                if(tal == 7)
                {
                    sjuor++;
                }

            }
            Console.WriteLine("Tal 7 förekommer: {0} ggr", sjuor);


        }
    }
}
