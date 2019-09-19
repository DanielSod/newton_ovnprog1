using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class hangman
    {
        public void printhang()
        {
            Console.Write("Game master: Skriv ett ord: ");
            string hangman = Convert.ToString(Console.ReadLine());

            int hangnr = hangman.Length;
            char h1 = hangman[0];
            char h2 = hangman[1];
            char h3 = hangman[2];
            char h4 = hangman[3];
            char h5 = hangman[4];
            char h6 = hangman[5];
            //char h7 = hangman[6];

            


            Console.Clear();


            Console.WriteLine("Game master har valt ett ord med: {0} bokstäver i.", hangnr);
            Console.Write("Spelare: Skriv en bokstav: ");
            char guess1 = Convert.ToChar(Console.ReadLine());
            

            hang(guess1, h1);

        }

        
        public void hang(char h1, char guess1)
        {

            if (guess1 == h1)
            {
                Console.WriteLine("Grattis första bokstaven är: {0} ", h1);

            }
            else
            {
                Console.WriteLine("Försök igen!");

            }




        }
        


    }
}
