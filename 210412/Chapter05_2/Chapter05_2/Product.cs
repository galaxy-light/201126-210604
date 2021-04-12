using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_2
{
    class Product
    {
        // 인스턴스 변수 : 인스턴스마다 값이 다를 수 있음 / 선언을 할 때 메모리에 할당 됨
        // 클래스 변수 : 프로그램이 실행될 때 메모리에 할당 됨(인스턴스 변수보다 우선으로 할당(인스턴스 변수는 선언할 때 할당되니까))        
        public string name; // static이 없다면 인스턴스 변수
        public int price; // static이 없다면 인스턴스 변수
        public static int count; // static : 클래스 변수(정적 변수)
    }
}
