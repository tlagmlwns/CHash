/*
using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata.Ecma335;

namespace Hello
{
    internal class Main2307111
    {
        static void Main(string[] args)
        {*/

            //230711
            //1. 문자열 입력해서 출력하기
            /*
            string str1 = "ㅎ";
            string str2 = "ㅇ";
            Console.Write("{0} \n",str1);
            Console.Write("{0} \n",str2);
            Console.WriteLine("{0} ",str2[1]);
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);
            */
            //2. 문자열 더하기
            /*
            string str1 = "Hello_";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[6]);
            Console.WriteLine("문자 갯수 : {0}", str3.Length);
            Console.WriteLine($"문자 갯수 : {str3.Length}");
            */
            //3. 문자열 안에서 찾아 바꾸기
            /*
            string greeting = "Good morning";
            WriteLine(greeting);
            WriteLine();

            WriteLine("IndexOf \"Good\": {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o': {0}", greeting.IndexOf('o'));

            WriteLine("LastIndexOf \"Good\": {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o': {0}", greeting.LastIndexOf('o'));

            WriteLine("StartsWith \"Good\": {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith \"Morning\": {0}", greeting.StartsWith("Morning"));

            WriteLine("EndsWith \"Good\": {0}", greeting.IndexOf("Good"));
            WriteLine("EndsWith \"Morning\": {0}", greeting.EndsWith("Morning"));

            WriteLine("Contains \"Evening\": {0}", greeting.Contains("Evening"));
            WriteLine("Contains \"Morning\": {0}", greeting.Contains("Morning"));

            WriteLine("IndexOf \"Morning\" with \"Evening\": {0}", greeting.Replace("Morning","Evening"));
            */
            //4. 문자열 변형하기
            /*
            WriteLine("ToLower() :  '{0}'", "ABC".ToLower());
            WriteLine("ToUpwer() :  '{0}'", "abc".ToUpper());

            WriteLine("Insert() :  '{0}'", "Happy Friday".Insert(5, "Sunny"));
            WriteLine("Remove() :  '{0}'", "I dont lv u".Remove(2, 6));

            WriteLine("Trim() :  '{0}'", " No Spaces".Trim());
            WriteLine("TrimStart() :  '{0}'", " No Spaces".TrimStart());
            WriteLine("TrimEnd() :  '{0}'", " No Spaces".TrimEnd());
            */
            //5. 문자열 분할하기
            /*
            string greeting = "Good morning";

            Console.WriteLine(greeting.Substring(0, 5));
            Console.WriteLine(greeting.Substring(5));

            string[] arr = greeting.Split(',');
            Console.WriteLine("Word Count : {0}",arr.Length);
            */
            //6. var
            /*
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0} / {1} / {2:f} / {3:f1} / {4} ",value1, value2, value2, value2, sum);
            */
            /*
            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}",a.GetType(),a);

            var b = 3.14;
            var c = "Hello World!";
            var d = new int[] { 10, 20, 30 };
            Console.WriteLine($"{b} / {c} / {d[0]}, {d[1]}, {d[2]}");
            */
            //7. nullable int?a = null;
            /*
            int? num1 = null;
            Console.WriteLine(num1.HasValue);

          
            if (num1 != null)
                Console.WriteLine(num1.Value);
            num1 = 150;
            Console.WriteLine(num1.HasValue);
            Console.WriteLine(num1.Value);
            */
            //8. 강제 형변환으로 인한 데이터 손실
            /*
            float f1 = 68.7512f;
            Console.WriteLine("float : {0}",f1);
            double d1 = (double)f1;
            Console.WriteLine("double : {0}", d1);

            double d2 = 68.7512f;
            Console.WriteLine("double : {0}", d2);
            float f2 = (float)d2;
            Console.WriteLine("float : {0}", f2);
            */
            //9. 데이터 변환 (문자열->숫자, 숫자->문자열)
            /*
            int value1 = 127;
            string  str1 = value1.ToString();
            Console.WriteLine("value1의 문자열로 바꼈는지 확인 = {0}",str1+1);

            int value2 = Convert.ToInt32(str1);
            Console.WriteLine("str1의 값이 정수로 바꼈는지 확인 = {0}", value2 + 1);

            string str2 = "3.14";
            float value3 = float.Parse(str2);
            Console.WriteLine("value2의 실수로 바꼈는지 확인 = {0}", value3 + 1);
            */
            /*
            Console.WriteLine(int.Parse("52").GetType()); // 타입에 맞게 변환하라
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            Console.WriteLine(int.Parse("52.273")); //변환이 안되는경우
            Console.WriteLine(long.Parse("abc"));
            */
            /*
            Console.WriteLine(bool.Parse("false"));  //bool은 true false만 받는다.
            Console.WriteLine(bool.Parse("string")); //다른 문자는 오류가 생긴다.
            */

            /*
        }
    }
}
            */
