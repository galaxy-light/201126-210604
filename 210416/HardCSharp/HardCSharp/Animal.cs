using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCSharp
{
    abstract class Animal : IRunnable, IFight
    // abstract : 추상
    // abstract의 아쉬운 점 : abstract가 여러 개일 때는 구현해야 되는 함수가 명시적으로 표현되지 않기 때문에 불편함
    // -> 이 불편함을 해소하기 위해 나온 것이 인터페이스  
    // interface : abstract와 달리 구현해야 되는 함수를 표시해줌
    // IRunnable, IFight -> interface : Animal에 IRunnable, IFight라는 규칙을 정의해주고 구현을 함
    // interface : 다중 상속 가능(interface는 규칙이기 때문에 여러 개 가능)

    // abstract, interface의 공통점 : 개발자가 지정한 특정 함수를 구현해야되는 공통점이 있음
    {
        public abstract void Eat();
        // Animal 클래스에서는 Eat() 구현을 하지 않음
        // abstract : Animal 클래스를 상속받으면 상속받은 클래스에서 구현하도록 하는 것

        public void fight()
        {
            //throw new NotImplementedException();
            System.Windows.Forms.MessageBox.Show("솜주먹펀치");
        }

        public void Run()
        {
            //throw new NotImplementedException();
            System.Windows.Forms.MessageBox.Show("슉슉");
        }               

        public void sleep()
        {
            System.Windows.Forms.MessageBox.Show("쿨쿨");
        }
    }
}
