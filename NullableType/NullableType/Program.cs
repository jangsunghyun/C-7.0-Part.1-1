using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            // null; 대소문자 구분없이 사용..
            // 즉, 메모리상에 어떤 데이터도 갖고 있지 않을때 사용하는 키워드

            // null을 가질 수 있는 데이터 타입(Reference 타입)이 있는데, 대표적으로 string 타입은 
            // null을 가질수 있는 타입이다.
            // null을 가질수 없는 타입은 Value 타입(int, DateTime..)


            // 정수(int)나 날짜 (DateTime)같은 Value Type은 일반적으로 Null을 가질수 없다.
            //  Nullable 형식을 적용하면 정수 같은 Value Type 도 null 값을 가질수 있다.
            // 즉, 값이 비어있는 Nullable Type 의 변수를 선언 할 수 있다.

            // Nullable 선언 할때는 "?"를 이용한다.
            // 형식은 다음과 같다.
            // 데이터 형식? 변수 이름;

            int? a=null;
            int? b = null;
            int? c = null;
            // 위의 변수들은 null로 초기화 한 변수들, 값이 없는 비워둔 변수들이다.
            // int a;는 a가 null값을 갖는다는 의미가 아니다.

            // nullable 타입은 HasValue와 Value 속성을 가지고 있다.
            // HasValue : 해당변수가 값을 갖고있냐 갖고있지 않느냐를 알려주는 속성
            // Value : 해당변수의 값을 나타내는 속성
            


            Console.WriteLine(a);
            Console.WriteLine(a.HasValue);

            a = 200;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.Value);

            Console.Write(a != null);
            Console.WriteLine(b != null);
            string strl;
            strl = null;
            Console.Write(strl);
            Console.ReadKey();
        }
    }
}
