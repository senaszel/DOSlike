using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieMenu
{
    public class Paragraph
    {
        public Paragraph()
        {

        }
        public Paragraph(string consoleTitle, int bufferWidth)
        {
            TitleBar.Title = consoleTitle;

            Console.Title = TitleBar.Title;
            Console.BufferWidth = bufferWidth;
        }

        internal void ParagraphTitle(string paragraphTitle, int tabReps = 1)
        {
            for (int i = 0; i <= tabReps; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("{0}", paragraphTitle);
        }

        internal void ShowParagraph(string paragraphContent, int intendReps = 1)
        {
            for (int i = 0; i < intendReps; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("\t{0}", paragraphContent);
        }

    } // end of class
} // end of namespace
