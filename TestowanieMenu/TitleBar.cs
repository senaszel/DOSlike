using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieMenu
{
    static class TitleBar
    {
 
        private static string title;

        public static string Title 
        { 
            get => title; 
            set => title = value; 
        }

        public static void Show(string title = "no title")
        {
            title = Title;
            
            StringBuilder firstLine = new StringBuilder();
            StringBuilder titleLine = new StringBuilder();
            StringBuilder lastLine = new StringBuilder();

            firstLine.Append((char)32, 127);
            int math = 127 - title.Length;
            int math2 = math / 2;
            titleLine.Append((char)32, math2).Append(title).Append((char)32, math2);
            lastLine.Append((char)32, 127);

            Console.WriteLine(firstLine);
            Console.WriteLine(titleLine);
            Console.WriteLine(lastLine);
        }

    }
}
