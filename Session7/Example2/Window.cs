using System;

namespace Example2
{
    class Window
    {
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",
             top, left);
        }
        
        protected int top;
        protected int left;
    }
    class ListBox: Window
    {
        public ListBox(int top, int left, string contents): base(top, left) // 
        {
            listBoxContents = contents;
        }
        
        public override void DrawWindow()
        {
            base.DrawWindow(); 
            Console.WriteLine("Writing string to the listbox:{0}",
             listBoxContents);
        }
        private string listBoxContents;
    }
    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
}
