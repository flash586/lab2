using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace lab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.Y_3();
            matrix.b_();
            matrix.y1_();
            matrix.y2_();
   
            Thread first = new Thread(new ThreadStart(matrix.first_));
            Thread second = new Thread(new ThreadStart(matrix.second_));
            Thread third = new Thread(new ThreadStart(matrix.third_));
            Thread fourth = new Thread(new ThreadStart(matrix.fourth_));
            Thread fifth = new Thread(new ThreadStart(matrix.fifth_));
            first.Start();
            first.Join();
            second.Start();
            second.Join();
            third.Start();
            third.Join();
            fourth.Start();
            fourth.Join();
            fifth.Start();
            fifth.Join();
            Thread x = new Thread(new ThreadStart(matrix.x));
            x.Start();
            x.Join();
            matrix.Output();
            Console.ReadKey();
        }
    }
}
