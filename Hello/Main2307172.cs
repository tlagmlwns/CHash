/*
using System;
//using MyExtension;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //b. 
    /*
    class Product
    {
        private int price = 100;
        public ref int GetP()
        {
            return ref price;
        }
        public void Print()
        {
            Console.WriteLine($"Price:{price}");
        }
    }*/

    //d, e
    /*
    class Fibonacci
    { 
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public static long Get(int n)
        {
            if (n < 0) return 0;
            if (n == 1) return 1;

            if (memo.ContainsKey(n)) return memo[n];
            else
            {
                long value = Get(n - 2) + Get(n - 1);
                memo[n] = value;
                return value;
            }
        }
    }*/

    //f
    /*
    partial class MyClass
    {
        public void Method1() {Console.WriteLine("Method1");}
        public void Method2() { Console.WriteLine("Method2");}
    }
    partial class MyClass
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }
    }
    */

    //h.
    /*
    public static class IntergerExtension
    {
        public static int Squrae(this int myint) { return myint * myint;}
        public static int Power(this int myint, int exponent)
        {
            int r = myint;
            for (int i = 0; i < exponent; i++) { r *= myint; }
            return r;
        } 
    }
    */

    //테스트 - 2
    /*
    class Four
    {
        public static void Quadrant4_v(int x, int y)
        {
            Console.Write("void 형식의 결과 : ");
            if (x > 0 && y > 0)
                Console.WriteLine(" 1 사분면 입니다.");
            else if (x < 0 && y > 0)
                Console.WriteLine(" 2 사분면 입니다.");
            else if (x < 0 && y < 0)
                Console.WriteLine(" 3 사분면 입니다.");
            else if (x > 0 && y < 0)
                Console.WriteLine(" 4 사분면 입니다.");
            else Console.WriteLine(" (0, 0) 입니다.");
        }
        public static int Quadrant4_i(int x, int y)
        {
            int result;
            if (x > 0 && y > 0)
                return result = 1;
            else if (x < 0 && y > 0)
                return result = 2;
            else if (x < 0 && y < 0)
                return result = 3;
            else if (x > 0 && y < 0)
                return result = 4;
            else return result = 0;
        }
    }*/

    //테스트 - 4
    /*
    class MyMath
    {
        public static int Fact(int x)
        {
            int i,y = 1;
            for (i = 1; i <= x; i++)
                 y *=i;
            return y;
        }
    }*/
    
    /*
    internal class Main2307172
    {*/
        //a
        /*
        static void Swap(ref int input)
        {
            input = 20;
        }*/
        //c. 
        /*DO(int a, int b, out int c, out int d)
             * ->미리 변수선언 안하고 호출하면서 직접선언할 수 있음.*/
        /*
        public static void DO(int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a % b;
        }*/

        //테스트 - 1
        /*
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)");
            return a + b;
        }
        public static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)");
            return a + b + c;
        }
        public static double Plus(double a, double b)
        {
            Console.WriteLine("Calling int Plus(double, double)");
            return a + b;
        }
        public static double Plus(int a, double b)
        {
            Console.WriteLine("Calling int Plus(int, double)");
            return a + b;
        }*/
        //테스트 - 3
        /*
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        */

/*
        static void Main(string[] args)
        {*/
            //a. 값복사와 참조복사 - ref(래퍼런스)
            /*
            int a = 10;
            Console.WriteLine($"Swap이 일어나기전 = {a}");
            Swap(ref a);
            Console.WriteLine($"Swap이 일어난 후 = {a}");
            */

            //b. 값복사와 참조복사
            /*
            Product product = new Product();
            ref int ref_p = ref product.GetP();
            int normal_p = product.GetP();

            product.Print();
            Console.WriteLine($"ref_p={ref_p}");
            Console.WriteLine($"normal_p={normal_p}");

            Console.WriteLine();
            ref_p = 200;
            Console.WriteLine("ref_p값 변경후");
            product.Print();
            Console.WriteLine($"ref_p={ref_p}");
            Console.WriteLine($"normal_p={normal_p}");
            */

            //c. 출력전용 매개변수 키워드 : out
            /*  초기화 하지 않는 매개변수를 전달해도 에러가 발생하지 않는다.
                컴파일러가 호출당하는 매서드에서 초기화하지 않는 지역변수에 
                대해 할당할 것을 보장하기 때문 */
            /*DO(int a, int b, out int c, out int d)
             * ->미리 변수선언 안하고 호출하면서 직접선언할 수 있음.*/
            /*
            Console.WriteLine ("두개의 정수 입력 : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z, s;
            DO(x, y,out z, out s);
            Console.WriteLine($"몫 : {z}, 나머지 : {s}");
            */

            //d. 재귀메서드 - 피보나치 수열
            /*
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));
            */

            //e. 재귀메서드 - Dictionary클래스 메모화
            /*
            Console.WriteLine(Fibonacci.Get(40));
            Console.WriteLine(Fibonacci.Get(90)); //93부터 오버플로우 발생
            */

            //f.partial 분할 클래스 사용
            /*
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();
            myClass.Method3();
            myClass.Method4();
            */

            //g. 확장메서드 - 클래스 이름 앞에 static 가 붙는
            /*
            Console.WriteLine($"3^2:{3.Squrae()}");
            Console.WriteLine($"3^4:{3.Power(4)}");
            Console.WriteLine($"2^10:{2.Power(10)}");
            */

            //테스트 - 1
            /*
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));

            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
            */

            //테스트 - 2 (void형식, int형식)
            /*
            Console.Write(" - x 좌표 입력 > ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" - y 좌표 입력 > ");
            int y = int.Parse(Console.ReadLine());

            Four.Quadrant4_v(x, y);

            Console.Write("int 형식의 결과 : ");
            if (Four.Quadrant4_i(x, y) == 0)
                Console.WriteLine("(0, 0) 입니다.");
            else
                Console.WriteLine($" {Four.Quadrant4_i(x, y)} 사분면 입니다.");
            */

            //테스트 - 3 Swap
            /*
            Console.WriteLine("정수 2개 입력 : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Swap이 일어나기 전 : a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Swap이 일어나고 후 : a = {a}, b = {b}");
            */

            //테스트 - 4 !
            /* 재귀함수를 이용하여 팩토리얼을 구하시오. 정수값을 하나 입력받아
             * 사용하고 Main()메서드와 다른 클래스에 정의된 정적 메서드를 호출하여
             * 매개변수를 보내고 결과값을 반환하시오.
             * 오버플로우가 발생하지 않도록 주의 하시오.
             * 재귀합수는 메인()과 다른 클래스에 정적메서드로 생성
             * 메인()메서드에서 무한 반복문을 사용하여 -1보다작거나 같은 값이 들어오면
             * 다시 입력받로독 하시오
             * 0이들어오면 무한반복문 나가시오.*/
          /*
            while (true)
            {
                Console.Write("팩토리얼 구할 값 입력 : ");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("나갑니다.");
                    break;
                }
                else if (x == 1 || x < 0)
                {
                    Console.WriteLine("다시 입력 바랍니다.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"값 : {MyMath.Fact(x)}");
                    continue;
                }
            }
           
        }
    }
}
          */
         