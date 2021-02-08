using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTest0208_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 초기화1
            // 배열의 이름은 배열이 시작하는 주소값(위치값)
            int[] arrInt = { 10, 20, 30, 40 }; // 타입 뒤에 []
            for (int i = 0; i < arrInt.Length; i++)
            {
                // 자바의 System.out.println()
                Console.WriteLine(arrInt[i] + " "); // 콘솔에 출력
                // string -> s 소문자 사용
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]); // i -> 0에 대입 / arrInt[i] -> 1에 대입 (자바의 %d와 동일한 의미)
                Console.WriteLine(str);
            }

            // 1차원 배열 초기화2
            char[] arrCh = new char[4] { '이', '김', '박', '홍' }; // new : 객체 생성
            for (int i = 0; i < arrCh.Length; i++)
            {
                // 자바의 System.out.print()
                Console.Write(arrCh[i] + " ");
            }

            Console.WriteLine();
            // 2차원 배열 초기화1 -> 2차원 배열은 이중루프를 반드시 사용
            int[,] arrInt2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // 2행 3열 / int[,] : 2차원 배열 -> int[][]과 동일한 의미
            for (int i = 0; i < 2; i++) // 행
            {
                for (int j = 0; j < 3; j++) // 열
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // 2차원 배열 초기화2 
            // const : 변할 수 없는 상수 변수 (자바의 final과 동일한 의미)
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt2_1 = new int[SIZE_ROW, SIZE_COL] { { 1, 2, 3 }, { 4, 5, 6 } }; // 2행 3열
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arrInt2_1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // 2차원 배열 초기화3
            string[][] arrStr1 = new string[2][]; // 열의 크기 명시X
            arrStr1[0] = new string[] { "김길동", "홍길동", "박길동" }; // 2차원 배열의 1행
            arrStr1[1] = new string[] { "이길동" }; // 2차원 배열의 2행 -> 정의함으로써 열의 크기가 자동으로 정의됨
            for (int i = 0; i < arrStr1.Length; i++) // 행
            {
                for (int j = 0; j < arrStr1[i].Length; j++) // 행에 대한 열의 for문
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // 2차원 배열 초기화4
            int[][] arrInt2_2 = new int[3][]; // 선언함으로써 0으로 초기화가 됨
            for (int i = 0; i < arrInt2_2.Length; i++)
            {
                arrInt2_2[i] = new int[i + 1]; // 열의 크기가 명시되어 있지 않기 때문에 작성함 // 63, 64라인 참고
                for (int j = 0; j < arrInt2_2[i].Length; j++)
                {
                    arrInt2_2[i][j] = 10 + j;
                    Console.Write(arrInt2_2[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // foreach(향상된 for문) 1차원 배열
            int[] arrEach1 = { 1, 2, 3, 4, 5 };
            // 자바 -> for (int i : arrEach1)
            foreach (int i in arrEach1) // C#
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            // foreach(향상된 for문) 2차원 배열
            // 이중루프를 하지 않았기 때문에 콘솔창에 한 줄로 출력됨
            string[,] arrEach2 = { { "홍길동", "김길동" }, { "hong", "kim" } }; // 2행 2열
            foreach (string str in arrEach2)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
