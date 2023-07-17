using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Main2307171
    {
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
        //e. 

        static void Main(string[] args)
        {
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
            //e. 

        }
    }
}
