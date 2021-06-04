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
            { new Dog(), new Dog()};

        List<Cat> Cats = new List<Cat>()
            { new Cat(), new Cat()};

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

            if (false)
            {
                NewCat c = new NewCat();
                c.Eat();
                c.name = "이동준";
                c.breedName = "인간";
                NewDog d = new NewDog();
                d.Eat();
            }

            List<Animal> Animals = new List<Animal>()
            {
                new NewDog(), new NewCat(), new NewDog(), new NewCat()
            };
            //(Animals[0] as NewDog).breedName = "말티즈";

            foreach (var item in Animals)
            {
                item.Eat();
                var dog = item as NewDog;
                if(dog != null)
                {
                    dog.Bark();
                }
                var cat = item as NewCat;
                if (cat != null)
                {
                    cat.Meow();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            NewDog d = new NewDog();
            NewCat c = new NewCat();

            a.Fight();
            d.Fight();
            c.Fight();

            a.name = "이동준";
            a.age = 20;

            d.name = "니니";
            d.age = 17;

            MessageBox.Show(a.ToString());
            MessageBox.Show(d.ToString());

            Cat oldcat = new Cat();
            oldcat.name = "나옹";
            oldcat.age = 25;
            MessageBox.Show(oldcat.ToString());
        }
    }
}
