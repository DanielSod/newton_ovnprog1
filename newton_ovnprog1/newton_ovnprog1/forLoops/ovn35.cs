using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.forLoops
{

    //  35.	Beräkna kvadraten för talen 1 till 9.

    class ovn35
    {
        public void printkvadrater()
        {
            int kvadrat;

            int i = 1;
            do
            {

                kvadrat = i * i;
                Console.WriteLine("Kvadraten av {0}: {1}", i, kvadrat);
                i++;

            } while (i < 10);

            Console.ReadKey();
        }

    }
}
