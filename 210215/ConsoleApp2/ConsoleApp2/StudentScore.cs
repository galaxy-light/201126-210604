using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StudentScore
    {
        // 추상화
        private int kor;
        private int eng;
        private int mat;
        private int sum;
        private int avg;
        private char result;

        // 외부에서 정보를 받는 생성자
        public StudentScore(int kor, int eng, int mat)
        {
            this.kor = kor;
            this.eng = eng;
            this.mat = mat;
        }

        public StudentScore()
        {
            
        }


        public int Kor { get => kor; set => kor = value; }
        public int Eng { get => eng; set => eng = value; }
        public int Mat { get => mat; set => mat = value; }
        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }
        public char Result { get => result; set => result = value; }

        public void calculator()
        {
            sum = kor + eng + mat;
            avg = sum / 3;
            if (avg >= 90 && avg <= 100)
            {
                result = 'A';                
            }
            else if (avg >= 80 && avg <= 89)
            {
                result = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                result = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                result = 'D';
            }
            else 
            {
                result = 'F';
            }

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + avg);
            Console.WriteLine("학점 : " + result);
            Console.WriteLine("------------------");
        }
    }
}
