using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPj
{
    class Program
    {
        static void Main(string[] args)
        {

            // c# 컴파일러는 int, double, char, string, bool 데이터 타입에 
            // 그에 해당하는 값을 할당한다.
            // 데이터 타입별 접미사(suffix)를 사용해서 특정 데이터 타입을 지정할수 있다.
            // [접미어]
            // L : long, U: Unit, UL : ULong, F: float, D: double, M:decimal

            long l = 12322L;  //L을 넣는 것은 Long형이라고 정의 Long형으로 데이터값 들어간다.
            int aa = int.MaxValue; //int형의 최대값을 알수 있다.

            long bb_ = long.MinValue;
            long bb = long.MaxValue;

            float f = float.MinValue;
            float f_ = float.MaxValue;

            Console.Write(f+ " ~ " + f_);
            Console.ReadKey(); 
        }
    }
}
