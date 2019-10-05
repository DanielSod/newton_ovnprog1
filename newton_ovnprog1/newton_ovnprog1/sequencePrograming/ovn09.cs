using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    //  9. Beräkna en cirkels diameter, omkrets, och area.Läs in cirkelns radie.
    //     Printa resultaten med string interpolation med en enda writeline metod.

    class ovn09
    {
        public void printOvn09()
        {
            Console.Write("Läs in en cirkels radie: ");
            double radie = Convert.ToDouble(Console.ReadLine());

            double diameter = radie * 2;
            double pi = 3.141592;

            double omkrets = pi*diameter;
            double area = pi*(radie*radie);

            Math.Round(diameter, 2);
            Math.Round(omkrets, 2);
            Math.Round(area, 2);

            Console.WriteLine($"Cirkelns diameter är {diameter}\nOmkretsen är {omkrets}\nArean är {area}");
        }

    }
}



#region Teacher

//using System;
//namespace algoritmer.sequencePrograming

//{
//    //Beräkna en cirkels diameter, omkrets, och area. Läs in cirkelns radie.
//    //Printa resultaten med string interpolation med en enda writeline metod.
//    public class Övn9
//    {
//        double Diameter, Omkrets, Area;
//        const double Pi = 3.14;

//        public double calcDiameter(double r)
//        {
//            Diameter = 2 * r;
//            return Diameter;
//        }

//        public double calcOmkrets()
//        {
//            Omkrets = Diameter * Pi;
//            return Omkrets;
//        }

//        public double calcArea(double r)
//        {
//            Area = r * r * Pi;
//            return Area;
//        }


//        public void printCirkel()
//        {
//            Console.WriteLine("Ange radie av en cirkel");

//            double r = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.WriteLine($"Diametern är: {calcDiameter(r)}. Omrkretsen är: {calcOmkrets()}. Arean är: {calcArea(r)}.");
//        }




//    }
//}

#endregion