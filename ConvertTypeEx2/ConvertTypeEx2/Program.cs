using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //부동 소수점 형식 사이의 형변환
            float f = 79.6777f;
            Console.WriteLine("f : {0}", f);

            Double d = (double)f;
            Console.WriteLine("d : {0}", d);

            double dd = 0.121212121212d;
            Console.WriteLine("dd : {0}", dd);

            float ff = (float)dd;
            Console.WriteLine("ff : {0}", ff);

            float x = 69.8575f;
            Console.WriteLine("x : {0}", x);

            double dx = (double)x;
            Console.WriteLine("dx : {0}", dx);
        }
    }
}
