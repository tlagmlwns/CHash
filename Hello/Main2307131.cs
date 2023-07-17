/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{

    //7장 - 데이터의 은닉과 캡슐화
    /*
    class WaterHeater 
    {
        protected int temp; 
        public void setTemp(int temp)
        {
            if(temp < 10 || 42 < temp)
            {
                Console.WriteLine("10 ~ 42도 사이의 온도값을 입력 : ");
                Console.WriteLine("물의 온도는 15도로 리셋");
                this.temp = 15;
                return;
            }
            this.temp = temp;
        }
        public void turnOW()
        {
            Console.WriteLine($"Turn on water : {temp}");
        }
    }*/
/*
    internal class Main2307131
    {
        static void Main(string[] args)
        {
            //6장
            //반복문 사용해서 길이재기
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
            //원하는 크기의 배열생성
            /*
            int[] arr = new int[100];
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[99]);
            */
            //이차원 및 다차원 배열
            /*
            int[,] nArray = new int[2, 2];
            nArray[0, 0] = 1;
            nArray[0, 1] = 2;
            nArray[1, 0] = 3;
            nArray[1, 1] = 4;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] nArray2 = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray2[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            string[,,] stArray = { { {"a", "b"
                }, { "c", "d"
                },
                { "e", "f"
                }, { "g", "h"
                }
            }};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                        Console.Write(stArray[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */
            //가변배열 연습
            /*
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array.Length);
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]+" ");
                Console.WriteLine();
            */
            //배열의 매서드
            /*
            int[] arr1 = { 1, 2, 3, 4, 5 };
            Array.Clear(arr1, 2, 3);

            foreach (int i in arr1)
                Console.WriteLine(i);
            Console.WriteLine();

            Array.Clear(arr1, 0, arr1.Length);
            foreach (int i in arr1)
                Console.WriteLine(i);
            Console.WriteLine();
            */
            /*
            int[] scores = new int[] { 80, 71, 81, 90, 34 };
            foreach (int score in scores)
                Console.WriteLine($"{scores}");
            Console.WriteLine();

            Array.Sort(scores);
            foreach (int score in scores) Console.Write($"{scores}");
            Console.WriteLine();

            Console.WriteLine("Num of dimensions : {0}", scores.Rank);
            Console.WriteLine("Binary Scarch : 90 is at {0}", 
                Array.BinarySearch(scores,81));
            Console.WriteLine("Linear Scarch : 90 is at {0}",
                Array.IndexOf(scores, 90));
            Console.WriteLine("Old lenght of score : {0}",scores.GetLength(0));
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine("New lenght of score : {0}", scores.Length);
            */

            //7장
            //데이터의 은닉과 캡슐화
            /*
            WaterHeater h = new WaterHeater();
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("온도 입력 : ");
                String a = Console.ReadLine();
                h.setTemp(int.Parse(a));
                h.turnOW();
            }
            */
         /*  
        }
    }
}
         */