﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Value Type 과 Reference Type

                Value type(값 형식) : 변수가 값을 담는 데이터 형식
                Reference Type(참조 형식) : 변수가 실제 값대신에 그 값이 있는 곳의 위치를 담는 데이터 형식

                - 메모리 영역 : 스택(Stack), 힙(Heap)

                - 값 형식과 관련 있는 메모리 영역은 스택(Stack)메모리 영역 - 스스로 메모리 영역 제거 됨. {} 프로그램 구문 사용끝나면 
                - 참조형식과 관련있는 메모리 영역은 힙(Heap) 메모리 영역 - 가베지 컬랙터를 이용해서.. 제거.. 
                - 참조 형식은 힙과 스택을 함계 이용한다.
                    - Heap 영역에는 실제 데이터를 저장하고
                    - Stack 영역에는 실제 데이터가 저장되어 있는 Heap의 메모리 주소가 저장된다.
            
                [ object 형식 ]            
                - C#은 모든 데이터를 다룰수 있는 object 형식을 제공하고 있다.
                - C# 컴파일러는 어떤 형식의 데이터라도 object 형식에 담아 처리할수 있다.

             */

            object obj1 = 111;
            object obj2 = 3.141212121212m;
            object obj3 = true;
            object obj4 = "hi C#!!!";

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);
            Console.ReadKey();

             
        }
    }
}
