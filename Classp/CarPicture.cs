using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Classp
{
    internal class CarPicture
    {
        private int car_w;
        private int car_h;
        public string car_n;
        public Color color;

        public CarPicture()
        {
            car_w = 200;
            car_h = 140;
            car_n = "car";
            color = Color.DarkBlue;
        }
        public CarPicture(int car_w, int car_h, string car_n, Color color)
        {
            this.car_w = car_w;
            this.car_h = car_h;
            this.car_n = car_n;
            this.color = color;
        }
        public int Width
        {
            get { return this.car_w; }
            set { if (value > 0) this.car_w = value; }
        }
        public int Height
        {
            get { return this.car_h; }
            set { if (value > 0) this.car_h = value; }
        }
        public int d {get { return (car_w + car_h) * 2; }}
        public int area {get { return car_w * car_h; }}
        public void MakeCar() 
        {
            if (ProcessStarted != null) ProcessStarted(this,EventArgs.Empty);
            Step1(); Step2(); Step3();
            if (ProcessEnd != null) ProcessEnd(this,EventArgs.Empty);
        }
        public void Step1() { Console.WriteLine("Step #1"); }
        public void Step2() { Console.WriteLine("Step #2"); }
        public void Step3() { Console.WriteLine("Step #3"); }
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessEnd;
    }
}
