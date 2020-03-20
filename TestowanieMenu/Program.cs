using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMenuTutorial;

namespace TestowanieMenu
{
    class Program
    {
        
        public static void Main()
        {
            const string title = "  M  0  C  K   o s      by  M S M  ";

            Paragraph widok = new Paragraph(title, 127);
            TitleBar.Show();

            Menu menu = new Menu();
            //const string First_P_Title = "Tytul pierwszego paragrafu";
            //menu.Add(menuItem: new MenuItem() { Function = FirstParagraph, ItemName = First_P_Title });
            //const string Second_P_Title = "Tytul drugiego paragrafu";
            //menu.Add(new MenuItem() { Function = SecondParagraph, ItemName = Second_P_Title });
            menu.Add(new MenuItem() { Function = OldMenu, ItemName = "Matematyka dyskretna (podstawy)" });
            menu.Start();

            ESCtoExit();
        }

        private static void OldMenu(object obj)
        {
            OldMenu oldMenu = new OldMenu();   
        }

        private static void FirstParagraph(object obj)
        {
            Paragraph widok = new Paragraph();
            widok.ParagraphTitle(obj.ToString(), 2);
            widok.ShowParagraph("afsadfasdhf  afahsd afgahsdf afdghlriough afjdsjklfjkdsa jklgfsdhklghls sdfkgkfdslg");
        }

        private static void SecondParagraph(object obj)
        {
            Paragraph widok = new Paragraph();
            widok.ParagraphTitle(obj.ToString(), 3);
            widok.ShowParagraph("drugi paragraf drugi paragraf drugi paragraf");
        }


        private static void ESCtoExit()
        {
            bool test = true;
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("ESC to exit");
            while (test)
            {
                ConsoleKey here = Console.ReadKey(true).Key;
                if (here == ConsoleKey.Escape)
                {
                    test = false;
                }
            }
        }
    }
}
