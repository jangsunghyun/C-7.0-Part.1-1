using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             부호 있는 정수형과 부호 없는 정수형 사이의 형변환
             byte(부호가 없는),sbyte(부호가 있는)
             
            int uint, short ushort, long ulong
            short(부호가 있는)
            unshort(부호가 없는..)
             */

            //byte bb = 255;

            //sbyte sb = (sbyte)bb;

            //Console.WriteLine(bb);
            //Console.WriteLine(sb);

            

            int ia = 600;
            Console.WriteLine(ia);

            uint ua = (uint)ia;
            Console.WriteLine(ua);

            int iaa = -40;
            Console.WriteLine(iaa);

            uint uaa = (uint)iaa;
            Console.WriteLine(uaa);

            Console.ReadKey();

        }
    }
}
