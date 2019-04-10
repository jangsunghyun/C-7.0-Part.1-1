using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //연산자
            int a = 100 + 200;
            Console.WriteLine(a);

            int mod = 13 % 2;
            Console.WriteLine(mod);

            int aa = 10;

            Console.WriteLine(aa++);
            Console.WriteLine(++aa);

            Console.WriteLine(aa--);
            Console.WriteLine(--aa);

            bool res;
            res = 10 > 100;
            res = 100 == 100;
            res = 11 != 20;
            Console.WriteLine(res);
        }
    }
}
