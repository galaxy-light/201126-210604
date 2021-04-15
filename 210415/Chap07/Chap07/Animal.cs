using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class Animal
    {
        // virtual이 있어야 오버라이드가 가능함
        // 부모는 virtual을 써야 됨
        // virtual을 상속받는 애가 오버라이드를 사용
        // 오버라이드가 있으면 어딘가에 virtual이 있어야 되는데
        // ToString()에 오버라이드가 있다는 건 어딘가에 Animal의 부모가 virtual로 되어있다는 것 = object(Animal의 부모)
        // 조상(최상위 부모) object : 기본
        // object - Animal - NewDog, NewCat

        public string name { get; set; }
        public int age { get; set; }
        public string breedName { get; set; }

        // virtual : 오버라이딩을 할 수 있다고 정의해줌 / Fight()를 virtual이라는 키워드로 재정의
        public virtual void Fight()
        {
            // 자동완성 : mbox + tab키 + tab키
            System.Windows.Forms.MessageBox.Show("먼지 파티");
        }

        public void Eat()
        {
            System.Windows.Forms.MessageBox.Show("냠냠");
        }
                
        public override string ToString() // override가 있는 이유는 이 클래스 위에 object가 있기 때문
        {
            return "내 주인의 이름은 " + name + "이고, 내 나이는 " + age + "살이야.";
        }
    }
}
