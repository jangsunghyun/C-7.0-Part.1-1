using System;

namespace ClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Person person = new Person();
            Person person1 = new Person();
            person.name = "홍길동";     
            person.gender = "남";

            person.greet();

            person1.name = "홍길순";
            person1.gender = "여";
            person1.greet();

        }
    }

    class Person  //설계도를 ... 객체화 인스턴스화..  메모리에 올린다. 실행시킨다.
    {
        public string name; //속성
        public string gender; //속성

        public void greet() //메소드
        {

            Console.WriteLine("안녕하세요! 저는 {0} 입니다.", name);
        }
    }
}
