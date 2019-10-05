using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    // 8. Läs in sidorna av en rektangel, beräkna och skriv ut arean och omkretsen

    class ovn08
    {
        public void printOvn08()
        {
            Console.WriteLine("Läs in sidor av en rektangel");
            Console.Write("\nLängd: ");
            double langd = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nBredd: ");
            double bredd = Convert.ToDouble(Console.ReadLine());

            double area = bredd * langd;
            double omkrets = (bredd * 2) + (langd * 2);

            Console.WriteLine("\nArea: " + area);
            Console.WriteLine("Omkrets: " + omkrets);
        }

    }
}


#region Teacher

//using System;
//namespace algoritmer.sequencePrograming

//{
//    //Läs in sidorna av en rektangel, beräkna och skriv ut arean och omkretsen
//    public class Övn8
//    {
//        double area, circ;

//        public double CalcArea(double h, double w)
//        {
//            area = h * w;
//            return area;
//        }

//        public double CalcCirc(double h, double w)
//        {
//            circ = 2 * h + 2 * w;
//            return circ;
//        }

//        public void PrintRectangle()
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Skriv in höjden: ");
//            double h = (double)Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("Skriv in bredden: ");
//            double w = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine("Area: {0}", CalcArea(h, w));
//            Console.WriteLine("Circ: {0}", CalcCirc(h, w));
//        }
//    }
//}

#endregion