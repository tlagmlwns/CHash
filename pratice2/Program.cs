using System;
using System.ComponentModel;

namespace pratice2
{
    abstract class AbstractBase
    {
        public abstract int MethodA(int x);
        public abstract void MethodB(double x, double y);
        public abstract double MethodB2(double x, double y);
        public abstract void MethodC(int x, int y);
        public abstract string Name { get; set; }
    }
    class Derived : AbstractBase
    {
        public override int MethodA(int x) 
        { if (x < 0) return -x; else return x; }
        public override void MethodB(double x, double y) 
        {
            Console.Write($"- MethodB 호출 : ");
            if (x == 0 || y == 0) Console.WriteLine(" 나눌수 없는 값 - 오류");
            else Console.WriteLine(x / y); }
        public override double MethodB2(double x, double y)
        {
            int v = 0;
            if (x == 0 || y == 0)
                return v;
            else return x / y;

        }
        public override void MethodC(int x, int y) { Console.WriteLine($"{x+y}"); }
        public override string Name 
        {
            get { return Name; }
            set
            {
                if (value.Length > 4) Console.WriteLine("이름 4자 이상 불가능.");
                else Name = value;
            }
        }
        public Derived() { }
        public Derived(string name) { this.Name = name; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived(); //위장
            Console.Write("- 정수 입력 : ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"- MethodA 호출 : { obj.MethodA(i)}");

            Console.WriteLine("- 실수 2개 입력 : ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            //obj.MethodB(x, y);
            
            if (obj.MethodB2(x, y) == 0)
                Console.WriteLine("오류 - 나눌 수 없습니다.");
            else
                Console.WriteLine($"- MethodB 호출 : {obj.MethodB2(x, y)}");

            Console.WriteLine("- 정수 2개 입력 : ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("- MethodC 호출 : ");
            obj.MethodC(x1, y1);

            Console.WriteLine("문자열 입력 : ");
            obj.Name = Console.ReadLine();
            Console.WriteLine($"저의 이름은 {obj.Name}입니다.");
        }
    }
}
