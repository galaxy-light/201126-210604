using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap07
{
    public partial class Form1 : Form
    {
        List<Dog> Dogs = new List<Dog>()
            { new Dog(), new Dog() };
        List<Cat> Cats = new List<Cat>()
            { new Cat(), new Cat() };

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Meow();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 상속
            NewCat c = new NewCat();
            if (false)
            {
                c.Eat();
                c.name = "홍";
                c.breedName = "삵";
                NewDog d = new NewDog();
                d.Eat();
            }            

            // 다형성 : 다양한 형태를 가짐 / 부모자식간의 관계가 확실하다면 서로간의 형변환이 가능함
            List<Animal> Animals = new List<Animal>() // Animal : NewDog, NewCat의 부모
            {
                new NewDog(), new NewCat(), new NewDog(), new NewCat()
            };
            //(Animals[0] as NewDog).breedName = "말티즈"; // 이런 식의 형변환이 가능함
            
            foreach (var item in Animals) // 현재 item의 타입은 Animals
            {
                item.Eat(); // Dog, Cat 양 쪽 클래스에 있기 때문에 이렇게 호출 가능
                var dog = item as NewDog; // 형변환
                if (dog != null)
                {
                    dog.Bark();
                }
                var cat = item as NewCat; // 형변환
                if (cat != null)
                {
                    cat.Meow();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 오버라이딩 : 재정의 / 덮어쓰기 / 부모로부터 물려받았지만 다르게 사용
            Animal a = new Animal();
            NewDog d = new NewDog();
            NewCat c = new NewCat();

            a.Fight();
            d.Fight();
            c.Fight();

            a.name = "길";
            a.age = 5;

            d.name = "동";
            d.age = 6;

            MessageBox.Show(a.ToString());
            MessageBox.Show(d.ToString());

            Cat oldcat = new Cat();
            oldcat.name = "냐옹";
            oldcat.age = 7;
            MessageBox.Show(oldcat.ToString()); // 이렇게만 하면 재정의를 하지 않았기 때문에 결과값으로 Chap07.Cat가 뜸
        }
    }
}
