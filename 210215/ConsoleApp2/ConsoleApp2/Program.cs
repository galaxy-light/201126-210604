using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // https://blog.naver.com/hack4ork/221671058863
    // https://blog.naver.com/hack4ork/221671486484
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

            ArrayTest1 at1 = new ArrayTest1(arr); // 생성자 안에서 처리를 다 했기 때문에 굳이 at1 필요 없음
            ArrayTest1 at2 = new ArrayTest1(); // 이미 사용자가 매개변수가 있는 생성자를 만들었기 때문에 프로그램에서 경고를 줌 -> 해결하기 위해 기본 생성자 추가
            at2.SumAvg(arr);

            Console.WriteLine();
            ArrayTest1 at3 = new ArrayTest1(); // 배열 정보가 없기 때문에 결과값이 출력 안됨 -> 해결하기 위해 set을 써서 배열 정보를 주어야 함
            at3.setArray(arr);
            at3.SumAvg();

            new ArrayTest1(arr); // 재사용 불가

            // 이차원 배열
            int[,] arr2 = new int [5, 3]
            {
                { 100, 90, 80 },
                { 90, 90, 80},
                { 70, 80, 90 },
                { 80, 70, 90 },
                { 80, 80, 80 }
            };
            /* StudentScore st = new StudentScore(arr2[0,0], arr2[0,1], arr2[0,2]);
            st.calculator();

            StudentScore[] arrSt = new StudentScore[5]; // 비어있는 배열 공간 생성
            for (int i = 0; i < 5; i++)
            {
                new StudentScore(arr2[0, 0], arr2[0, 1], arr2[0, 2]).calculator();
            }*/

            StudentScore[] arrSt = new StudentScore[5];
            for (int i = 0; i < 5; i++)
            {
                arrSt[i] = new StudentScore(); // 비어있는 객체 생성
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        arrSt[i].Kor = arr2[i, j];
                    }
                    else if (j == 1)
                    {
                        arrSt[i].Eng = arr2[i, j];
                    }
                    else if (j == 2)
                    {
                        arrSt[i].Mat = arr2[i, j];
                    }                    
                    
                }
                arrSt[i].calculator();
            }
        }
    }
}
