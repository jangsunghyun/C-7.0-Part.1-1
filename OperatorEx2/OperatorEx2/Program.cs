using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //논리연산자
            Console.WriteLine("----------------AND-----------------------");
            Console.WriteLine(10 > 5 && 10 < 100);
            Console.WriteLine(10 > 5 && 10 < 5);

            // !(Not 연산자)
            Console.WriteLine("----------------Not-----------------------");
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //조건 연산자 ?
            // 조건식 ? 참일때 값 : 거짓일때 값
            String str = (100 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(str);


        }
    }
}
