using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1.sequencePrograming
{

    //1.	Beräkna kvadraten på en tal som läses in


    class ovn01
    {
        public void printOvn01()
        {
            Console.Write("Läs in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            int kvadrat = tal * tal;
            Console.WriteLine("Talet i kvadrat är: {0}", kvadrat);
        }
    }
}


#region Teacher

 
//    using System;
//    namespace algoritmer
//    {
//     /*Beräkna kvadraten på en tal som läses in*/

//public class övn1
//{
//    //Medlemsvariabel, anget alltid datatypen följd av variabelnamnet
//    int tal;

//    //funktion, börjar med vilken åtkomst, datatypen, och sedan namnet
//    public int CalcInt()
//    {
//        return tal * tal;
//    }

//    //metod är en funkton som inte har en returvärde, nyckelordet är void
//    public void Print()
//    {
//        Console.WriteLine("Ange en siffra");

//        /*Konsolen använder sig av string datatypen,
//         måste darför omvandlas till en heltal med ordet Convert
//         */
//        tal = Convert.ToInt32(Console.ReadLine());


//        /*
//         Ska man ange värdet av något i konsolen så måste man ange
//         indexvärdet i en array, är det bara en variabel så är alltid
//         indexvärdet 0, då 0 är den första platsen i en array
//         Här anger vi med fritext, sedan indexvärdet inom dubbelcittat,
//         sedan anger vi namnet på funtionen.
//         */
//        Console.WriteLine("Kvadraten: {0}", CalcInt());

//    }


//}
//}


//*/
#endregion