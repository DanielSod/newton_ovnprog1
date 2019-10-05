using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    //3.  Beräkna antal minuter och secunder efter ha anget antal timmar

    class ovn03
    {
        public void printOvn03()
        {

            Console.Write("Ange antal timmar: ");
            double tim = Convert.ToDouble(Console.ReadLine());

            double min = tim * 60;
            double sek = min * 60;

            Console.WriteLine("Minuter: " + min);
            Console.WriteLine("Sekunder: " + sek);

        }

    }
}

#region Teacher

//using System;
//namespace algoritmer
//{

//    //Beräkna antal minuter och secunder efer ha anget antal timmar
//    public class övn3
//    {
//        double hours;
//        double min;
//        double sec;

//        public int HoursToMin()
//        {
//            return (int)(min = hours * 60);
//            // Kan också skrivas med min *= 60;
//        }

//        public int HoursToSec()
//        {

//            return (int)(sec = hours * 60 * 60);
//        }

//        public void PrintHoursSec()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Ange timmar");

//            hours = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine("Minuter: {0}", HoursToMin());

//            Console.WriteLine("Sekunder: {0}", HoursToSec());

//            //Alternativt
//            Console.WriteLine("{0}.{1}", min, sec + " minuter och sekunder");

//            //Alternativt
//            Console.WriteLine($"{min}.{sec}" + " minuter och sekunder");
//        }
//    }
//}

#endregion
