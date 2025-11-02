using System;

namespace ReplaceParameterWithExplicitMethods_Before
{
    class Rectangle
    {
        private int height;
        private int width;

        public void SetValue(string name, int value)
        {
            if (name.Equals("height"))
            {
                height = value;
                return;
            }

            if (name.Equals("width"))
            {
                width = value;
                return;
            }

            Console.WriteLine("Invalid parameter name!");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Height = {height}, Width = {width}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.SetValue("height", 10);
            rect.SetValue("width", 20);

            rect.ShowInfo();
        }
    }
}
