using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class NewDog : Animal
    {
        public void Bark()
        {
            System.Windows.Forms.MessageBox.Show("멍멍멍");
        }
        public override void Fight()
        {
            System.Windows.Forms.MessageBox.Show("물기!!!");
        }
    }
}
