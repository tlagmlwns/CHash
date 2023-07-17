/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{*/
    //조건문 응용 test 구조체
/*    
    public struct xyCoo //좌표 xy
    {
        public string x;
        public string y;
        public xyCoo(string x, string y)
        {
            this.x = x;
            this.y = y;
        }
    }*/
    /*
    internal class Main2307122
    {
        static void Main(string[] args)
        {*/
            //5장
            //조건문실습 - 홀짝구분
            /*
            string x;
            Console.Write("숫자 입력 : ");
            //x = Console.ReadLine();
            int intX = int.Parse(Console.ReadLine());
            if (intX % 2 == 1)
                Console.WriteLine("홀수입니다.");
            else
                Console.WriteLine("짝수입니다.");
            */
            //조건문실습 - 오전오후구분
            /*
            Console.WriteLine("현재 시각은");
            Console.Write("{0}년 ",DateTime.Now.Year);
            Console.Write("{0}월 ", DateTime.Now.Month);
            Console.Write("{0}일 ", DateTime.Now.Day);
            Console.Write("{0}시 ", DateTime.Now.Hour);
            Console.Write("{0}분 ", DateTime.Now.Minute);
            Console.WriteLine("{0}초", DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.ToShortTimeString());

            if (DateTime.Now.Hour < 12)
                Console.WriteLine("오전입니다.");
            else 
                Console.WriteLine("오후입니다.");
            */
            //if-else if문 공백없이 작따 쓰면 error 아예 없으면 아님
            /*
            Console.WriteLine("점수를 입력 : ");
            int s = int.Parse(Console.ReadLine());
            char g = ' ';
            if (s >= 90) { g = 'a'; }
            else if (s >= 80) { g = 'b'; }
            else if (s >= 70) { g = 'c'; }
            else g = 'd';
            Console.WriteLine(g);
            */
            //조건문실습 - 현재시간 관측후 아점저출력
            /*
            if(DateTime.Now.Hour < 11) { Console.WriteLine("아침"); }
            else if(DateTime.Now.Hour < 15) { Console.WriteLine("점심"); }
            else { Console.WriteLine("저녁"); }
            */
            //switch, case 문(문자열)
            /*
            Console.Write("yes / no 중 하나 입력 : ");
            string str =  Console.ReadLine();
            switch(str) //C#에선 문자열도 받는다.
            {
                case "no":
                    Console.WriteLine("ㄴㄴ");
                    break;
                case "yes":
                    Console.WriteLine("ㅇㅇ");
                    break;
            }
            */
            //조건문실습 - 요일입력
            /*
            Console.WriteLine("[보기] 일 월 화 수 목 금 토");
            Console.Write("요일을 입력 : ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "일":
                    Console.WriteLine("Sun");
                    break;
                case "월":
                    Console.WriteLine("Mon");
                    break;
                case "화":
                    Console.WriteLine("Tue");
                    break;
                case "수":
                    Console.WriteLine("Wed");
                    break;
                case "목":
                    Console.WriteLine("Thu");
                    break;
                case "금":
                    Console.WriteLine("Fri");
                    break;
                case "토":
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine("해당 문자는 없습니다.");
                    break;
            }
            */
            //case안에 데이터 형식 신기한 녀석
            /*
            object obj = null;
            Console.Write("숫자형태를 입력하시오 : ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int out_i))
                obj = out_i;
            else if (float.TryParse(str, out float out_f))
                obj = out_f;
            else
                obj = str;

            switch (obj)
            {
                case int i when i >= 0:
                    Console.WriteLine("{0}는 양의 int형식 입니다.", i);
                    break;
                case int i:
                    Console.WriteLine("{0}는 음의 int형식 입니다.", i);
                    break;
                case float f when f >= 0:
                    Console.WriteLine("{0}는 양의 float형식 입니다.", f);
                    break;
                case float f:
                    Console.WriteLine("{0}는 음의 float형식 입니다.", f);
                    break;
                default:
                    Console.WriteLine("{0}는 모르는 형식입니다.", obj);
                    break;
            }
            */
            //조건문 응용
            /*
            Console.Write("입력 : ");
            string l = Console.ReadLine();
            Console.Write("상대방 : ");
            if (l.Contains("ㅎㅇ"))
                Console.WriteLine("ㅎㅇ");
            else if (l.Contains("ㅂㅂ"))
                Console.WriteLine("ㅂㅂ");
            else
                Console.WriteLine("ㅋㅋ");
            */
            /*
            Console.WriteLine("콘솔키를 입력 : ");
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow: Console.WriteLine("위"); break;
                case ConsoleKey.DownArrow: Console.WriteLine("아래"); break;
                case ConsoleKey.RightArrow: Console.WriteLine("오"); break;
                case ConsoleKey.LeftArrow: Console.WriteLine("왼"); break;
                default: Console.WriteLine("잘못입력");break;
            }
            */
            //조건문 응용 test -노멀, 구조체
            /*      
            Console.WriteLine("좌표를 입력하시오(x,y) : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0){Console.WriteLine("1사분면");}
            else if (y > 0 && x < 0) { Console.WriteLine("2사분면"); }
            else if (x > 0 && y < 0) { Console.WriteLine("3사분면"); }
            else Console.WriteLine("4사분면");
            */
            /*
            xyCoo c;
            Console.WriteLine("좌표를 입력하시오(x,y) : ");
            c.x = Console.ReadLine();
            int x = int.Parse(c.x);
            c.y = Console.ReadLine();
            int y = int.Parse(c.y);
            if (x > 0 && y > 0) { Console.WriteLine("1사분면"); }
            else if (y > 0 && x < 0) { Console.WriteLine("2사분면"); }
            else if (x > 0 && y < 0) { Console.WriteLine("3사분면"); }
            else Console.WriteLine("4사분면");
            */
            //do while
            /*
            int i = 10;
            do { Console.WriteLine("a) i : {0}", i--); } while (i > 0);
            do { Console.WriteLine("b) i : {0}", i--); } while (i > 0);
            */
            //foreach
            /*
            int[] arr = { 1, 2, 3, 4 };
            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++) list.Add(i+1);
            //list.Add(1); list.Add(2); list.Add(3);
            foreach (int nValue in arr){Console.WriteLine(nValue);}
            Console.WriteLine("\n");
            foreach (int nValue2 in list) { Console.WriteLine(nValue2);}
            */
            /*
            string[] intArray = { "사과", "배", "포도", "딸기", "바나나" };
            Console.WriteLine("foreach와 var를 통해 출력");
            foreach (var str in intArray) { Console.WriteLine(str); }*/
            //무한루프 탈출하기
            /*
            while (true)
            {
                Console.WriteLine("계속할까요?(y/n) > "  );
                string ans = Console.ReadLine();
                if ((ans == "n") || (ans == "no") || (ans == "N") ||
                    (ans == "NO") || (ans == "노") || (ans == "노우") ||
                    (ans == "ㄴㄴ") || (ans == "ss") || (ans == "아니"))
                    break;

            }*/
            //test 나무
            /*
            for(int i = 0; i < 8; i++)
            {
                for (int j = 6; j >= i; j--)
                    Console.Write(" ");
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write("*");
                Console.WriteLine(); 
            }
            */
            //test 나비
            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 5; j >= i; j--)
                    Console.Write("*");
                for (int k = 0; k < 2 * i + 1; k++)
                    Console.Write(" ");
                for (int l = 5; l >5; l--)
                    Console.Write("*");
                Console.WriteLine();
            }
            */

            //6장
            /*
            int[] nArray = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for (int i = 0; i < 5; i++)
                Console.WriteLine("{0} ", nArray[i]);
            Console.WriteLine();

            for (int i = 0; i < nArray.Length; i++)
            {
                Console.WriteLine("{0} ", nArray[i]);
                sum += nArray[i];
            }
            Console.WriteLine();
            foreach (int i in nArray)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine();
            */
/*
        }
    }
}
           */ 