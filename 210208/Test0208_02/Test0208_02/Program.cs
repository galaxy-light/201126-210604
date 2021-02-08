using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0208_02
{
    // https://blog.naver.com/hack4ork/221671058863
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Array ar = new Array(arr);
            ar.Result();
        }
    }

    class Array
    {
        private int sum;
        private int avg;

        public Array(int[] arr)
        {
            sum = 0;
            avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
        }
              
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public int Avg
        {
            get { return avg; }
            set { avg = value; }
        }

        public void Result()
        {
            Console.WriteLine("배열의 합 : " + sum);
            Console.WriteLine("배열의 평균 : " + avg);
        }       
    }
}
