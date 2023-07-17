/*
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //열거형 1
    /*
    enum DR1 { YES, NO, CANCEL}
    enum DR2 { YES=10, NO, CANCEL }
    enum DR3 { YES=10, NO, CANCEL, COMFIRM=20, OK }
    */
    //Test1 과목입력 평균 합계 출력
    /*
    public struct Test1
    {
        public string kor;
        public string eng;
        public string math;
        public int sum;
        public int eva;
        public Test1 (string kor, string eng, string math,int sum,int eva)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;
            this.sum = sum;
            this.eva = eva;
        }
    }*/
    /*
    class Foo { public int num; } //?.(=null조건부 연산자)
    
    internal class Main2307121
    {
        static void Main(string[] args)
        {
        */
            //열거형 1
            /*
            Console.WriteLine((int)DR1.YES);
            DR1 r = DR1.YES;
            Console.WriteLine(r == DR1.YES);

            Console.WriteLine((int)DR3.YES);
            Console.WriteLine((int)DR3.NO);
            Console.WriteLine((int)DR3.CANCEL);
            Console.WriteLine((int)DR3.COMFIRM);
            Console.WriteLine((int)DR3.OK);
            */
            //참조형식 - 메모리주소복사
            /*
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2;
            arr2 = arr1;
            arr2[1] = 20;

            Console.WriteLine("arr1[0] = {0}, arr1[1] = {1}, " +
                "arr1[2] = {2}, " + "arr1[3] = {3}, arr1[4] = {4}",
                arr1[0], arr1[1], arr1[2], arr1[3], arr1[4]);
            Console.WriteLine("arr2[0] = {0}, arr2[1] = {1}, " +
                "arr2[2] = {2}, " + "arr2[3] = {3}, arr2[4] = {4}",
                arr2[0], arr2[1], arr2[2], arr2[3], arr2[4]);
            */
            //표준입력 ConsoleKeyInfo
            /*
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine();
                    Console.WriteLine("A가 눌렸습니다");
                }
                if (keyInfo.KeyChar == 'c')
                {
                    Console.WriteLine();
                    Console.WriteLine("c가 눌렸습니다.");
                }
            }while (keyInfo.Key != ConsoleKey.Escape);
            */
            //Console.ReadLine
            /*
            Console.WriteLine("문자열 입력 : ");
            string input = Console.ReadLine();
            Console.WriteLine("문자열 input : " + input+1);

            int intInput = int.Parse(input);
            Console.WriteLine("int 변환된 input + 1 = {0}",intInput + 1);
            */
            //Test1 과목입력 평균 합계 출력
            /*
            Test1 test1;
            Console.WriteLine("국어 점수 입력 : ");
            test1.kor = Console.ReadLine();
            int intKor = int.Parse(test1.kor);

            Console.WriteLine("영어 점수 입력 : ");
            test1.eng = Console.ReadLine();
            int intEng = int.Parse(test1.eng);

            Console.WriteLine("수학 점수 입력 : ");
            test1.math = Console.ReadLine();
            int intMath = int.Parse(test1.math);

            test1.sum = intKor + intEng + intMath;
            test1.eva = test1.sum / 3;

            Console.WriteLine("해당 성적 합계 : {0}, 평균 : {1}",test1.sum, test1.eva);
            */

            //4장
            //나머지연산자
            /*
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);
            */
            //문자열연산자
            /*
            string str = "3" + "4";
            Console.WriteLine(str);
            Console.WriteLine(+5);
            Console.WriteLine(5+5);
            Console.WriteLine(5 + .5);
            Console.WriteLine(5.01f + "5");
            Console.WriteLine("5" + 3.14f);
            Console.WriteLine(5 + 5 + 5 + "문자열");
            str = 1 + "test" + 3.14f + "abcd";
            Console.WriteLine(str);
            */
            //논리연산자
            /*
            Console.WriteLine((2 > 1) && (2 < 1));
            Console.WriteLine((2 > 1) && (2 > 1));
            Console.WriteLine((2 > 1)||(2 < 1));
            Console.WriteLine((2 < 1) || (2 < 1));
            Console.WriteLine(!true);
            */
            //비트연산자
            /*
            int a = 9, b = 10;
            Console.WriteLine($"{a} & {b} : {a & b}");
            Console.WriteLine($"{a} | {b} : {a | b}");
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");
            int c = 255;
            Console.WriteLine
                ("~{0}(0x{0:0X8}) : {1} (0x{1:X8})", c, ~c);
            */
            //시프트연산자
            /*
            Console.WriteLine("Testing <<...");

            int a = 1;
            Console.WriteLine("a\t   :{0:D5} (0x{0:X8})", a);
            Console.WriteLine("a\t<<1:{0:D5} (0x{0:X8})", a<<1);
            Console.WriteLine("a\t<<2:{0:D5} (0x{0:X8})", a<<2);
            Console.WriteLine("a\t<<5:{0:D5} (0x{0:X8})", a<<5);

            Console.WriteLine("Testing <<...");

            int b = 255;
            Console.WriteLine("b\t   :{0:D5} (0x{0:X8})", b);
            Console.WriteLine("b\t>>1:{0:D5} (0x{0:X8})", b>>1);
            Console.WriteLine("b\t>>2:{0:D5} (0x{0:X8})", b>>2);
            Console.WriteLine("b\t>>5:{0:D5} (0x{0:X8})", b>>5);
            */
            //문자열 복합대입연산자
            /*
            string op = "hello\t";
            op += "world";
            op += "!";
            Console.WriteLine(op);
            */
            //?.(=null조건부연산자)
            /*
            Foo foo = null;
            int? bar;
            bar = foo?.num;
            Console.WriteLine("{0}", bar);
            */
            //??(=null병합연산자)
            /*
            int? x = null; //?를 빼는 순간 null로 초기화 불가능
            int y = x ?? -1;
            Console.WriteLine(y);

            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
            */
/*
        }
    }
}
*/
