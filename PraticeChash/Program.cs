using System;
using System.ComponentModel.Design;

namespace PraticeChash
{
    class Animal
    {
        protected string Name;
        protected int Height;
        protected int Weight;
        protected int Age;
        protected int Speed;
        public Animal() { }
        public Animal(string name, int height, int weight, int age, int speed)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Age = age;
            Speed = speed;
        }
        public void Speak()
        {
            Console.WriteLine("---------------동물 정보---------------");
            Console.WriteLine($"> 이름 : {Name}");
            Console.WriteLine($"> 키 : {Height}cm");
            Console.WriteLine($"> 몸무게 : {Weight}kg");
            Console.WriteLine($"> 나이 : {Age}살");
        }
        public void Run() { Console.WriteLine($"{Name}은/는 {Speed}km/h속도로 달립니다."); }
    }
    class Pig : Animal
    {
        public Pig() { }
        public Pig(string name, int height, int weight, int age, int speed) :
            base (name, height, weight, age, speed) { }
    }
    class Chicken : Animal
    {
        
        private int Fly_speed;
        public Chicken() { }
        public Chicken(string name, int height, int weight, int age, int speed, int fly_speed) 
        { 
            base.Name = name;
            base.Height = height;
            base.Weight = weight;
            base.Age = age;
            base.Speed = speed;
            Fly_speed = fly_speed;
        }
        public void Fly() { Console.WriteLine($"{base.Name}은/는 {Fly_speed}km/h속도로 날아다닙니다."); }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("- 돼지 : pig / 닭 : chicken / 종료 : 아무단어 -");
                Console.Write("- 동물을 입력하시오 : ");
                string animal = Console.ReadLine();
                if (animal == "pig")
                {
                    Console.WriteLine();
                    Console.Write("- 동물 이름을 입력하시오 : ");
                    string n = Console.ReadLine();
                    Console.Write("- 동물 키를 입력하시오 : ");
                    int h = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 몸무게를 입력하시오 : ");
                    int w = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 나이를 입력하시오 : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 속도를 입력하시오 : ");
                    int s = int.Parse(Console.ReadLine());
                    Pig pig = new Pig(n, h, w, a, s);
                    //Pig pig = new Pig("아기돼지", 30, 60, 5, 20);
                    pig.Speak();
                    pig.Run();
                    Console.WriteLine();
                    continue;
                }
                else if (animal == "chicken")
                {
                    Console.WriteLine();
                    Console.Write("- 동물 이름을 입력하시오 : ");
                    string n = Console.ReadLine();
                    Console.Write("- 동물 키를 입력하시오 : ");
                    int h = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 몸무게를 입력하시오 : ");
                    int w = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 나이를 입력하시오 : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 속도를 입력하시오 : ");
                    int s = int.Parse(Console.ReadLine());
                    Console.Write("- 동물 날고 있는 속도를 입력하시오 : ");
                    int fs = int.Parse(Console.ReadLine());
                    //Chicken chicken = new Chicken("ㄱㄱㄷ", 20, 25, 3, 40, 50);
                    Chicken chicken = new Chicken(n, h, w, a, s, fs);
                    chicken.Speak();
                    chicken.Run();
                    chicken.Fly();
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("- 종료합니다.");
                    break;
                }
            }
        }
    }
}
