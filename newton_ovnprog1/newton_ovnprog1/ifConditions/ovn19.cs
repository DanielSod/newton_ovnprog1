using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.ifConditions
{

    //  19.	En anställd som har timlön får, när arbetstiden överstiger 40 timmar per  vecka, 
    //      övertidsbetalning för tiden utöver 40 timmar med en och halv timme  Läs in timlön 
    //      och en veckas arbetstid.Den totala veckolönen beräkans och skrivs ut.

    class ovn19
    {
        public void printOvn19()
        {
            Console.Write("Läs in antal timmar du jobbar denna veckan: ");
            double timmar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Läs in lön: ");
            double lon = Convert.ToDouble(Console.ReadLine());

            double summaLon = 0;

            if (timmar > 40)
            {
                double overtid = timmar - 40;
                double overLon = overtid * (lon * 1.5);
                double normLon = timmar * lon;
                summaLon = normLon + overLon;
            }
            else
                summaLon = timmar * lon;
            
            Math.Round(summaLon, 2);
            Console.WriteLine("Totala lönen är: " + summaLon);
        }

    }
}


#region Teacher

//using System;
//namespace algoritmer
//{
//    /*
//     En anställd som har timlön får, när arbetstiden överstiger 40 timmar per
//     vecka, övertidsbetalning för tiden utöver 40 timmar med en och halv timme
//     Läs in timlön och en veckas arbetstid.
//     Den totala veckolönen beräkans och skrivs ut
//     */

//    public class Övn19
//    {
//        double WeekSalary;

//        public double calcWeekSalary(double salaryPerHour, double workHours)
//        {
//            double OverTime;
//            if (workHours > 40)
//            {
//                OverTime = workHours - 40;
//                WeekSalary = 40 * salaryPerHour + 1.5 * salaryPerHour * OverTime;
//            }
//            else
//            {
//                WeekSalary = workHours * salaryPerHour;
//            }
//            return WeekSalary;
//        }

//        public void printCalcWeekSalary()
//        {
//            Console.WriteLine("Skriv in din timlön: ");
//            double sph = double.Parse(Console.ReadLine());

//            Console.WriteLine("Skriv in din arbetstid under en vecka: ");
//            double wh = double.Parse(Console.ReadLine());

//            Console.WriteLine("Din veckolönd är: " + calcWeekSalary(sph, wh));
//        }
//    }
//}

#endregion