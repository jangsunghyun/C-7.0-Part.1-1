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
        }
    }
}
