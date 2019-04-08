using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable 선언할때는 "?" 를 이요한다.
            // 형식은 다음과 같다. 
            // 데이터 형식 ? 변수명 ;
            int? a = null;
            int? b = null;
            int? c = null;

            // 위의 변수들은 null로 초기화한 변수들, 값이 없는 비워둔 변수들이다.

            //int a;는 a 가 null값을 갖는다는 의미가 아니다.

            //nullable 타입은 HasValue(값이 있는지 없는지)와 Value(실제 값) 속성을 가지고 있다. 
            Console.WriteLine(a);
            Console.WriteLine(a.HasValue);

            a = 200;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.Value);

            Console.WriteLine(a != null);

        }
    }
}
