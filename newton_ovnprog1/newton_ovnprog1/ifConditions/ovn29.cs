﻿using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.ifConditions
{

    //  29.	Beräkna ankomsttiden för ett tåg.
    //      Mata in följande:
    //      tidpunkt i timma och minut för avgången, tex 12:41
    //      körtid i timma och minuter.
    //      Om minuter anges i 60 min eller mer, hantera det genom att 
    //      lägga ett påslag på variabeln för timmar.

    //      Printa klockslaget för ankomsten.Om midnatt passeras ska det även stå” Nästa dag”.


    class ovn29
    {
        public void printOvn29()
        {
            Console.Clear();
            Console.WriteLine("29.	Beräkna ankomsttiden för ett tåg.... \n\n");


            Console.Write("Mata in timme för avgång: ");
            int avresaTim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in minut för avgång: ");
            int avresaMin = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMata in timmars restid: ");
            int resaTim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in minuters restid: ");
            int resaMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");

            //Ankomst: 
            int ankomstTim = avresaTim + resaTim;
            int ankomstMin = avresaMin + resaMin;

            if (ankomstMin >=60)
            {
                int addHour= ankomstMin / 60;
                ankomstTim += addHour;
                ankomstMin = ankomstMin - (addHour * 60);
            }

            if(ankomstTim >= 24)
            {
                ankomstTim = ankomstTim - 24;
                Console.WriteLine("Uppmärksamma att du anländer nästakommande dag!");
            }
            
            Console.WriteLine("Du anländer: {0}:{1}", ankomstTim,ankomstMin);

        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     Beräkna ankomsttiden för ett tåg.
//     Mata in följande:
//     tidpunkt i timma och minut för avgången, tex 12:41
//     körtid i timma och minuter.
//     Om minuter anges i 60 min eller mer, hantera det
//     genom att lägga ett påslag på variabeln för timmar.
//     Printa klockslaget för ankomsten. Om midnatt passeras ska det även stå
//     "Nästa dag"
//     */
//    public class Övn29
//    {

//        int ArrHour;
//        int ArrMin;

//        public void TrainTimeTabell(int depHour, int depMin, int travelHour, int travelMin)
//        {
//            ArrHour = depHour + travelHour;
//            ArrMin = depMin + travelMin;

//            if (ArrMin >= 60)
//            {
//                ArrMin = ArrMin - 60;
//                ArrHour = ArrHour + 1;
//            }

//            if (ArrHour >= 24)
//            {
//                ArrHour = ArrHour - 24;
//                Console.WriteLine("NEXT DAY");
//            }
//            Console.WriteLine($"Arrival is at: {ArrHour}:{ArrMin}");
//        }

//        public void printTrainTimeTabell()
//        {
//            Console.WriteLine("Depature in H");
//            int dh = int.Parse(Console.ReadLine());

//            Console.WriteLine("Depature in Min");
//            int dm = int.Parse(Console.ReadLine());

//            Console.WriteLine("Travel time in H");
//            int th = int.Parse(Console.ReadLine());

//            Console.WriteLine("Travel time in min");
//            int tm = int.Parse(Console.ReadLine());

//            TrainTimeTabell(dh, dm, th, tm);

//        }
//    }
//}

#endregion