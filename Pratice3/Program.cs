using System;
using System.ComponentModel.Design;

namespace Pratice3
{
    /*
    class Cat
    {
        public string Name;
        public string Color;
        public Cat()
        {
            Name = "";
            Color = "";
        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name}:야옹");
        }
    }*/
    class Box
    {
        private int w;
        public int W
        {
            get { return w; }
            set
            {
                if (value > 0) { w = value; }
                else Console.WriteLine("너비 자연수 입력 : ");
            }
        }
        private int h;
        public int H
        {
            get { return h; }
            set
            {
                if (value > 0) { h = value; }
                else Console.WriteLine("높이 자연수 입력 : ");
            }
        }
        public Box(int w, int h)
        {
            W = w;
            H = h;
        }
        public int Area()
        {
            return this.w * this.h;
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Cat cat = new Cat();
            cat.Name = "Test";
            cat.Color = "qwer";
            Console.WriteLine($"{cat.Name} : {cat.Color}");
            Cat cat1 = new Cat("cat1","b");
            Console.WriteLine($"{cat1.Name} : {cat1.Color}");
            */
            Box box = new Box(-10, -20);
            box.W = 200;
            box.H = 100;
            Console.WriteLine("사각형의 넓이 : {0}",box.Area());
        }
    }
}
