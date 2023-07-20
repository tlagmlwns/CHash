using System;

namespace pratice4
{
    internal class Program
    {
        interface IRunnable
        {
            void Run();
        }
        interface IFlyable
        {
            void Fly();
        }
        class FlyCar : IRunnable, IFlyable
        {
            public void Run() { Console.WriteLine("Run~Run~"); }
            public void Fly() { Console.WriteLine("Fly! Fly!"); }
        }
        static void Main(string[] args)
        {
            FlyCar car = new FlyCar();
            car.Run();
            car.Fly();

            //IRunnable runnable = ((IRunnable)car);
            //IFlyable flyable = ((IFlyable)car);
            IRunnable runnable = car as IRunnable;
            IFlyable flyable = car as IFlyable;
            runnable.Run();
            flyable.Fly();
            //((IRunnable)car).Run();
            //((IFlyable)car).Fly();
        }
    }
}
