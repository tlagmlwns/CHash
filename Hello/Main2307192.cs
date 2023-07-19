/*
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hello
{
    internal class Main2307192
    {*/

        //1
        /*
        interface IFightable { void attack(); }
        abstract class Uint
        {
            public abstract void move(int x, int y);
            void stop() { }
        }
        class Marine : Uint, IFightable
        {
            public override void move(int x, int y)
            {Console.WriteLine("Marine Move [X:{0}, Y:{1}]", x, y);}
            public void attack() { Console.WriteLine("Marine이 공격합니다."); }
            public void stimPack() { Console.WriteLine("stimPack을 분사합니다."); }
        }
        class Dropship : Uint
        {
            public override void move(int x, int y)
            { Console.WriteLine("Marine Move [X:{0}, Y:{1}]", x, y); }
            public void load() { Console.WriteLine("수송기 도착"); }
        }*/
        //2
        /*
        class User
        {
            public void method(A a) { a.method(); }
        }
        class A { public void method() { Console.WriteLine("A클래스의 메서드"); } }
        class B { public void method() { Console.WriteLine("B클래스의 메서드"); } }
        */
        //3 : I
        /*
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return this.Name.CompareTo((obj as Product).Name); //Price 기준으로 비교하라고 시키기
                //throw new NotImplementedException();//아무것도 적지않아 발생하는 에러방지용 지우고 코드쓰기
            }

            public override string ToString() { return Name + " : " + Price + "원"; }
        }*/
        //4 seald
        /*
        class FolderPhone { public virtual void Network() { } }
        class ThreePhone : FolderPhone { public sealed override void Network() { } }
        class SmartPhone:ThreePhone { public override void Network() { }}
        */
        //예외처리
        /*
        static void DoSomething()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);

            if (num < 80) Console.WriteLine($"현재 온도는 {num} 입니다.");
            else throw new Exception($"위험! 현재 온도가 높습니다. :{num}");
        }*/
        //예외 되 던지기
        /*
        static int Divide(int divisor, int dividend)
        {
            try { Console.WriteLine("Divide() 시작"); return divisor / dividend; }
            catch (DivideByZeroException e) { Console.WriteLine("Divide() 예외 발생"); throw e; } 
            finally { Console.WriteLine("Divide() 끝"); }
        }*/
        //test
        /*
        class Artists:IComparable
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Birth { get; set; }
            public int Die { get; set; }
            public int Age (int Die, int Birth) { return Die - Birth; }

            public int CompareTo(object obj) {return this.Birth.CompareTo((obj as Artists).Birth);}
            public override string ToString() { return Name + ", " + Country + ", " + Birth + ", " + Die ; }
        }*/
        /*
        class Artists2
        {
            public string Name;
            public string Country;
            public int Birth;
            public int Die;
            public Artists2(string name, string country, int birth, int die)
            {
                Name = name;
                Country = country;
                Birth = birth;
                Die = die;
            }

            public int CompareTo(object obj) { return this.Birth.CompareTo((obj as Artists).Birth); }
            public override string ToString() { return Name + ", " + Country + ", " + Birth + ", " + Die; }
        }*/
        /*
        static void Main(string[] args)
        {*/
            //1
            /*
            Marine marine1 = new Marine();
            marine1.move(300, 300);
            marine1.attack();
            marine1.stimPack();
            Dropship dropship1 = new Dropship();
            dropship1.move(200, 200);
            dropship1.load();
        }
            */
            //2
            /*
            User u1 = new User();
            u1.method(new A());

            //User u2 = new User();
            //u2.method(new B());
            */
            //3
            /*
            List<Product> list = new List<Product>()
            {
                new Product() {Name = "나 회사 마우스패드", Price = 1500},
                new Product() {Name = "마 회사 마우스", Price = 14000},
                new Product() {Name = "가 회사 키보드", Price = 40000},
                new Product() {Name = "바 회사 웹캠", Price = 35000},
            };
            list.Sort(); //list의 정렬 sort() 매서드
            foreach (var item in list) { Console.WriteLine(item); }
            */
            //4...
            //예외처리
            /*
            int[] arr = { 1, 2, 3,3,3,3, 4, 5 };
            try { for (int i = 0; i < 5; i++) Console.WriteLine(arr[i]); }
            catch ( IndexOutOfRangeException e) {
                    Console.WriteLine("배열의 인덱스 예외가 발생");
                    Console.WriteLine($"{e.Message}");
                
            }
            Console.WriteLine("프로그램 종료");
            */
            //예외던지기
            /*
            try { while (true) { DoSomething(); System.Threading.Thread.Sleep(1000); } }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("시스템 종료"); }
            */
            //예외 되 던지기
            /*
            try
            {
                Console.Write("제수를 입력 : ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.Write("피제수를 입력 : ");
                int divided = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{divisor} / {divided} = {Divide(divisor, divided)}");
            }
            catch (DivideByZeroException e) { Console.WriteLine("에러 : " + e.Message); }
            catch (FormatException e) { Console.WriteLine("에러 : " + e.Message); }
            finally { Console.WriteLine("프로그램을 종료합니다."); }
            */
            //test
            /*
            List<Artists> list = new List<Artists>()
            {
                new Artists() { Name="레오나르도 다빈치", Country="이탈리아", Birth=1452, Die=1519},
                new Artists() { Name="빈센트 반 고흐", Country = "네덜란드", Birth = 1853, Die=1890},
                new Artists() { Name = "클로드 모네", Country = "프랑스", Birth = 1840, Die = 1926 },
                new Artists() { Name = "파블로 피카소", Country = "스페인", Birth = 1881, Die = 1973 },
                new Artists() { Name = "베르메르", Country = "네덜란드", Birth = 1632, Die = 1675 },
                new Artists() { Name = "르노아르", Country = "프랑스", Birth = 1841, Die = 1919 }
            };
            Console.WriteLine("List 형식 출력");
            
            foreach (var artist in list) { Console.WriteLine(artist); }
   */
            /*
        }
    }
}
            */