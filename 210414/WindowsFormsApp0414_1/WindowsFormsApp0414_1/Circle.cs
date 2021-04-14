using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp0414_1
{
    class Circle
    {
        public int r; // 인스턴스 변수
        public static double PI = 3.1415; // 클래스 변수

        public double grith()
        {
            return this.r * PI * 2; // this : 변수 선언의 r인지 매개변수의 r인지 확인하기 위해 씀
        }

        public double area()
        {
            return this.r * this.r * PI;
        }

        public static void setPi(double pi)
        {
            PI = pi;
        }

        public static double getPi()
        {
            return PI;
        }

        public static void showPi()
        {
            System.Windows.Forms.MessageBox.Show("현재 PI값은 " + PI + "입니다.");
        }
    }
}
