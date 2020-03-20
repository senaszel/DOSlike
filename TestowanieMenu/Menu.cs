using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenuTutorial
{
    public class Menu
    {
        private List<MenuItem> Items;

        private MenuItem SelectedItem
        {
            get
            {
                return Items.FirstOrDefault(x => x.IsSelected == true);
            }
        }

        private int SelectedIndex
        {
            get { return Items.IndexOf(SelectedItem); }
        }

        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void MoveNext()
        {
            if (SelectedItem != Items.Last())
            {
                var newIndex = SelectedIndex + 1;
                SelectedItem.IsSelected = false;
                Items[newIndex].IsSelected = true;
            }
        }
        public void MoveBack()
        {
            if (SelectedItem != Items.First())
            {
                var newIndex = SelectedIndex - 1;
                SelectedItem.IsSelected = false;
                Items[newIndex].IsSelected = true;
            }
        }

        public void Invoke(object parameter = null)
        {
            SelectedItem.Invoke(parameter);
        }

        public void Add(MenuItem menuItem)
        {
            Items.Add(menuItem);
            if (Items.Count == 1)
            {
                menuItem.IsSelected = true;
            }
        }

        public virtual void Print()
        {
            Console.Clear();
            TestowanieMenu.TitleBar.Show();
            Console.WriteLine("\n\n");
            foreach (var item in Items)
            {

                if (item.IsSelected)
                {
                    Console.Write("{0}", "".PadLeft(100 - item.ItemName.Length));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}", item.ItemName);
                    Console.ResetColor();
                }
                else Console.WriteLine("{0,100}", item.ItemName);

                if(item.LeaveSpace > 0)
                {
                    Console.WriteLine("");
                }

            }
            //Console.WriteLine();
        }

        public virtual void Start()
        {
            object parameter = "hehe"; //it can be set as parameter for menu if needed
            while (true)
            {
                Print();
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        MoveNext();
                        break;
                    case ConsoleKey.UpArrow:
                        MoveBack();
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine("\n\n");
                        Invoke(parameter);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        continue;
                }
            }
        }
    } //end of class
} //end of namespace
