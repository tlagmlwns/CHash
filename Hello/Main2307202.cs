/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hello
{*/
    //a
    /*
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value) { this.Value = value; }
    }*/
    //b
    /*
    class A
    {
        //private int[] arr = new int[10];
        
        public int this[int i]
        {
            get { return i * i; }
            set { Console.Write(i + "의 제곱 : "); }
        }
    }*/
    //g.
    /*
    class Fruit : IComparable
    {
        string name;
        int price;
        public Fruit(string name, int price)
        {
            this.name = name;
            this.price = price;
        }   
        public int CompareTo(object obj)
        {
            Fruit fruit = obj as Fruit;
            return this.price.CompareTo(fruit.price);
        }
        public override string ToString()
        {
            return string.Format($"과일명 : {this.name}, 가격 : {this.price}");
        }
    }*/
    //multydelgate4
    /*
    delegate void ThereisAFire(string location);
    class Firestation
    {
        public void Call119(string location){Console.WriteLine($"불, 와, 주소 {location}");}
        public void ShotOut(string location) { Console.WriteLine($"피해 {location}에 불!"); }
        public void Escape(string location) { Console.WriteLine($"{location} 나가!"); }
    }*/
    /*
    internal class Main2307202
    {*/
        //c
        /*
        static void ShowArrayList(ArrayList list)
        {
            foreach (object obj in list) { Console.Write("{0}", obj); }
            Console.WriteLine();
        }
        */
        //delgate normal
        /*
        delegate int TypeF(int a, int b);
        static int Plus(int a, int b) { return a + b; }
        static int Minus(int a, int b) { return a - b; }
        */
        //multydelgate
        /*
        delegate void TypeF(int a, int b);
        static void Plus(int  a, int b) { Console.WriteLine($"두수의 합 : { a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"두수의 차 : {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"두수의 곱 : {a * b}"); }
        */
        /*
        static void Main(string[] args)
        {*/
            //a
            /*
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(12345);
                Wanted<double> wantedDouble = new Wanted<double>(12.345);
                Console.WriteLine(wantedString);
                Console.WriteLine(wantedInt);
                Console.WriteLine(wantedDouble);
            */
            //b
            /*
            A myTest = new A();
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("클래스 호출 반환값 : {0}", myTest[i]); //get
                myTest[i] = i;
                Console.WriteLine(myTest[i]); //set
            }
            */
            //c
            /*
            ArrayList list = new ArrayList();
            for(int i =0; i<5; i++) { list.Add(i); }
            Console.WriteLine("List : ");
            ShowArrayList(list);

            list.RemoveAt(2);
            ShowArrayList(list);

            list.Insert(2, 7);
            ShowArrayList(list);

            list.Add("abc");
            list.Add('A');
            ShowArrayList(list);
            */
            //d. 큐와 스택
            /*
            Console.WriteLine("Queue");
            Queue q = new Queue(); //큐
            for(int i = 1; i < 6; i++) { q.Enqueue(i); }//넣기
            while (q.Count > 0) 
            { Console.Write("{0} ", q.Dequeue()); } //빼기

            Console.WriteLine("\nStack");
            Stack stack = new Stack(); //스택
            for (int l = 1; l < 6; l++) { stack.Push(l); }//넣기
            while (stack.Count > 0) 
            { Console.Write("{0} ", stack.Pop()); } //빼기
            */
            //e. hashable
            /*
            Hashtable table = new Hashtable();
            table.Add("사과", "apple");
            table.Add("토마토", "toamto");
            table["감자"] = "potato"; //인덱서로 값 받기
            table["복숭아"] = "peach";
            Console.WriteLine($"table의 해시코드 : {table.GetHashCode()}");
            foreach (object obj in table.Keys)
            {Console.WriteLine($"{obj}: {table[obj]}");}
            Console.WriteLine("------------------------------");

            Hashtable table1 = new Hashtable();
            table1.Add("사과", "apple");
            table1.Add("토마토", "toamto");
            table1["감자"] = "potato"; //인덱서로 값 받기
            table1["복숭아"] = "peach";
            Console.WriteLine($"table1의 해시코드 : {table1.GetHashCode()}");
            foreach (object obj in table1.Keys)
            { Console.WriteLine($"{obj}: {table1[obj]}"); }
            */
            //f.오름차순, 내림차순 / Sort, Reverse
            /*
            string[] arr1 = { "q", "w", "e", "r", "t", "y" };
            Console.WriteLine("정렬해서 출력");
            Array.Sort(arr1);
            foreach (string s in arr1) Console.WriteLine(s + ", ");
            Console.WriteLine();

            Array.Reverse(arr1);
            Console.WriteLine("역방향 출력");
            foreach (string s in arr1) Console.WriteLine(s + ", ");
            */
            //g.
            /*
            ArrayList list = new ArrayList();
            list.Add(new Fruit("A", 300));
            list.Add(new Fruit("B", 800));
            list.Add(new Fruit("C", 200));
            list.Add(new Fruit("D", 400));
            list.Add(new Fruit("E", 600));
            list.Sort();
            foreach (Fruit f in list)
                Console.WriteLine(f);
            */
            //delgate normal
            /*
            TypeF delgateValue = new TypeF(Plus);
            int r = delgateValue(20, 10);
            Console.WriteLine(r);

            TypeF delgateValue2 = new TypeF(Minus);
            int r2 = delgateValue2(20, 10);
            Console.WriteLine(r2);
            */
            //multy delgate
            /*
            TypeF delgateValue = Plus;
            delgateValue += Minus;
            delgateValue += Multiple;

            Console.WriteLine("두 수 입력 : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            delgateValue(a,b);
            */
            /*
            Firestation fs = new Firestation();
            ThereisAFire fire = new ThereisAFire(fs.Call119);
            fire += fs.ShotOut;
            fire += fs.Escape;
            Console.Write("장소 입력 : ");
            string h = Console.ReadLine();
            fire(h);
            *//*
        }
    }
}
    */