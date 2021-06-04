using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descript_Function
{
    class Circle
    {
        public int r; //인스턴스 변수
        public static double PI = 3.1415; //클래스 변수

        public double doolle() //인스턴스 함수
        {
            return this.r * PI * 2;
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
            System.Windows.Forms.MessageBox.Show("현재 PI값은"+PI+"입니다");
        }
    }
}
