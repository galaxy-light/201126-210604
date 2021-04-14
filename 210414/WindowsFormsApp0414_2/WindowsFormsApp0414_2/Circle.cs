using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp0414_2
{
    class Circle
    {
        private int r;
        public int R { get { return this.r; } set { this.r = value; } }

        public int radius { get; set; }
        // 참고로 그리드뷰할 때는 { get; set; } 없으면 안됨
        // public 변수 만들 땐 { get; set; }을 써주면 됨

        public int radi
        { get { return this.r; } 
          set {
                if (value < 0) // value : 매개변수의 역할을 함
                {
                    this.r = 0;
                }
                else
                {
                    this.r = value;
                }
            }
        }
    }
}
