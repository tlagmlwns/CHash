/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Main2307182
    {*/
        /*a 오버라이팅하면 클래스형을 어떻게 변환해도 자식에서 
         * 다시 정의한(재정의) 매서드 호출할 수 있음. */
        /*
        class Wolf
        {
            public virtual void Bark()
            {
                Console.WriteLine("아우");
            }
        }
        class Dog : Wolf
        {
            public override void Bark()
            {
                Console.WriteLine("멍멍");
            }
        }
        */

        //b 부모타입의 참조변수로 자손 클래스의 객체를 호출
        /*
        class A { public virtual void print() { Console.WriteLine("흑백 인쇄"); } }
        class B : A
        {
            public override void print() { Console.WriteLine("컬러 인쇄"); } //같은 틀에 대해서만 가능하다
            public void fileOut() { Console.WriteLine("파일로 저장"); }
        }
        */

        //c 오버라이딩 : 부모 메서드가 아닌 자식 매서드를 사용하게됨
        /*
        class Animal
        {
            public virtual void Eat() { Console.WriteLine("냠냠"); }
        }
        class Dog : Animal
        {
            public override void Eat() { Console.WriteLine("강아지 사료"); }
        }
        class Cat : Animal
        {
            public override void Eat(){ Console.WriteLine("고양이 사료"); }
        }*/
        /*
        static void Main(string[] args)
        {*/
            //a
            /*
            Dog dog1 = new Dog();
            dog1.Bark();

            Wolf dog2 = new Wolf();
            dog2.Bark();

            Wolf dog3 = new Dog();
            dog3.Bark();
            */

            //b
            /*
            A out1 = new A();
            A out2 = new B();

            out1.print();
            out2.print();       
            //out2.fileOut();  //컴파일 에러 부모클래스에 fileOut() 없음

            ((B)out2).fileOut(); //자식형으로 형변환
            //((B)out1).fileOut(); //런타입 에러 발생 부모 인스턴스(객체)로 fileOut()없음
            */

            //c
            /*
            List<Animal> Animals = new List<Animal>()
            { new Dog(), new Cat(),new Dog(), new Cat(),
                new Dog(), new Cat(),new Dog(), new Cat() };
            foreach (var item in Animals) { item.Eat(); }
  */
            /*
            
        }
    }
}
            */