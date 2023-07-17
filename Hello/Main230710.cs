/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hello
{
    internal class Main230710

    {
        static bool boolVar; //11. 맴버함수 (=전역변수) false로 자동초기화
        static void Main(string[] args)
        {*/

            //230710
            //3. {방 호수} 알아보기
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} {1} {2}", 3.14f, 12, 4);
            Console.WriteLine("{0} + {1} = {2}", 1, 2, 1 + 2);
            */
            //4. C# 출력꾸미기
            /*
Console.WriteLine("{0:c}", 12345); //통화
Console.WriteLine("{0:n}", 12345); //자릿수
Console.WriteLine("{0:f2}", 0.12345); //실수
Console.WriteLine("{0:x}", 15);
*/
            //5. $쓰기
            /*
byte a = 255;
sbyte b = (sbyte)a;
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");   
*/
            //6. 정수형 자료형 연습
            /*
sbyte a = -10;
byte b = 40;
Console.WriteLine($"a = {a},b = {b}");

short c = -30000;
ushort d = 60000;
Console.WriteLine($"c = {c},d = {d}");

int e = -1000_0000;
uint f = 3_0000_0000;
Console.WriteLine($"e = {e},f = {f}");

long g = -5000_0000_0000;//'_' : 자릿수 구분자로 10,2,16진수대해 사용가능
ulong h = 200_0000_0000_0000_0000;
Console.WriteLine($"g = {g},h = {h}");
*/
            //7. 최소값 상수와 최대값 상수
            /*
Console.WriteLine("{0} ~ {1}",short.MinValue,short.MaxValue);
*/
            //8. 리터럴 연습
            /*
byte a = 240; //10진수 리터럴
Console.WriteLine($"a = {a}");

byte b = 0b1111_0000; //2진수 리터럴
Console.WriteLine($"b = {b}");

byte c = 0XF0; //16진수 리터럴
Console.WriteLine($"c = {c}");

uint d = 0x1234_abcd; //16진수 리터럴
Console.WriteLine($"d = {d}");
*/
            //9. 실수형의 연습
            /*
float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
*/
            //10. 문자형 연습
            /*
int number1 = '7';
int number2 = 'A';
Console.WriteLine("캐릭터 '7'은 문자상수 {0}이다.",number1);
Console.WriteLine("캐릭터 'A'은 문자상수 {0}이다.",number2);
*/
            //11. 맴버변수 bool형의 기본값 지역변수 bool변수값 초기화
            /*
bool localBoolVar = true; //지역변수, 초기화 안하면 error
Console.WriteLine("{0} {1}",boolVar,localBoolVar); //False True
*/
            //12. object로 선언한 다양한 자료형 형태
            /*
object a = 123;
object b = 3.1415_9265_3589_7932_3846_2643_3832_79m;
object c = true;
object d = "안녕하세요";

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
*/
            // 스택 2가지 :
            // 1-> 숫자는 바로 스택에 저장,
            // 2-> 스택에 주소값 힙에는 값을 저장하여 스택이 가리킨다.

/*           
        }
    }
}*/