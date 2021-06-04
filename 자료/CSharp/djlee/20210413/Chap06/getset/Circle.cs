using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Circle
    {
        private int r;
        public int R { get { return this.r; } 
                       set { this.r = value; } }

        public int radius { get; set; }
        //참고로 {get; set;} 없어도 우린 잘만 써왔다.
        //나중에 그리드뷰할 때는 {get;set;}이 필요하니
        //public 변수 만들 땐 {get;set;}을 써줘라.

        public int radi
        {
            get { return this.r; }
            set 
            {
                if (value < 0)
                    this.r = 0;
                else
                {
                    this.r = value;
                }
            }
        }
    }
}
