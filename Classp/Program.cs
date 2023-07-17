using System;
using System.Drawing;

namespace Classp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarPicture carpicture = new CarPicture(); //클래스
            Console.WriteLine("속성을 지정해 초기화되어 있는 첫번째 생성자에서의 출력");
            Console.WriteLine("{0} : {1}", "자동차의 길이", carpicture.Width);
            Console.WriteLine("자동차의 높이 : " + carpicture.Height);
            Console.WriteLine("자동차의 이름 : " + carpicture.car_n);
            Console.WriteLine("자동차의 색깔 : " + carpicture.color);

            Console.WriteLine();
            Console.WriteLine("set을 통해  속성에 값 입력");
            carpicture.Width = 300;
            carpicture.Height = 200;
            Console.WriteLine("{0} : {1}", "자동차의 길이", carpicture.Width);
            Console.WriteLine("자동차의 높이 : " + carpicture.Height);
            Console.WriteLine("자동차의 이름 : " + carpicture.car_n);
            Console.WriteLine("자동차의 색깔 : " + carpicture.color);

            Console.WriteLine();
            Console.WriteLine("4개의 파라미터를 갖는 생성자의 필드 출력");
            CarPicture cp = new CarPicture(299, 199, "horse", Color.Brown); //구조체
            Console.WriteLine("{0} : {1}", "자동차의 길이", cp.Width);
            Console.WriteLine("자동차의 높이 : " + cp.Height);
            Console.WriteLine("자동차의 이름 : " + cp.car_n);
            Console.WriteLine("자동차의 색깔 : " + cp.color);

            Console.WriteLine();
            Console.WriteLine("계산하는 속성 추가");
            Console.WriteLine("자동차의 둘레 : " + cp.d);
            Console.WriteLine("자동차의 면적 : " + cp.area);

            Console.WriteLine();
            Console.WriteLine("메서드 호출");
            cp.MakeCar();

            Console.WriteLine();
            Console.WriteLine("이벤트 호출");
            cp.ProcessStarted += Cp_ProcessStarted;
            cp.ProcessEnd += Cp_ProcessEnd;
            cp.MakeCar();
        }

        private static void Cp_ProcessEnd(object sender, EventArgs e)
        {
            Console.WriteLine("Process End");
        }

        private static void Cp_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Started");
        }
    }
}
