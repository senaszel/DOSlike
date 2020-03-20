using System;

namespace SimpleMenuTutorial
{
    public class MenuItem
    {
        private int leaveSpace;

        public MenuItem()
        {

        }
        public MenuItem(string itemName,int leaveSpace = 0)
        {
            ItemName = itemName;
            LeaveSpace = leaveSpace;
        }

        public string ItemName { get; set; }
        public Action<object> Function { get; set; }
        public bool IsSelected { get; set; }
        public int LeaveSpace { get => leaveSpace; set => leaveSpace = value; }

        public void Invoke(object parameterObject = null)
        {
            Function.Invoke(parameterObject);
        }

    }
}
