using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //      54.	Läs in tio heltal, skriv ut hur många av talen var positiva, 
    //          respektive negativa.Minst en förekomst av både positiva 
    //          respektive tal måste förekomma i de inlästa talen.

    class ovn54
    {
        public void printOvn54()
        {
            Console.Clear();
            Console.WriteLine("54.	Läs in tio heltal, skriv ut hur många av talen var positiva,\n "
              + "respektive negativa.Minst en förekomst av både positiva \n"
              + "respektive tal måste förekomma i de inlästa talen. \n\n");

            int tal = 0;
            int poscount = 0;
            int negcount = 0;
            int count = 0; 
            

            while (count < 10)
            {
                count++;
                Console.Write("Läs in tal 10 (minst 1 neg och 1 pos): ");
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal < 0)
                {
                    negcount++;
                }
                else if (tal > 0)
                {
                    poscount++;
                }
                
            }

            Console.WriteLine("Antal negativa inmatningar: " + negcount);
            Console.WriteLine("Antal positiva inmatningar: " + poscount);
            


        }
    }
}
