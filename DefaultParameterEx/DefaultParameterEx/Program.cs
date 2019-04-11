using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파라미터에 기본값을 적용하기
            // void aaa(int a=0, int b=1){
            //  console.writeLine(a + b);
            //}
            // aaa(); 위 결과는 콘솔 화면에 1의 값이 출력이 된다

            MemberInfo("홍길동");
            MemberInfo("김말똥","인천");
            MemberInfo(name: "이말똥", addr: "광주");
            
        }

        static void MemberInfo(string name, string addr="")
        {
            Console.WriteLine("이름 : {0}, 주소 : {1} ", name, addr);
        }
    }
}
