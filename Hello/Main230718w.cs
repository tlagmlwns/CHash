
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    //1.
    /*
    class Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
        public virtual void Bark() { } //가상에서 정의
        public virtual void Meow() { } //가상에서 정의
    }
        class Dog : Animal
    {
        public override void Bark() //자식메서드에서 오버라이드되어 재 정의
        {
            base.Color = "노란"; Console.WriteLine("워뤙ㄹ"); Console.WriteLine("Dog 클래스 호출");
        }
    }
    class Cat : Animal
    {
        public override void Meow() //자식메서드에서 오버라이드되어 재 정의
        { 
            base.Color = "하얀"; Console.WriteLine("낭낭"); Console.WriteLine("Cat 클래스 호출"); 
        }
    }*/

    //2. is
    /*
    class Animal
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Animal() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
    }
    class Dog : Animal
    {
        public void Bark() //자식메서드에서 오버라이드되어 재 정의
        {
            base.Color = "노란"; Console.WriteLine("워뤙ㄹ");
        }
    }
    class Cat : Animal
    {
        public void Meow() //자식메서드에서 오버라이드되어 재 정의
        {
            base.Color = "하얀"; Console.WriteLine("냥냥냥"); 
        }
    }*/

    //as
    class Mammal{public void Nurse() {Console.WriteLine("Nurse()");}}
    class Dog : Mammal { public void Bark() { Console.WriteLine("Bark()"); } }
    class Cat : Mammal { public void Meow() { Console.WriteLine("Meow()"); } }
    internal class Main230718w
    {
        static void Main(string[] args)
        {
            //1
            /*
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            int count = 0;
            foreach (var item in Dogs) { count++; item.Eat(); item.Sleep(); item.Bark(); }
            Console.WriteLine("Dogs 호출 반복횟수 : " + count);
            count = 0;
            foreach (var item in Cats) { count++; item.Eat(); item.Sleep(); item.Meow(); }
            Console.WriteLine("Cats 호출 반복횟수 : " + count);
            */

            /*
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();
            dog.Bark();
            dog.Age++;
            Console.WriteLine("강아지의 나이는 " + dog.Age + "살");
            Console.WriteLine("강아지의 색갈은 " + dog.Color + "색\n");
            
            Cat cat = new Cat();
            cat.Eat();
            cat.Sleep();
            cat.Meow();
            cat.Age++;
            Console.WriteLine("고양이의 나이는 " + cat.Age + "살");
            Console.WriteLine("고양이의 나이는 " + cat.Color + "색");
            */

            /*
            List<Animal> Animal = new List<Animal>()
            { new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat(), new Dog(), new Cat()};
            foreach (var item in Animal)
            {
                item.Eat();
                item.Sleep();
                item.Bark(); //Ainmal에 정의 되어있지 않고 Dog에 있는 자식클래스에 정의 되어있으므로 사용x 
                item.Meow(); //Ainmal에 정의 되어있지 않고 Cat에 있는 자식클래스에 정의 되어있으므로 사용x
            }*/

            //2. is 연산자
            /*
            List<Animal> Animals = new List<Animal>()
            { new Dog(), new Cat(), new Dog(), new Cat(), 
                new Dog(), new Cat(), new Dog(), new Cat()};

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                if(item is Dog) { ((Dog)item).Bark();}
                if(item is Cat) { ((Cat)item).Meow();}
                Console.WriteLine();
            }*/

            //as 연산자
            Mammal mammal1 = new Dog();
            Mammal mammal2 = new Cat();

            Dog dog;
            if(mammal1 is Dog) { dog = (Dog)mammal1; dog.Bark(); }

            Cat cat = mammal2 as Cat;
            if(cat is not null) { cat.Meow(); }

            Cat cat2 = mammal1 as Cat;
            if (cat2 != null) { cat2.Meow(); }
            else Console.WriteLine("cat2 is null");
        }
    }
}
