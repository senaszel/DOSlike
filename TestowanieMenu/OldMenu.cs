using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMenuTutorial;

namespace TestowanieMenu
{
    class OldMenu
    {
        public OldMenu()
        {
            Menu oldMenu = new Menu();
            oldMenu.Add(new MenuItem("Instrukcje",1) { Function = Instructions });
            oldMenu.Add(menuItem: new MenuItem() { Function = Implication, ItemName = "Implikacja" });
            oldMenu.Add(new MenuItem() { Function = Conjunction, ItemName = "Koniunkcja" });
            oldMenu.Add(new MenuItem() { Function = NAND, ItemName = "NAND" });
            oldMenu.Add(new MenuItem() { Function = Disjunction, ItemName = "Alternatywa" });
            oldMenu.Add(new MenuItem() { Function = NOR, ItemName = "NOR" });
            oldMenu.Add(new MenuItem() { Function = Biconditional, ItemName = "Rownowartosc" });
            oldMenu.Add(new MenuItem() { Function = XOR, ItemName = "XOR" });
            oldMenu.Add(new MenuItem() { Function = Tautology, ItemName = "Tautologia" });
            oldMenu.Add(new MenuItem() { Function = Contradiction, ItemName = "Sprzecznosc" });
            oldMenu.Start();
        }

        private static void Implication(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void Conjunction(object obj)
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
            Console.WriteLine(result.ToString());
        }


        private static void NAND(object obj)
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
            Console.WriteLine(result.ToString());
        }

        //here
        private static void Disjunction(object obj)
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
            Console.WriteLine(result.ToString());
        }


        private static void NOR(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void Biconditional(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void XOR(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void Tautology(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void Contradiction(object obj)
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
            Console.WriteLine(result.ToString());
        }

        private static void Instructions(object obj)
        {
            var result = new StringBuilder();
            result
                .AppendLine()
                .AppendLine()
                .Append((char)32, 30)
                .AppendLine("Wybierz jedną z opcji za pomocą strzałek.")
                .AppendLine()
                .Append((char)32, 30)
                .AppendLine("Zatwierdzasz Enterem.")
                .AppendLine();
            Console.WriteLine(result.ToString());
        }
    }
}
