/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Main2307191
    {*/
        //하이딩 알아보기 클래스
        /*
        class Parent
        {
            public int var = 273;
            public void Method() { Console.WriteLine("부모의 매서드"); }
        }
        class Child : Parent
        {
            public new string var = "hiding";
            public new void Method() { Console.WriteLine("자식의 매서드"); }
        }*/

        //하이딩 알아보기 클래스2
        /*
        class Animal
        {
            public virtual void Eat() { Console.WriteLine("냠냠"); }
        }
        class Dog : Animal
        {
            public new void Eat() { Console.WriteLine("강아지 사료"); }
        }
        class Cat : Animal
        {
            public override void Eat() { Console.WriteLine("고양이 사료"); }
        }
        */

        //추상클래스
        /*
        abstract class SmartPhone
        {
            public abstract void network();
            public void callPhone() { Console.WriteLine("전화를 겁니다."); }
        }
        class ACcompany : SmartPhone
        {
            public override void network() { Console.WriteLine("5G 네트워트 사용"); }
        }*/

        // 함해보기
        /*
        abstract class Animal
        {
            public abstract void Eat();
            public abstract void Sleep();
        }
        class Dog : Animal 
        {
            public override void Eat() { Console.WriteLine("먹는 소리 : 우걱우걱"); }
            public override void Sleep() { Console.WriteLine("자는 소리 : zzz"); }
        }*/

/*
        static void Main(string[] args)
        {*/
            //하이딩 알아보기
            /*
            Child child = new Child();
            Console.WriteLine(child.var);
            Console.WriteLine(((Parent)child).var);
            child.Method();
            ((Parent)child).Method();
            */

            //하이딩 알아보기2
            /*
            List<Animal> Animals = new List<Animal>()
            { new Dog(), new Cat(),new Dog(), new Cat(),
                new Dog(), new Cat(),new Dog(), new Cat() };
            foreach (var item in Animals) { item.Eat(); }
            */

            //추상클래스는 인스턴스 생성이 안된다.
            /*
            //SmartPhone phone = new SmartPhone();
            SmartPhone phone1 = new ACcompany();
            phone1.network();
            phone1.callPhone();
            */
            
            // 함해보기
            /*
            Animal dog = new Dog();
            dog.Eat();
            dog.Sleep();
            */

/*
        }
    }
}
*/