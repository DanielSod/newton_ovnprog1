using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class switchtry
    {
        public void swihh()
        {

            start:
            
            Console.WriteLine("Välj från meny: ");
                Console.WriteLine("1. Ovning 01-10");
                Console.WriteLine("2. Ovning 11-20");
                Console.WriteLine("3. Ovning 21-30");
                Console.WriteLine("4. Ovning 31-40");
                Console.WriteLine("5. Ovning 41-50");
                Console.WriteLine("6. Ovning 51-60");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                
                { 
                
                    
                    case 1:
                    Console.WriteLine("Ovning 01-10");
                    Console.WriteLine("Ovning 01");
                    Console.WriteLine("Ovning 02");
                    Console.WriteLine("Ovning 03");
                    int caseSubswitch01 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch01)
                    {
                            case 1:
                            Console.WriteLine("Ovning1");
                            break;
                            case 2:
                            Console.WriteLine("Ovning2");
                            break;
                            case 3:
                            Console.WriteLine("Ovning3");
                            break;
                            default:
                            goto start;

                    }   
                    break;
                    case 2:
                    Console.WriteLine("Ovning 11-20");
                    break;
                    case 3:
                    Console.WriteLine("Ovning 21-30");
                    break;
                    case 4:
                    Console.WriteLine("Ovning 31-40");
                    break;
                    case 5:
                    Console.WriteLine("Ovning 41-50");
                    break;
                    case 6:
                    Console.WriteLine("Ovning 51-60");
                    break;

            }
            
            

        }
    }
}
