using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHwaCSharp
{
    class Cat : Animal, IRunnable, IFight
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("집사야 고기가 없다.");
            //구현이 안 되어 있다는 에러를 띄우는 것 
            //throw new NotImplementedException();
        }

    }
}
