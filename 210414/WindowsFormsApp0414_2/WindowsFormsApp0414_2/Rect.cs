using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp0414_2
{
    class Rect
    {
        // 캡슐화 : get, set

        public int w;
        public int h;

        public int getArea()
        {
            return w * h;
        }

        private int width;
        public void setWidth(int width)
        {
            // 음수의 예외처리
            if (width < 0)
            {
                this.width = 0;
            }
            else // else가 없으면 음수일 때 width에 다시 음수가 들어감
            {
                this.width = width;
            }
            this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }

        private int height;
        public void setHeight(int height)
        {
            // 음수의 예외처리
            if (height < 0)
            {
                this.height = 0;
            }
            else // else가 없으면 음수일 때 height에 다시 음수가 들어감
            {
                this.height = height;
            }
            this.height = height;
        }        
        public int getHeight()
        {
            return this.height;
        }

        public int getArea_with_getset()
        {
            return w * h;
        }
    }
}
