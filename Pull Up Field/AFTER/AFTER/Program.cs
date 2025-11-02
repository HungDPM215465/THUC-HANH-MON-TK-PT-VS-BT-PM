using System;

namespace ReplaceParameterWithExplicitMethods_After
{
    class Rectangle
    {
        private int height;
        private int width;

        public void SetHeight(int value)
        {
            height = value;
        }

        public void SetWidth(int value)
        {
            width = value;
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

            rect.SetHeight(10);
            rect.SetWidth(20);

            rect.ShowInfo();
        }
    }
}

