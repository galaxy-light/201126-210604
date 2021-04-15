using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class NewCat : Animal
    {
        public void Meow()
        {
            System.Windows.Forms.MessageBox.Show("냥냥냥");
        }

        public override void Fight()
        {
            // 자동완성 : mbox + tab키 + tab키
            System.Windows.Forms.MessageBox.Show("고양이 털 파티");
        }
    }
}
