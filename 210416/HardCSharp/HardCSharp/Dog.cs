using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCSharp
{
    class Dog : Animal
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("와아앙");
            //throw new NotImplementedException();
            // throw new NotImplementedException(); : 구현이 안되어있다는 에러를 띄우는 것
        }
    }
}
