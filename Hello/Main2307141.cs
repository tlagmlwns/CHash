/*
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //단또 클래스
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
    }
    */
    //감고양대 클래스
    /*
    class Gamgo
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;
        public Gamgo(string name, int price)
        {
            Gamgo.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
        public Gamgo() { }
        ~Gamgo()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
    */
    //class MyMath { public static double PI = 3.141592; }
    //G
    /*
    class G { public static int C = 0; }
    class A { public A() { G.C++; } }
    class B { public B() { G.C++; } }
    */
    //static의 차이점
    /*
    class Card
    {
        public string kind;
        public int num;
        public static int w = 100;
        public static int h = 250;
        Random random = new Random();
        public void call(string name)
        {
            num = random.Next(1, 11);
            Console.WriteLine($"{name}의 카드의 번호는 {num}입니다.");
        }
        public static void ttM()
        {
            Console.WriteLine("카드의 총 수는 52장 입니다.");
        }
    }
    */
    //this()
    /*
    class MyClass
    {
        int a, b, c;
        public MyClass() {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }
        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }
        public void printFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    */
    /*
    class Ex
    {
        List<int> list = new List<int>();
        
    }*/
    //로봇
    /*
    class Member
    {
        public string Name;
        public int Mineral;
        public int Supply;
        public int Hp;
        public int Attack;
        public Member(string name, int mineral, int supply, int hp, int attack)
        {
            Name = name;
            Mineral = mineral;
            Supply = supply;
            Hp = hp;
            Attack = attack;
        }
    }*/
    //클래스 요소 제거와 역 반복문
    /*
         class Student
         {
             public string Name;
             public int Grade;
         }*/
    //문제 풀이
    /*
    class Student
    {
        private string Name;
        public string SetName { 
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Grade;
        public int Kor;
        public int Eng;
        public int Math;
        public int Everage(int Kor, int Eng, int Math)
        {
            return (Kor + Eng + Math) / 3;
        }
    }*/
    /*
    internal class Main2307141
    {

        static void Main(string[] args)
        {*/
    //단또
            /*
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "red";
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
            Cat nabi = new Cat("나비", "갈색");
            Console.WriteLine($"{nabi.Name} : {nabi.Color}");
            */
            //감고양대
            /*
            Gamgo gamzA = new Gamgo("감자", 2000);
            Gamgo gogoomA = new Gamgo("고구마", 3000);
            Gamgo yangpA = new Gamgo("양파", 2500);
            Gamgo depA = new Gamgo("대파", 2500);
            Gamgo aA = new Gamgo(); //빈공간 인스턴스 변수
            aA = depA; //복사
            Console.WriteLine(gamzA.id + " : " + gamzA.name + " : " + gamzA.price + "원"); 
            // 인스턴스 통해 접근 -> 인스턴스 변수
            Console.WriteLine(gogoomA.id + " : " + gogoomA.name + " : " + gogoomA.price + "원");
            Console.WriteLine(yangpA.id + " : " + yangpA.name + " : " + yangpA.price + "원");
            Console.WriteLine(depA.id + " : " + depA.name + " : " + depA.price + "원");
            Console.WriteLine(aA.id + " : " + aA.name + " : " + aA.price + "원");
            Console.WriteLine(Gamgo.counter + "개 생성되었습니다.");
            */
            // Console.WriteLine(MyMath.PI);
            //G
            /*
            Console.WriteLine($"start. G.C : {G.C}");
            for( int i = 0; i < 2; i++ ) 
            { new A(); new B(); Console.WriteLine($"G.C : {G.C}"); }
            Console.WriteLine($"start. G.C : {G.C}");
            */
            //카드게임
            /*
            Console.WriteLine($"카드의 크기는 가로 {Card.w}, 세로는 {Card.h}입니다.");
            Card.ttM();

            Card g1 = new Card();
            g1.call("game1");
            g1.call("game1");

            Console.WriteLine("새로운 게임을 합니다.");
            Card.w = 150;
            Card.h = 350;
            Console.WriteLine($"카드의 크기는 가로 {Card.w}, 세로는 {Card.h}입니다.");
            */
            //this()
            /*
            MyClass a = new MyClass();  
            a.printFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.printFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.printFields();
            */
            /*
            Console.WriteLine();
            Console.WriteLine("--------로또 생성기--------");
            Console.Write("몇 번 하실껀가여?(최대 5번) : ");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            Console.WriteLine("----------------------------");
            Console.WriteLine("           1075회");
            Random rand = new Random();
            for(int k  = 0; k < n; k++)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("\t"+rand.Next(1, 51));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            */
            //Rand
            /*
            Random rnd = new Random();
            for(int q = 0; q < 5; q++)
            {
                double d1 = Math.Round(rnd.NextDouble());
                Console.WriteLine(d1);
                Console.WriteLine(rnd.NextDouble()*10);
            }
            */
            //Add
            /*
            List<int> list = new List<int>() { 11, 22, 53 };
            Random rnd = new Random();
            for(int a=0; a<6; a++)
            { list.Add(rnd.Next(1, 101)); }
            //list.Remove(53);
            foreach(int item in list)
            {
                Console.WriteLine("Count : " + list.Count + ", item : " + item);
            }
            */
            //foreach (int i in list) { Console.WriteLine(list.Count); }
            /*
            List<string> ri = new List<string>(new string[]
            {
                "qwer",
                "tyop",
                "asdf",
                "ghjkl"
            });
            List<string> ra = ri.GetRange(0, 3);
            foreach (string ri in ra) { Console.WriteLine(ri); }
            */
            //Math
            /*
            Console.Write("입력 : ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            float a = float.Parse(str1);
            float b = float.Parse(str2);

            Console.WriteLine("Ads : "+Math.Abs(a));
            Console.WriteLine("Ceiling : " + Math.Ceiling(a));
            Console.WriteLine("Floor : " + Math.Floor(a));
            Console.WriteLine("Max : " + Math.Max(a,b));
            Console.WriteLine("Min : " + Math.Min(a,b));
            Console.WriteLine("Round : " + Math.Round(a));
            */
            //로봇
            /*
            Random rand = new Random(); 
            Member m1 = new Member("건설로봇",50,1,45,5);
            Member m2 = new Member("생산로봇", 40, 2, 41, 2);
            Member m3 = new Member("랜덤로봇",rand.Next(1,51) , rand.Next(1, 11), rand.Next(1, 51), rand.Next(1, 1));
            
            Console.WriteLine("Name : "+m1.Name);
            Console.WriteLine("Mineral : {0}", m1.Mineral);
            Console.WriteLine($"Supply : {m1.Supply}");
            Console.WriteLine($"Hp : {m1.Hp}");
            Console.WriteLine($"Attack : {m1.Attack}");
            */
            //숫자 맞추기
            /*
            Random rnd = new Random();
            Console.WriteLine("ai 가 숫자를 정하는 중입니다.");
            int y = rnd.Next(1, 51);
            Console.Write("ai 가 숫자를 정했습니다. 이제");
            while (true)
            {
                Console.Write("숫자를 입력하시오 : ");
                int x = int.Parse(Console.ReadLine());
                if (x > y) Console.WriteLine("> {0}보단 작은 숫자입니다.\n", x);
                else if (y > x) Console.WriteLine($"> {x}보단 큰 숫자입니다.\n");
                else
                {
                    Console.WriteLine("> 정답입니다.\n");
                    break;
                }
            }
            */
            //클래스 요소 제거와 역 반복문
            /*
            int i;
            List<Student> list = new List<Student>();
            Console.WriteLine("6번 입력하시오");

            for (i = 0; i < 7; i++) { //입력
                Console.Write("{0}번째 - 이름 : ", i + 1);
                string n = Console.ReadLine();
                Console.Write("{0}번째 - 학년(1~3) : ", i + 1);
                int g = int.Parse(Console.ReadLine());
                list.Add(new Student { Name = n, Grade = g });

                if (i == 6) Console.WriteLine("- 입력 끝");
                else if (i == 0) Console.WriteLine("마지막 입니다.");
                else Console.WriteLine($"- {6 - i}번 남았습니다.");
                Console.WriteLine("--------------------------");
            }
            for (i = list.Count-1; i > 0; i--) //거름망
            {
                if (list[i].Grade>1)
                {
                    list.Remove(list[i]);
                }            
            }
            Console.WriteLine("1학년 출력중 : "); //출력
            for(i = 0; i< list.Count;i++)
                Console.WriteLine(list[i].Name +" : " + list[i].Grade); 
            */
            //문제 풀이
            /*
            List<Student> list = new List<Student>();
            for (int i = 0; i < 1; i++) 
            {
                Console.WriteLine("{0} 번째",i+1);
                Console.Write("이름 : ");
                string n = Console.ReadLine();
                Console.Write("학년(1~3) : ");
                int g = int.Parse(Console.ReadLine());
                Console.Write("국어 점수 : ");
                int k = int.Parse(Console.ReadLine());
                Console.Write("영어 점수 : ");
                int e = int.Parse(Console.ReadLine());
                Console.Write("수학 점수 : ");
                int m = int.Parse(Console.ReadLine());

                list.Add(new Student {  SetName = n, Grade = g, Kor = k, Eng = e, Math = m });
                //if (i == 5) Console.WriteLine("- 입력 끝");
                //else if (i == 0) Console.WriteLine("마지막 입니다.");
                //else Console.WriteLine($"- {6 - i}번 남았습니다.");
                Console.WriteLine("--------------------------");
            }
            for(int i = 0;i < 1;i++)
            {
                Console.WriteLine($"학생이름 : {list[i].SetName}, " +
                    $"학년 : {list[i].Grade}, " +
                    $"평균 : {list[i].Everage(list[i].Kor, list[i].Eng, list[i].Math)}");
            }
            *//*
        }
    }
}

    */