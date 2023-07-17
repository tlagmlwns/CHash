/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Main2307171
    {*/
        //q. 클래스 메서드 실습1
        /*
        class Test
        {
            public static int Power(int x)
            {
                return x * x;
            }
        }*/
        //b. 클래스 메서드 실습2
        /*
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) 
                    return -input;
                else return input;
            }
        }
        */
        //c. 인스턴스 변수 vs 클래스 변수
        /*
        public int instanceVariable = 10; //인스턴스 변수, 메인에 생성해야 가능
        public static int instanceVariable = 10;// 클래스 변수
        */
        //d. 
        /*
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 함수가 호출되었습니다.");
            }
        }*/
        //e. 배열을 매개변수로 사용한 경우
        /*
        static void TA(string[] arr)
        {
            string[] hD = { "월", "화", "수", "목", "금", "토" };
            for(int i=0; i<arr.Length; i++)
                arr[i] = hD[i];
        }*/
        //return 실습
        /*
        class Test
        {
            public int Sum(int min, int max)
            {
                int op = 0;
                for(int i = min; i <= max; i++) { op += i; }
                return op;
            }
            public static int Sum_static(int min, int max)
            {
                int op = 0;
                for (int i = min; i <= max; i++) { op += i; }
                return op;
            }
        }
        */
        //f. 
        /*
        static int[] CA1(int nS)
        {
            int[] arr = new int[nS];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        static int[,] CA2(int nR, int nC) 
        {
            int index = 0;
            int[,] arr2 = new int[nR, nC]; 
            for (int i = 0;i < nR; i++)
                for (int j = 0;j < nC; j++)
                    arr2[i, j] = index++;
            return arr2;
        }
        */
        //h.오버로딩
        /*
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static decimal Abs(decimal input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

        }
        */
        //i. 
        /*
        static int Sum(params int[] args)
        {
            Console.Write("Summing..");
            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if (i>0) 
                    Console.Write(", ");
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }*/
        //j. 명명된 매개변수
        /*
        static void PrintP(String name, int phone)
        {
            Console.WriteLine("이름 : {0}, 폰 : {1}",name, phone);
        }*/
        //m. 선택적 매개변수
        /*
        static void PrintP(String name, string phone)
        {
            Console.WriteLine("이름 : {0}, 폰 : {1}", name, phone);
        }*/
        /*
        static void Main(string[] args)
        {*/
            //a. 클래스 메서드 실습1
            /*
            //Test test = new Test();
            Console.WriteLine(Test.Power(10));
            Console.WriteLine(Test.Power(20));
            */
            //b. 클래스 메서드 실습2
            /*
            int a;
            for (int i = 0; i < 2; i++) {
                Console.Write("입력 : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(MyMath.Abs(a));
            }*/
            //c.
            //Console.WriteLine(instanceVariable);
            //d. 아무것도 변환하지 않는 메서드 사용시 위치에 void 적기
            /*
            Test test = new Test();
            test.Print();
            test.Print();
            test.Print();
            */
            //e. 배열을 매개변수로 사용한 경우
            /*
            string[] eD = { "M", "T", "W", "T2", "F", "S" };
            TA(eD);
            foreach (string atr in eD)
            {
                Console.WriteLine(atr);
            }*/
            //return 실습
            /*
            Test test = new Test();
            Console.Write("min 값 입력 : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("max 값 입력 : ");
            int x  = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n}부터 {x}까지의 합 : " + test.Sum(n, x));
            Console.WriteLine($"{n}부터 {x}까지의 합 : " + Test.Sum_static(n, x));
            */
            //f. 배열이름을 리턴하는 메서드
            /*
            int[ ] nArr = CA1(5);
            int[ , ] nArr2 = CA2(2, 3);

            for (int i = 0; i<nArr.Length; i++)
                Console.Write(nArr[i]);
            Console.WriteLine();

            for (int i = 0; i < nArr2.GetLength(0); i++)
            {
                for (int j = 0; j < nArr2.GetLength(1); j++)
                    Console.Write(nArr2[i, j]);
                Console.WriteLine();
            }
            */
            //h. 오버로딩
            /*
            for (int l = 0; l < 3; l++) 
            {
                //int
                Console.WriteLine("정수를 입력하시오");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("정수형 Abs()호출 : "+MyMath.Abs(i));

                //double
                Console.WriteLine("정수를 입력하시오");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("실수형 Abs()호출 : " + MyMath.Abs(d));

                //decimal
                Console.WriteLine("정수를 입력하시오");
                decimal z = decimal.Parse(Console.ReadLine());
                Console.WriteLine("실수형(decimal) Abs()호출 : " + MyMath.Abs(z));
            }
            */
            //i.가변길이 매개변수
            /*
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum : {sum}");
            
            //j. 명명된 매개변수
            ///*
            PrintP(name: "박찬호", phone: "010-123-1234");
            PrintP(phone: "010-987-9876", name: "박지성");
            PrintP("손흥민", "010-111-1111");
            PrintP("류현진", phone: "010-567-5678");
            */
            //m. 선택적 매개변수
            /*
            PrintP("태연");
            PrintP("윤아", "010-123-1234");
            PrintP(name: "유리");
            PrintP(name: "서현", phone: "010-789-7890");
            */
            //l
            //n
/*
        }
    }
}
*/