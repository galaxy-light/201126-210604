using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0208_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;

            Console.Write("국어 점수 : ");
            kor = Convert.ToInt32(Console.ReadLine());
            if (kor > 0)
            {
                Console.WriteLine("국어 : " + kor);
            }
            else if (kor < 0)
            {
                Console.WriteLine("잘못된 입력");
                return;
            }

            Console.Write("영어 점수 : ");
            eng = Convert.ToInt32(Console.ReadLine());
            if (eng > 0)
            {
                Console.WriteLine("영어 : " + eng);
            }
            else if (eng < 0)
            {
                Console.WriteLine("잘못된 입력");
                return;
            }

            Console.Write("수학 점수 : ");
            mat = Convert.ToInt32(Console.ReadLine());
            if (mat > 0)
            {
                Console.WriteLine("수학 : " + mat);
            }
            else if (mat < 0)
            {
                Console.WriteLine("잘못된 입력");
                return;
            }

            StudentScore str = new StudentScore();
            str.Result();
        }
    }

    class StudentScore
    {           
        private int sum;
        private double avg;

        public StudentScore(int kor, int eng, int mat)
        {
            this.kor = kor;
            this.eng = eng;
            this.mat = sum;
        }       

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public double Avg
        {
            get { return avg; }
            set { avg = value; }
        }

        public void Result()
        {
            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + avg);
        }
    }
}
