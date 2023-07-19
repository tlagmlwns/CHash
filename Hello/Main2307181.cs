/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //a
    /*
    class A
    {
        private char a = 'A';
        protected char b = 'B';
        public char c = 'C';

        private void printA() { Console.WriteLine("private"); }
        protected void printB() { Console.WriteLine("protected"); }
        public void printC() { Console.WriteLine("public"); }
    }
    class B : A
    {
        public void print()
        {
            Console.WriteLine($"a : private는 호출 안됨, b : {b}, c  : {c}");
            //printA(); //private선언되어있으므로 못받음
            printB();
            printC();
        }
    }*/

    //b.
    /*
    class Parent { protected string name = "부모"; }
    class Child : Parent
    {
        public string name = "자식";
        public Child()
        {
            Console.WriteLine($"base.name={base.name}");  //기반 클래스 지칭
            Console.WriteLine($"this.name={this.name}");  //자신의 클래스 지칭
        }

    }
    /*
    internal class Main2307181
    {
        //c
        /*
        class Parent { public Parent() { Console.WriteLine("부모생성자"); } }
        class Child : Parent 
        { public Child() : base() { Console.WriteLine("자식생성자"); } }*/

    //d 
    /*
    class Parent
    {
        public Parent() { Console.WriteLine("1_Parent()"); }
        public Parent(int param) { Console.WriteLine($"2_Parent(int param) : {param}"); }
        public Parent(string param) { Console.WriteLine($"3_Parent(string param) : {param}"); }
    } 
    class Child : Parent 
    {
        public Child() : base() { Console.WriteLine("1_Child() : base()"); }
        public Child(int a) : base(a) //Parent(int param)부모 생성자 호출
        { Console.WriteLine($"2_Child(int a)->base : {a}"); }
        public Child(string input) : base(input) //Parent(string param)부모 생성자 호출
        { Console.WriteLine($"3_Child(int a)->base : {input}"); }
    }

    //e.9
    /*
    class A
    {
        private int num;
        protected string name = "Hello";
        public A(int num) { this.num = num; }
        public void printA() { Console.WriteLine(num); }
    }
    class B : A
    {
        string name = "World";
        public B(int num) : base(num) { }
        public void printB() { Console.WriteLine($"{base.name} : {name}"); }
    }*/
    /*
        static void Main(string[] args)
        {*/
            //a
            /*
            B test = new B();
            //test.b = 'b'; //protected 자식만 주고 남한데 안줌 보호수둔
            test.c = 'c';
            //test.printB();  //protected
            test.printC();
            test.print();
            */

            //b. base 키워드 사용
            /*
            Child child1 = new Child();

            Console.Write("child2 에 들어갈 정수 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Child child2 = new Child(a);

            Console.Write("child3 에 들어갈 문자 입력 : ");
            string str = Console.ReadLine();
            Child child3 = new Child(str);
            */

            //c
            //Child child = new Child();

            //d 파생 클래스의 객체 생성
            /*
            Child childC = new Child();
            Child childD = new Child("string");
            */

            //e.9
            /*
            B test = new B(3);
            test.printA();
            test.printB();
          /* 
        }

    }
}
            */