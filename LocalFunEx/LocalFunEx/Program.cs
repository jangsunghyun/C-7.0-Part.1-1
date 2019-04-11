using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunEx
{
    class Program
    {
        static string ToLowerStr(string str)
        {
            var arr = str.ToCharArray(); //ToCharArray 함수 class 안에 있는 메소드.

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
                
            }

            return new string (arr);
        }

        static void Main(string[] args)
        {
            //var 키워드 : 데이터 형식을 알아서 c# 컴파일러 가 지정한다.

            var a = "Hello";
            Console.WriteLine(a.GetType());

            var aa = 100;
            Console.WriteLine(aa.GetType());

            var f = 3.12121;
            Console.WriteLine(f.GetType());

            var arr = new int[] { 1, 2, 3 };
            Console.WriteLine(arr.GetType());

            // 로컬 함수 : 메소드 안에서 선언된 특별한 함수, 메소드 안에서 선언되었기
            //             때문에 클랙스 멤버가 아니다. 따라서 함수라고 부른다.

            Console.WriteLine(ToLowerStr("Good"));
            Console.WriteLine(ToLowerStr("MORNING"));
             
        }
    }
}
