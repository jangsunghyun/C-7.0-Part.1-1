using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //메소드 오버로딩 : 하나의 메소드 이름으로 여러개의 기능을 구현할수 있도록 하는 것. 매개변수 이름과 매개변수의 수,  매개변수 형식만 따진다.
            int a = sum(1, 2);
            int b = sum(1, 2, 3);
            double c = sum(1.1, 10);
            double d = sum(11,1.1);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static int sum(int i, int j)
        {
            Console.WriteLine("sum (int i , int j)메소드 호출하기");
            return i + j;
        }

        static int sum(int i, int j, int k)
        {
            Console.WriteLine("sum (int i, int j, int k) 메소드 호출하기");
            return i + j + k;
        }

        static double sum(double m, int n)
        {
            Console.WriteLine("sum (double m, int n) 메소드 호출하기");
            return m + n;
        }

        static double sum(int m, double n)
        {
            Console.WriteLine("sum (int m, double n) 메소드 호출하기");
            return m + n;
        }
    }
}
