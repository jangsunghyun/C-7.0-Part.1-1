using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             부동 소수점과 정수형 사이의 형변환

             */
            //float f = 4.7234f;
            //int aa = (int)f;

            //Console.WriteLine(aa);

            //*****문자열과 숫자 사이의 형변환

            int aa = 343434;
            string bb = aa.ToString();

            float ff = 12121.1212f;
            string cc = ff.ToString();
            Console.WriteLine(cc);

            string strl = "121212";
            int aaa = int.Parse(strl);
            Console.WriteLine(aaa);

            string str2 = "1.123456";
            float h = float.Parse(str2);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
