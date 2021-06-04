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
            System.Windows.Forms.MessageBox.Show("할퀴기!!!");
        }
    }
}
