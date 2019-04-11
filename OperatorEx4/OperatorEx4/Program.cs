using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            //비트연산자 (쉬프트 , &, |, ^)
            Console.WriteLine("-----------------쉬프트 연산 ----------------");

            int aa = 1, bb = 2, cc = 3;
            // 특정형식에 맞춰 출력하는 포맷팅 (Formatting) 기능
            //Console.WriteLine("aa:{0} bb:{1} cc:{2}", aa, bb, cc);

            //int a = 3;
            //Console.WriteLine("{0:D5}", a); //10진수 표기
            int a = 1;            
            Console.WriteLine("{0:D3} 0x{0:X8}", aa);  //16진수
            Console.WriteLine("{0:D3} 0x{0:x8}", a << 1); //
            Console.WriteLine("{0:D3} 0x{0:x8}", a << 5);

            Console.WriteLine();

            int b = 255;
            Console.WriteLine("{0:D3} 0x{0:x8}", b );
            Console.WriteLine("{0:D3} 0x{0:x8}", b >> 2);

            int c = -255;
            Console.WriteLine("{0:D3} 0x{0:x8}", c);
            //Console.WriteLine("{0:D3} 0x{0:x8}", c);
        }
    }
}
