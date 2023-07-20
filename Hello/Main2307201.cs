
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    //1
    class Myclass
    {
        private string name;
        public string Myname 
        { 
            get { return name; } //get만 있으면 읽기전용
            set
            { /*{ name = value; }*//*
                if (value.Length > 4) Console.WriteLine("이름 4자 넘기 불가능");
                else name = value;
            } // end of set
        } // end of Name
        public Myclass(string name) { this.Myname = name; }
        public Myclass() { }
    }
    internal class Main2307201
    {
        static void Main(string[] args)
        {
            //1
            Myclass student = new Myclass("홍길동"); //getset있는경우
            Console.WriteLine(student.Myname); 

            Myclass student2 = new Myclass();
            //student.Myname = "qwertyop";
            Console.WriteLine(student2.Myname);
        }
    }
}
*/