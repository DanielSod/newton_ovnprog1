using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace newton_ovnprog1.sequencePrograming
{

    //  10. Läs in tempraturen i Farenheit och konvertera till Celsius

    class ovn10
    {
        public void printOvn10()
        {
            Console.Write("Skriv temperatur i farenheit: ");
            double far = Convert.ToDouble(Console.ReadLine());

            double celsius = (far - 32) / 1.8;
            Console.WriteLine("{0} Fahrenheit motsvarar {1} Celsius", far, celsius);
        }

    }
}


#region Teacher

//    using System;
//namespace algoritmer.sequencePrograming

//{
//    //Läs in tempraturen i Farenheit och konvertera till Celsius
//    public class Övn10
//    {
//        double Celsius;

//        public double convertFarenhitToCelsius(double f)
//        {
//            Celsius = 5 * (f - 32) / 9;
//            return Celsius;
//        }

//        public void printCF()
//        {
//            Console.Write("Mata in tempraturen i Farenheit: ");

//            double f = (double)Convert.ToDecimal(Console.ReadLine());

//            Console.Write($"Temprature i Cesius är: {convertFarenhitToCelsius(f)}");
//        }
//    }
//}


#endregion