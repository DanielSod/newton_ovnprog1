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
            Console.Clear();
            Console.WriteLine("          #   # ");
            Console.WriteLine("           # #  ");
            Console.WriteLine("            #   ");
            Console.WriteLine("       Victorious");
            Console.WriteLine("        Glorious");
            Console.WriteLine("");
            Console.WriteLine("      Here to rule");
            Console.WriteLine("         all CODE");
            Console.WriteLine("");
            Console.WriteLine("      Välj från meny: ");
                Console.WriteLine("   1. Sequence Proframming: 01-10");
                Console.WriteLine("   2. If conditions: 11-30");
                Console.WriteLine("   3. ForLoops 31-60?");
                Console.WriteLine("   4. Arrays");
                Console.WriteLine("   5. Collections");
                Console.WriteLine("   0. Avslutar programmet");
                
                //Console.WriteLine("6. Ovning 51-60");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)

            {

                #region Sequence programming
                case 1:
                    Console.WriteLine("Sequence Proframming: 01-10");
                    Console.WriteLine("1. Övning 1");
                    Console.WriteLine("2. Övning 2");
                    Console.WriteLine("3. Övning 3");
                    Console.WriteLine("4. Övning 4");
                    Console.Write("Ange val: ");
                    int caseSubswitch01 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch01)
                    {
                        case 1:

                            //sequencePrograming.ovn01 o01= new sequencePrograming.ovn01();
                            //o01.hello();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 2:
                            Console.WriteLine("Ovning2");
                            break;
                        case 3:
                            Console.WriteLine("Ovning3");
                            break;
                        default:
                            goto start;

                    }
                    goto start;
                #endregion

                #region If_Conditions
                case 2:
                    Console.WriteLine("If Conditions: 11-30");
                    Console.WriteLine("11. Övning 11");
                    Console.WriteLine("20. Övning 20");
                    Console.WriteLine("25. Övning 25");
                    Console.WriteLine("26. Övning 26");
                    Console.WriteLine("27. Övning 27");
                    Console.WriteLine("28. Övning 28");
                    Console.Write("Ange val: ");
                    int caseSubswitch02 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch02)
                    {
                        case 11:
                            ifConditions.ovn11 o11 = new ifConditions.ovn11();
                            o11.printhej();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 20:
                            ifConditions.ovn20 o20 = new ifConditions.ovn20();
                            o20.printkvad();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 22:
                            ifConditions.ovn22 o22 = new ifConditions.ovn22();
                            o22.printtwonumbers();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 25:
                            ifConditions.ovn25 o25 = new ifConditions.ovn25();
                            o25.printNegPos();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 26:
                            ifConditions.ovn26 o26 = new ifConditions.ovn26();
                            o26.printStorst();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 27:
                            ifConditions.ovn27 o27 = new ifConditions.ovn27();
                            o27.printSmall();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 28:
                            ifConditions.ovn28 o28 = new ifConditions.ovn28();
                            o28.printTemp();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        default:
                            goto start;

                    }
                #endregion

                #region For_Loops
                case 3:
                    Console.WriteLine("For Loops: 31-60");
                    Console.WriteLine("32. Övning 32");
                    Console.WriteLine("33. Övning 33");
                    Console.WriteLine("35. Övning 35");
                    Console.WriteLine("37. Övning 37");
                    Console.WriteLine("39. Övning 39");
                    Console.WriteLine("41. Övning 41");
                    Console.WriteLine("42. Övning 42");
                    Console.WriteLine("43. Övning 43");
                    Console.WriteLine("44. Övning 44");
                    Console.WriteLine("46. Övning 46");
                    Console.WriteLine("48. Övning 48");
                    Console.WriteLine("49. Övning 49");
                    Console.WriteLine("55. Övning 55");
                    Console.Write("Ange val: ");
                    int caseSubswitch03 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch03)
                    {
                        case 32:
                            forLoops.ovn32 o32 = new forLoops.ovn32();
                            o32.printtwocountup();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 33:
                            forLoops.ovn33 o33 = new forLoops.ovn33();
                            o33.printTal();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 35:
                            forLoops.ovn35 o35 = new forLoops.ovn35();
                            o35.printkvadrater();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 37:
                            forLoops.ovn37 o37 = new forLoops.ovn37();
                            o37.printAntTal();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 39:
                            forLoops.ovn39 o39 = new forLoops.ovn39();
                            o39.printPrice();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 41:
                            forLoops.ovn41 o41 = new forLoops.ovn41();
                            o41.printsummaAvTal();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 42:
                            forLoops.ovn42 o42 = new forLoops.ovn42();
                            o42.printHelTal();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 43:
                            forLoops.ovn43 o43 = new forLoops.ovn43();
                            o43.printJamnHel();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 44:
                            forLoops.ovn44 o44 = new forLoops.ovn44();
                            o44.printsummaBer();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 46:
                            forLoops.ovn46 o46 = new forLoops.ovn46();
                            o46.printDayToMill();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 48:
                            forLoops.ovn48 o48 = new forLoops.ovn48();
                            o48.printFakulteten();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 49:
                            forLoops.ovn49 o49 = new forLoops.ovn49();
                            o49.printAlgo();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 55:
                            forLoops.ovn55 o55 = new forLoops.ovn55();
                            o55.printCompare();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;

                        default:
                            goto start;
                    }
                #endregion

                #region Arrays
                case 4:
                    Console.WriteLine("Arrays: ");
                    Console.WriteLine("1. Övning 1");


                    Console.Write("Ange val: ");
                    int caseSubswitch04 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch04)
                    {
                        case 1:
                        Arrays.array_ovn1 arr01 = new Arrays.array_ovn1();
                        arr01.ArrayEx();
                        Console.ReadKey();
                        goto start;
                    }
                    break;

                #endregion
                #region Collections
                case 5:
                    Console.WriteLine("Collections: ");
                    Console.WriteLine("1. Övning 1");


                    Console.Write("Ange val: ");
                    int caseSubswitch05 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch05)
                    {
                        case 1:
                            Collections.coll_ovn1.printBoth();
                            Console.ReadKey();
                            goto start;
                    }
                    break;
                #endregion


                case 0:
                    Console.WriteLine("Avsluta");
                    break;
                    
                    
                    case 6:
                    Console.WriteLine("Ovning 51-60");
                    break;
                default:
                    goto start;

            }
            
            

        }
    }
}
