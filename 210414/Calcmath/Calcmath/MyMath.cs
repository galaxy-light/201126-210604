using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcmath
{
    class MyMath
    {
        public int end; // 인스턴스 메서드를 위해 정의

        // 매개변수 input을 제곱해서 반환하는 함수
        public int Power(int input)
        {
            return input * input;
        }

        // 매개변수 input을 count만큼 제곱해서 반환하는 함수
        public static int Power(int input, int count)
        {
            int result = input;
            for (int i = 0; i < count-1; i++)
            {
                result *= input;
            }
            return result;
        }

        // 클래스 메서드로 쓰고 싶은 경우
        public static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        // 인스턴스 메서드로 쓰고 싶은 경우
        public int SumAll()
        {
            int sum = 0;
            for (int i = 0; i <= this.end; i++)
            {
                sum += i;
            }
            return sum;
        }

        private int abc; // 인스턴스 변수
        public int getAbc() // 인스턴스 메서드
        {
            return abc;
        }

        public void setAbc(int abc)
        {
            this.abc = abc;
        }
    }
}
