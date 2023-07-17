/*
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //구조체 MyStruct1
    /*
    public struct MyStruct
    {
        public const float PI = 3.14159f;
        public static int age = 27;
        public int val;
        //public int val = 10;
        public string testA = null; //매개변수를 문자열타입을 받는다면 반드시
        public string testB = null; //null로 초기화를 해라
        public MyStruct(int val1) 
        {
            val = val1;
        }
    }*/
    //구조체 MyStruct2
    /*
    public struct MyStruct2
    {
        public int age;
        public float num;
        public bool isReady;
        public MyStruct2(int inAge, float InNum, bool inisReady)
        {
            this.age = inAge;
            this.num = InNum;
            this.isReady = inisReady;
        }
    }*/
    //구조체 MyStruct3, 클래스 MyClass1
    /*
    public struct MyStruct3 {public int age;}
    class MyClass {public int age;}
    */
    /*
    internal class Main2307112
    {
        static void Main(string[]args)
        {
            // 구조체 1
            /*
            Console.WriteLine("{0}, {1}", MyStruct.PI, MyStruct.age);
            MyStruct s;
            s.val = 10;
            Console.WriteLine(s.val);
            */
            /*
            MyStruct testStruct1;
            testStruct1.val = 12;
            Console.WriteLine(testStruct1.val);

            MyStruct testStruct2 = new MyStruct();
            Console.WriteLine(testStruct2.val);

            MyStruct testStruct3 = new MyStruct(15);
            Console.WriteLine("{0}",testStruct3.val);
            */
            /*
            MyStruct testStruct1;
            Console.Write("val 입력 : ");
            testStruct1.val = int.Parse(Console.ReadLine());
            Console.WriteLine("구조체 맴버 val = {0}",testStruct1.val);

            MyStruct testStruct2;
            Console.WriteLine("문자열 멤버 입력  : ");
            testStruct2.testA = Console.ReadLine(); //쓰기
            testStruct2.testB = Console.ReadLine(); //쓰기
            Console.WriteLine("구조체 문자열 멤버1 {0}, " +"구조체 문자열 멤버2 {1}", 
                                testStruct2.testA, testStruct2.testB);
            */
            // 구조체 2
            /*
            MyStruct2 test1, test4;
            test1.age = 12;
            //test4 = test1; 다죽이면 가능
            Console.WriteLine("test.age = {0}",test1.age);
            //Console.WriteLine("test4.age = {0}", test4.age);

            MyStruct2 test2 = new MyStruct2();
            Console.WriteLine("test2.age = {0}, test2.num = {1}, test2.isReady = {2}", 
                test2.age, test2.num, test2.isReady);

            MyStruct2 test3 = new MyStruct2(13, 40, true);
            Console.WriteLine("생성자를 통해 매개변수 값 전달 : " +
                "test3.age = {0}, test3.num = {1}, test3.isReady = {2}", 
                test3.age, test3.num, test3.isReady);
            */
            // 구조체 3 : 값 형식,
            // 클래스 1 : 참조 형식(가리키는 주소값 넘어옴)
            /*
            MyStruct3 test1 = new MyStruct3();
            test1.age = 12;
            MyStruct3 test2 = test1;
            test2.age = 24;
            Console.WriteLine("MyStruct -> " +
                "test1.age = {0}, test2.age = {1}", 
                test1.age, test2.age);

            MyClass test3 = new MyClass();
            test3.age = 12;
            MyClass test4 = test3; 
            test4.age = 24;
            Console.WriteLine("MyClass -> " +
                "test3.age = {0}, test4.age = {1}", 
                test3.age, test4.age);
            */

            // 튜플 1 : 복합데이터 형식을 하나로 사용
            /*
            (int, int) tuple1 = (100, 50);
            Console.WriteLine($"{tuple1.Item1},{tuple1.Item2}");

            (int Max, int Min) tuple2 = (112, 50);
            Console.WriteLine($"Min : {tuple2.Min}, Max : {tuple2.Max}");

            var tuple3 = (Max: 110, Min: 50);
            Console.WriteLine($"Max : {tuple3.Max}, Min : {tuple3.Min}");

            var a = ("비둘기", 99999, 3.14);
            Console.WriteLine($"{a.Item1}, {a.Item2}, {a.Item3}");
            */
            // 튜플 2 : 분해, 앞에 있으면 합치고 뒤에 있으면 분해
            /*
            (int, int) tuple1 = (114, 50);
            var(max, min) = tuple1;
            Console.WriteLine($"max = {max}, min = {min}");
            */
            // 튜플 3 : 대입
            /*
            var name1 = ("잠 ", 1);
            var name2 = ("커피 ", 6);
            name1 = name2;
            Console.WriteLine($"{name1.Item1},{name1.Item2}");
            name1 = ("밤만주 ", 25);
            Console.WriteLine($"{name1.Item1},{name1.Item2}");
            */
            /*
        }
    }
}
*/