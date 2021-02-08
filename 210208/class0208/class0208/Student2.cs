using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0208 // main과 같은 namespace
{
    class Student2
    {
        // 인스턴스 변수(속성)
        private string name;
        private string tel;

        // 클래스 변수 : 인스턴스 변수와 다른 공간에 존재함
        // public const string CLASS : public static final CLASS와 동일
        // const -> 클래스 상수 변수
        public const string CLASS = "Java, C# 응용프로그램 개발자"; // 공용으로 사용하기 위해 public

        // 객체 생성 오류 해결을 위해 기본 생성자 추가 -> 오버로딩(중복 정의)
        public Student2()
        {
            name = "박길동"; // 초기화
            tel = "010-1111-1111"; // 초기화
        }

        // 매개 변수가 존재하는 기본 생성자
        public Student2(string name, string tel)
        {
            this.name = name;
            this.tel = tel;
        }

        // propfull 입력하고 tab 두 번
        public string Name // 특수한 메서드
        { 
            get { return name; } // getter
            set { name = value; } // setter / 메인의 이길동이 value로 들어옴 = tel
        }        

        public string Tel // 특수한 메서드
        {
            get { return tel; } // getter
            set { tel = value; } // setter / 메인의 010-9876-5432이 value로 들어옴 = tel
        }
        
        public void printStudentInfo()
        {
            Console.WriteLine("과정명 : " + Student2.CLASS);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 : " + tel);
        }
    }
}
