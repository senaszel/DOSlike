using System;
using System.Text;

namespace TestowanieMenu
{
    class MainClass
    {
        

            const string pointer = ">>>";

            const string leftSide = "leftSide";
            const string rightSide = "rightSide";

            string currentSide = leftSide;
            bool equityBool = false;

            int maxRightPositionValue = 4;
            int maxLeftPositionValue = 6;
            int lastPositionOnLeftSide = 6;
            int lastPositionOnRightSide = 1;
            int whereValidation;
            string value = "\n\n\n\t\t\t\t\tWciśnij spacje aby przeczytać instrukcję!\n\n\n";

            string Get_currentSide()
            {
                return currentSide;
            }

            int Get_maxLeftPositionValue()
            {
                return maxLeftPositionValue;
            }

            int Get_maxRightPositionValue()
            {
                return maxRightPositionValue;
            }

            void Set_value(string avalue)
            {
                value = avalue;
            }

            void Set_lastPositionOnLeftSide(int lastPosition)
            {
                lastPositionOnLeftSide = lastPosition;
            }

            void Set_lastPositionOnRightSide(int lastPosition)
            {
                lastPositionOnRightSide = lastPosition;
            }

            void ChangeSide(int positionThatIsBeingLeft)
            {
                equityBool = false ? equityBool = true : false;

                if (Get_currentSide() == leftSide)
                {
                    Set_lastPositionOnLeftSide(positionThatIsBeingLeft);
                    currentSide = rightSide;
                    if (positionThatIsBeingLeft > maxRightPositionValue)
                    {
                        Set_lastPositionOnLeftSide(maxRightPositionValue);
                    }
                }
                else
                {
                    Set_lastPositionOnRightSide(positionThatIsBeingLeft);
                    currentSide = leftSide;
                }
            }

            int Get_where(string whichWhere)
            {
                int temp;
                switch (whichWhere)
                {
                    case leftSide:
                        temp = lastPositionOnLeftSide;
                        break;
                    case rightSide:
                        temp = lastPositionOnRightSide;
                        break;
                    default:
                        Echo("Get_where Nie ma prawa tutaj wejść");
                        Console.ReadKey();
                        temp = 666;
                        break;
                }
                return temp;
            }


            void Set_where(string _whichSide, int positionValue)
            {
                switch (_whichSide)
                {
                    case leftSide:
                        if (positionValue > Get_maxLeftPositionValue())
                        {
                            whereValidation = 1;
                        }
                        else if (positionValue < 1)
                        {
                            whereValidation = Get_maxLeftPositionValue();
                        }
                        else
                        {
                            whereValidation = positionValue;
                        }
                        lastPositionOnLeftSide = whereValidation;
                        break;
                    case rightSide:
                        if (positionValue > Get_maxRightPositionValue())
                        {
                            whereValidation = 1;
                        }
                        else if (positionValue < 1)
                        {
                            whereValidation = Get_maxRightPositionValue();
                        }
                        else
                        {
                            whereValidation = positionValue;
                        }
                        lastPositionOnRightSide = whereValidation;
                        break;
                    default:
                        Echo("Set_where switch --- nie miało prawa tutaj wejść");
                        Console.ReadKey();
                        break;
                }
            }

            //space
            void SpacebarSwitch(int currentoption, int whichHalfOfCollumn)
            {
                if (currentSide == leftSide && equityBool == true)
                {
                    currentoption -= (maxLeftPositionValue - currentoption);
                }

                switch (currentoption)
                {
                    case 1:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Tautology());
                            break;
                        }
                        Set_value(Contradiction());
                        break;
                    case 2:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Biconditional());
                            break;
                        }
                        Set_value(XOR());
                        break;
                    case 3:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Disjunction());
                            break;
                        }
                        Set_value(NOR());
                        break;
                    case 4:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Conjunction());
                            break;
                        }
                        Set_value(NAND());
                        break;
                    case 5:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Implication());
                            break;
                        }
                        //nothing here
                        break;
                    case 6:
                        if (whichHalfOfCollumn == 1)
                        {
                            Set_value(Instructions());
                        }
                        //nothing here
                        break;
                    default:
                        {
                            Echo("Ciekawe jak tutaj miałoby dotrzeć :D");
                            WaitForKey();
                            break;
                        }
                }
            }
            //here


            //void WindowInfo(bool disableReadKey = false)
            //{
            //    Console.WriteLine("buffer height {0}", Console.BufferHeight);
            //    Console.WriteLine("buffer width {0}", Console.BufferWidth);
            //    Console.WriteLine("window width {0}", Console.WindowWidth);
            //    Console.WriteLine("window height {0}", Console.WindowHeight);
            //    if (disableReadKey)
            //    {
            //        Console.ReadKey();
            //    }
            //}


            // Wywołanie
            //Console.Title = "My Menu()";
            ////Console.SetBufferSize(127, 28);
            //Console.SetWindowSize(127, 28);
            //Menu(Get_where(leftSide));

            void WriteTitleThroughWholeScreen()
            {
                string title = "  M  0  C  K     o s   by  M S M  ";
                var wholeLine = new StringBuilder();
                var left = new StringBuilder();
                for (int i = 1; i <= 47; i++)
                {
                    left.Append("#");
                }
                var middle = new StringBuilder();
                middle.Append((char)32, 33);
                var right = new StringBuilder();
                for (int i = 1; i <= 47; i++)
                {
                    right.Append("#");
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("{0}{1}{2}", left, middle, right);
                Console.Write(wholeLine.Append((char)35, 46).Append(title));
                for (int i = 1; i <= (127 - wholeLine.Length); i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("{0}{1}{2}", left, middle, right);
                Console.ResetColor();
            }


            void WriteLineFullOfHashes(int howManyLines = 1)
            {
                for (int i = 1; i <= howManyLines; i++)
                {
                    int j;
                    for (j = 1; j <= 127; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("#");
                        Console.ResetColor();
                    }
                }
            }

            void LeftWall(int howManyHashes = 2, bool disableNewLine = false)
            {
                for (int i = 1; i <= howManyHashes; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("#");
                    Console.ResetColor();
                }
                if (disableNewLine)
                {
                    Console.Write(Environment.NewLine);
                }
            }

            void Echo(string text, string pointerSpot = null)
            {
                LeftWall();
                if (pointerSpot == pointer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(pointer);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(pointerSpot);
                }
                Console.Write(text);
                LeftWall();

            }

            void WaitForKey(ConsoleKey key = ConsoleKey.Spacebar, string nameOfaKey = "Spacje")
            {
                Console.WriteLine("Naciśnij {0} by kontynuować!", nameOfaKey);
                while (Console.ReadKey(true).Key != key)
                { }
            }

            /* Metodka za pomocą której wybierasz opcje z wyświetlonego menu
             * DownArrow menu pozycja w dół
             * UpArrow   menu pozycja w górę
             * Spacja    podjęcie wyboru (wywołanie funkcji opisanej w menu)
             * Tab       przejście do drugiego menu
             */
            void ChooseOption(int currentOption)
            {
                int whichHalfOfCollumn;
                string collumn;
                ConsoleKey pressedKey;

                do
                {
                    pressedKey = Console.ReadKey(true).Key;
                    {
                        if (Get_currentSide() == rightSide)
                        {
                            whichHalfOfCollumn = 2;
                            collumn = rightSide;
                        }
                        else
                        {
                            whichHalfOfCollumn = 1;
                            collumn = leftSide;
                        }
                        switch (pressedKey)
                        {
                            case ConsoleKey.DownArrow:
                                Set_where(collumn, --currentOption);
                                break;
                            case ConsoleKey.UpArrow:
                                Set_where(collumn, ++currentOption);
                                break;
                            case ConsoleKey.Tab:
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.RightArrow:
                                ChangeSide(currentOption);
                                break;
                            case ConsoleKey.Spacebar:
                                SpacebarSwitch(currentOption, whichHalfOfCollumn);
                                break;

                            default:
                                Echo("...strzałki, spacja, tab..." + Environment.NewLine + "Takie są możliwości.");
                                WaitForKey(ConsoleKey.Escape, "Escape");
                                Set_value("Don't you read on screen instructions? Do NOT do that.");
                                Menu(currentOption);
                                break;
                        }
                        Menu(Get_where(collumn));
                    }
                } while (
                pressedKey != ConsoleKey.DownArrow &&
                pressedKey != ConsoleKey.UpArrow &&
                pressedKey != ConsoleKey.LeftArrow &&
                pressedKey != ConsoleKey.RightArrow &&
                pressedKey != ConsoleKey.Spacebar &&
                pressedKey != ConsoleKey.Tab
                );
            }


            void Menu(int currentOption)
            {
                if (currentSide == leftSide && equityBool == true)
                {
                    currentOption -= (maxLeftPositionValue - currentOption);
                }
                // Ilość fullstop opcje 52 znaki opcjeB 53 znaki
                var option1 = new StringBuilder();
                var option1b = new StringBuilder();
                var option2 = new StringBuilder();
                var option2b = new StringBuilder();
                var option3 = new StringBuilder();
                var option3b = new StringBuilder();
                var option4 = new StringBuilder();
                var option4b = new StringBuilder();
                var option5 = new StringBuilder();
                var option5b = new StringBuilder();
                var option6 = new StringBuilder();

                option1.Append((char)46, 54);
                option1b.Append((char)46, 55);
                option2.Append((char)46, 54);
                option2b.Append((char)46, 55);
                option3.Append((char)46, 54);
                option3b.Append((char)46, 55);
                option4.Append((char)46, 54);
                option4b.Append((char)46, 55);
                option5.Append((char)46, 54);
                option5b.Append((char)46, 55);
                option6.Append((char)46, 54);

                //here
                option6.Remove(0, 10).Insert(20, "Instrukcje");
                option5.Remove(0, 10).Insert(20, "Implikacja");
                option4.Remove(0, 10).Insert(20, "Koniunkcja");
                option4b.Remove(0, 4).Insert(20, "NAND");
                option3.Remove(0, 11).Insert(20, "Alternatywa");
                option3b.Remove(0, 3).Insert(20, "NOR");
                option2.Remove(0, 12).Insert(20, "Równowartość");
                option2b.Remove(0, 3).Insert(20, "XOR");
                string option1str = "Tautologia";
                option1.Remove(0, option1str.Length).Insert(20, option1str);
                string option1bstr = "Sprzeczność";
                option1b.Remove(0, option1bstr.Length).Insert(20, option1bstr);

                string whitespaceX3 = "   ";


                Console.Clear();
                WriteLineFullOfHashes(2);
                WriteTitleThroughWholeScreen();
                WriteLineFullOfHashes();
                Console.WriteLine();

                string placeholder;
                string placeholder2;


                if (Get_currentSide() == "leftSide")
                {
                    placeholder = pointer;
                    placeholder2 = whitespaceX3;
                }
                else
                {
                    placeholder2 = pointer;
                    placeholder = whitespaceX3;
                }

                if (currentOption == 6)
                {
                    LeftWall();
                    Echo(option6.ToString(), placeholder);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option6);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }

                if (currentOption == 5)
                {
                    LeftWall();
                    Echo(option5.ToString(), placeholder);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option5);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }

                if (currentOption == 4)
                {
                    LeftWall();
                    Echo(option4.ToString(), placeholder);
                    Echo(option4b.ToString(), placeholder2);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option4);
                    Echo(whitespaceX3 + option4b);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }

                if (currentOption == 3)
                {
                    LeftWall();
                    Echo(option3.ToString(), placeholder);
                    Echo(option3b.ToString(), placeholder2);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option3);
                    Echo(whitespaceX3 + option3b);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }

                if (currentOption == 2)
                {
                    LeftWall();
                    Echo(option2.ToString(), placeholder);
                    Echo(option2b.ToString(), placeholder2);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option2);
                    Echo(whitespaceX3 + option2b);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }

                if (currentOption == 1)
                {
                    LeftWall();
                    Echo(option1.ToString(), placeholder);
                    Echo(option1b.ToString(), placeholder2);
                    LeftWall();
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    LeftWall();
                    Echo(whitespaceX3 + option1);
                    Echo(whitespaceX3 + option1b);
                    LeftWall();
                    Console.Write(Environment.NewLine);

                }
                WriteLineFullOfHashes(2);
                LeftWall(4);

                //LeftWall(2, disableNewLine: true);
                //LeftWall(2, disableNewLine: true);
                DispatchResult(value);
                //LeftWall(4, disableNewLine: true);

                WriteLineFullOfHashes(howManyLines: 3);

                ChooseOption(currentOption);

                Console.WriteLine("Wyjście z menu. (Potwierdzić enterem)");
                WaitForKey(ConsoleKey.Enter, "Enter");
            }

            void DispatchResult(string result)
            {
                Console.WriteLine("Przedstawiona zostaje:");
                var fullstop24 = new StringBuilder();
                fullstop24.Append((char)32, 26);
                Console.WriteLine($"{fullstop24.ToString()}{result}");
                Console.WriteLine("\n\n");
            }

            string Implication()
            {
                string[,] arr =
                {
                    { "1", "1" },
                    { "0", "1" }
                };
                var result = new StringBuilder();
                result.Append("Implikacja -> : \n -> \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} -> {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }

            string Conjunction()
            {
                string[,] arr =
                     {
                    { "0", "0" },
                    { "0", "1" }
                };
                var result = new StringBuilder();
                result.Append("Koniunkcja ^ : \n ^ \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} ^ {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }


            string NAND()
            {
                string[,] arr =
                {
                    { "1", "1" },
                    { "1", "0" }
                };
                var result = new StringBuilder();
                result.Append("NAND NAND : \n NAND \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} NAND {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }

            //here
            string Disjunction()
            {
                string[,] arr =
                     {
                    { "0", "1" },
                    { "1", "1" }
                };
                var result = new StringBuilder();
                result.Append("Alternatywa v : \n v \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} v {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }


            string NOR()
            {
                string[,] arr =
                     {
                    { "1", "0" },
                    { "0", "0" }
                };
                var result = new StringBuilder();
                result.Append("NOR NOR : \n NOR \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} NOR {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }

            string Biconditional()
            {
                string[,] arr =
                     {
                    { "1", "0" },
                    { "0", "1" }
                };
                var result = new StringBuilder();
                result.Append("Równowartość <-> : \n <-> \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} <-> {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }

            string XOR()
            {
                string[,] arr =
                     {
                    { "0", "1" },
                    { "1", "0" }
                };
                var result = new StringBuilder();
                result.Append("XOR XOR : \n XOR \n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result.Append((char)32, 30);
                        result.Append($"{i} XOR {j} = {arr[i, j]}\n");
                    }
                }
                return result.ToString();
            }

            string Tautology()
            {
                var result = new StringBuilder();
                result
                    .AppendLine("TAUTOLOGIĄ")
                    .AppendLine()
                    .Append((char)32, 30)
                    .AppendLine("   nazywamy zdanie, które jest zawsze prawdziwe.")
                    .AppendLine()
                    .Append((char)32, 30)
                    .AppendLine("Niezależnie od wartości logicznych zdań składowych.")
                    .AppendLine();
                return result.ToString();
            }

            string Contradiction()
            {
                var result = new StringBuilder();
                result
                    .AppendLine("SPRZECZNOŚCIĄ")
                    .AppendLine()
                    .Append((char)32, 30)
                    .Append("   nazywamy zdanie, które jest zawsze fałszywe.")
                    .AppendLine()
                    .Append((char)32, 30)
                    .Append("Niezależnie od wartości logicznych zdań składowych.")
                    .AppendLine()
                    .AppendLine()
                    .Append((char)32, 30)
                    .Append("Wobec tego zdaniem zawsze sprzecznym jest zaprzeczenie Tautologii ~T")
                    .AppendLine();
                return result.ToString();
            }

            string Instructions()
            {
                var result = new StringBuilder();
                result
                    .AppendLine()
                    .AppendLine()
                    .Append((char)32, 30)
                    .AppendLine("Wybierz jedną z opcji za pomocą strzałek.")
                    .Append((char)32, 30)
                    .AppendLine("Pomiędzy stronami przechodzisz tabem.")
                    .Append((char)32, 30)
                    .AppendLine("Zatwierdzasz spacją.")
                    .AppendLine();
                return result.ToString();
            }

       
    }//end of class
}//end of namespace
