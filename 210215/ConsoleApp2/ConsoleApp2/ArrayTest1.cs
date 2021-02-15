using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArrayTest1
    {
        private int sum;
        private int avg;
        // int[] arr = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}; -> 클래스 안에 정의하지 않는 이유는 변하는 값이기 때문(변하는 정보는 외부에서 주면 됨)
        private int[] arr;

        public ArrayTest1(int[] arr)
        {
            /* for (int i = 0; i < arr.Length; i++)
             {
                 sum += arr[i];
             }
             avg = sum / arr.Length;
             Console.WriteLine("총점 : " + sum);
             Console.WriteLine("평균 : " + avg);
            */

            SumAvg(arr); // SumAvg 메서드 호출
        }

        // 오버로딩(중복정의)
        public ArrayTest1() // 기본 생성자
        {
            
        }

        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }

        public void SumAvg(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + avg);
        }

        public void setArray(int[] arr)
        {
            this.arr = arr; // 외부 정보를 인스턴스 정보로 받아들임
        }

        // SumAvg 오버로딩
        // SumAvg 메서드를 사용하기 위해서는 
        public void SumAvg()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + avg);
        }
    }
}
