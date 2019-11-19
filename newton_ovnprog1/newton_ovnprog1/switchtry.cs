using System;
using System.Collections.Generic;
using System.Text;

namespace newton_ovnprog1
{
    class switchtry
    {
        

        public void swihh()
        {

        #region Meny
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
            #endregion
            {

                #region Sequence programming
                case 1:
                    Console.WriteLine("Sequence Proframming: 01-10");
                    Console.WriteLine("1. Övning 1");
                    Console.WriteLine("2. Övning 2");
                    Console.WriteLine("3. Övning 3");
                    Console.WriteLine("4. Övning 4");
                    Console.WriteLine("5. Övning 5");
                    Console.WriteLine("6. Övning 6");
                    Console.WriteLine("7. Övning 7");
                    Console.WriteLine("8. Övning 8");
                    Console.WriteLine("9. Övning 9");
                    Console.WriteLine("10. Övning 10");
                    Console.Write("Ange val: ");
                    int caseSubswitch01 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch01)
                    {
                        case 1:

                            sequencePrograming.ovn01 o01= new sequencePrograming.ovn01();
                            o01.printOvn01();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 2:
                            sequencePrograming.ovn02 o02 = new sequencePrograming.ovn02();
                            o02.printOvn02();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 3:
                            sequencePrograming.ovn03 o03 = new sequencePrograming.ovn03();
                            o03.printOvn03();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 4:
                            sequencePrograming.ovn04 o04 = new sequencePrograming.ovn04();
                            o04.printOvn04();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 5:
                            sequencePrograming.ovn05 o05 = new sequencePrograming.ovn05();
                            o05.printOvn05();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 6:
                            sequencePrograming.ovn06 o06 = new sequencePrograming.ovn06();
                            o06.printOvn06();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 7:
                            sequencePrograming.ovn07 o07 = new sequencePrograming.ovn07();
                            o07.printOvn07();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 8:
                            sequencePrograming.ovn08 o08 = new sequencePrograming.ovn08();
                            o08.printOvn08();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 9:
                            sequencePrograming.ovn09 o09 = new sequencePrograming.ovn09();
                            o09.printOvn09();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 10:
                            sequencePrograming.ovn10 o10 = new sequencePrograming.ovn10();
                            o10.printOvn10();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;

                    }
                    goto start;
                #endregion

                #region If_Conditions
                case 2:
                    Console.WriteLine("If Conditions: 11-30");
                    Console.WriteLine("11. Övning 11");
                    Console.WriteLine("12. Övning 12");
                    Console.WriteLine("13. Övning 13");
                    Console.WriteLine("14. Övning 14");
                    Console.WriteLine("15. Övning 15");
                    Console.WriteLine("16. Övning 16");
                    Console.WriteLine("17. Övning 17");
                    Console.WriteLine("18. Övning 18");
                    Console.WriteLine("19. Övning 19");
                    Console.WriteLine("20. Övning 20");
                    Console.WriteLine("21. Övning 21");
                    Console.WriteLine("22. Övning 22");
                    Console.WriteLine("23. Övning 23");
                    Console.WriteLine("24. Övning 24");
                    Console.WriteLine("25. Övning 25");
                    Console.WriteLine("26. Övning 26");
                    Console.WriteLine("27. Övning 27");
                    Console.WriteLine("28. Övning 28");
                    Console.WriteLine("29. Övning 29");
                    Console.WriteLine("30. Övning 30");
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
                        case 12:
                            ifConditions.ovn12 o12 = new ifConditions.ovn12();
                            o12.printOvn12();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 13:
                            ifConditions.ovn13 o13 = new ifConditions.ovn13();
                            o13.printOvn13();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 14:
                            ifConditions.ovn14 o14 = new ifConditions.ovn14();
                            o14.printOvn14();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 15:
                            ifConditions.ovn15 o15 = new ifConditions.ovn15();
                            o15.printOvn15();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 16:
                            ifConditions.ovn16 o16 = new ifConditions.ovn16();
                            o16.printOvn16();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 17:
                            ifConditions.ovn17 o17 = new ifConditions.ovn17();
                            o17.printOvn17();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 18:
                            ifConditions.ovn18 o18 = new ifConditions.ovn18();
                            o18.printOvn18();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 19:
                            ifConditions.ovn19 o19 = new ifConditions.ovn19();
                            o19.printOvn19();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 20:
                            ifConditions.ovn20 o20 = new ifConditions.ovn20();
                            o20.printkvad();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 21:
                            ifConditions.ovn21 o21 = new ifConditions.ovn21();
                            o21.printOvn21();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 22:
                            ifConditions.ovn22 o22 = new ifConditions.ovn22();
                            o22.printtwonumbers();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 23:
                            ifConditions.ovn23 o23 = new ifConditions.ovn23();
                            o23.printOvn23();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 24:
                            ifConditions.ovn24 o24 = new ifConditions.ovn24();
                            o24.printOvn24();
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
                        case 29:
                            ifConditions.ovn29 o29 = new ifConditions.ovn29();
                            o29.printOvn29();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 30:
                            ifConditions.ovn30 o30 = new ifConditions.ovn30();
                            o30.printOvn30();
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
                    Console.WriteLine("31. Övning 31");
                    Console.WriteLine("32. Övning 32");
                    Console.WriteLine("33. Övning 33");
                    Console.WriteLine("34. Övning 34");
                    Console.WriteLine("35. Övning 35");
                    Console.WriteLine("37. Övning 37");
                    Console.WriteLine("39. Övning 39");
                    Console.WriteLine("40. Övning 40");
                    Console.WriteLine("41. Övning 41");
                    Console.WriteLine("42. Övning 42");
                    Console.WriteLine("43. Övning 43");
                    Console.WriteLine("44. Övning 44");
                    Console.WriteLine("46. Övning 46");
                    Console.WriteLine("47. Övning 47");
                    Console.WriteLine("48. Övning 48");
                    Console.WriteLine("49. Övning 49");
                    Console.WriteLine("51. Övning 51");
                    Console.WriteLine("52. Övning 52");
                    Console.WriteLine("53. Övning 53");
                    Console.WriteLine("54. Övning 54");
                    Console.WriteLine("55. Övning 55");
                    Console.WriteLine("56. Övning 56");
                    Console.Write("Ange val: ");
                    int caseSubswitch03 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch03)
                    {
                        case 31:
                            forLoops.ovn31 o31 = new forLoops.ovn31();
                            o31.printOvn31();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
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
                        case 34:
                            forLoops.ovn34 o34 = new forLoops.ovn34();
                            o34.printOvn34();
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
                        case 40:
                            forLoops.ovn40 o40 = new forLoops.ovn40();
                            o40.printOvn40();
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
                        case 47:
                            forLoops.ovn47 o47 = new forLoops.ovn47();
                            o47.printOvn47();
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
                        case 51:
                            forLoops.ovn51 o51 = new forLoops.ovn51();
                            o51.printOvn51();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 52:
                            forLoops.ovn52 o52 = new forLoops.ovn52();
                            o52.printOvn52();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 53:
                            forLoops.ovn53 o53 = new forLoops.ovn53();
                            o53.printOvn53();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 54:
                            forLoops.ovn54 o54 = new forLoops.ovn54();
                            o54.printOvn54();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 55:
                            forLoops.ovn55 o55 = new forLoops.ovn55();
                            o55.printCompare();
                            Console.WriteLine("\n \n");
                            Console.ReadKey();
                            goto start;
                        case 56:
                            forLoops.ovn56 o56 = new forLoops.ovn56();
                            o56.printOvn56();
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
                    Console.WriteLine("66. Övning 66");
                    Console.WriteLine("67. Övning 67");
                    Console.WriteLine("68. Övning 68");
                    Console.WriteLine("69. Övning 69");
                    Console.WriteLine("70. Övning 70");
                    Console.WriteLine("72. Övning 72");
                    Console.WriteLine("73. Övning 73");
                    Console.WriteLine("74. Övning 74");
                    Console.WriteLine("75. Övning 75");

                    Console.Write("Ange val: ");
                    int caseSubswitch04 = Convert.ToInt32(Console.ReadLine());
                    switch (caseSubswitch04)
                    {
                        case 1:
                        Arrays.array_ovn1 arr01 = new Arrays.array_ovn1();
                        arr01.ArrayEx();
                        Console.ReadKey();
                        goto start;
                            case 66:
                            Arrays.ovn66 arr66 = new Arrays.ovn66();
                            arr66.printOvn66();
                            Console.ReadKey();
                            goto start;
                        case 67:
                            Arrays.ovn67 arr67 = new Arrays.ovn67();
                            arr67.printOvn67();
                            Console.ReadKey();
                            goto start;
                        case 68:
                            Arrays.ovn68 arr68 = new Arrays.ovn68();
                            arr68.printOvn68();
                            Console.ReadKey();
                            goto start;
                        case 69:
                            Arrays.ovn69 arr69 = new Arrays.ovn69();
                            arr69.printOvn69();
                            Console.ReadKey();
                            goto start;
                        case 70:
                            Arrays.ovn70 arr70 = new Arrays.ovn70();
                            arr70.printOvn70();
                            Console.ReadKey();
                            goto start;
                        case 72:
                            Arrays.ovn72 arr72 = new Arrays.ovn72();
                            arr72.printOvn72();
                            Console.ReadKey();
                            goto start;
                        case 73:
                            Arrays.ovn73 arr73 = new Arrays.ovn73();
                            arr73.printOvn73();
                            Console.ReadKey();
                            goto start;
                        case 74:
                            Arrays.ovn74 arr74 = new Arrays.ovn74();
                            arr74.printOvn74();
                            Console.ReadKey();
                            goto start;
                        case 75:
                            Arrays.ovn75 arr75 = new Arrays.ovn75();
                            arr75.printOvn75();
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
