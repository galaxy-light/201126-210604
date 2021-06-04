using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimHwaCSharp
{
    abstract class Animal : IRunnable, IFight
    {
        public abstract void Eat();

        public void fight()
        {
            System.Windows.Forms.MessageBox.Show("퍽퍽");
        }

        public void Run()
        {
            System.Windows.Forms.MessageBox.Show("슉슉달린다");
        }

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("쿨쿨 잔다.");
        }
    }
}
