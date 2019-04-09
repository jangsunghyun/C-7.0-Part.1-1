using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContantsEx
{
    class Program
    {
        enum City { Seoul = 02, Incheon = 032, Daegu, Daejeon }

        static void Main(string[] args)
        {
            //변수 : 담고 있는 데이터를 얼마든지 변경할수 있기 메모리 공간
            //상수 : 담고 있는 데이터를 절대 바꿀수 없다.

            // 상수는 const 라고 하는 키워드를 사용한다.
            // 선언 형식 ---> const type 명 상수명;

            //const int AAA = 10000;
            //Console.WriteLine(AAA);

            // enum은 열거형 상수 (constant)를 표현하기 위한것
            // 선언 형식 :
            // enum 열거형식명 : 자료명 {상수1,상수2 }
            // 위에 자료형은 정수형 자료형만 사용된다
            // 정수형 자료형(byte, sbyte, short, ushort,int, unit, long, unlong, char)
            // 자료형을 생략해서 사용하는 경우가 많은데 생략했을 경우에는 int형으로  설정이 된다.

            // enum City {seoul, incheon, Daegu }
            // 열거형식 안에 선언된 상수들이 어떤 값도 할당 되지 않았을 경우에는 첫번째
            // 상수 요소에는 0이 할당된다, 그리고 그 다음 요소에는 1, 그다음 요소에는 2
            //컴파일러가 자동으로 1씩 추가해서 할당한다.

            Console.WriteLine((int)City.Seoul);
            Console.WriteLine((int)City.Incheon);
            Console.WriteLine((int)City.Daegu );
            Console.WriteLine((int)City.Daejeon);

            City sel = City.Seoul;

            Console.WriteLine(sel == City.Seoul);
            Console.WriteLine(sel == City.Daejeon);

            Console.ReadKey();
        }
    }
}
