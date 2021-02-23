using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.model
{    
    class Student
    {
        private string id;
        private string name;
        private string tel;
        private string address;
        private string email;

        public Student(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        /*public Student(string id, string name, string tel, string address, string email) : this(name, address, tel, address, email)
        { 
            this.id = id;
        }*/

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        public void showAddressInfo()
        {
            Console.WriteLine("이름 " + name);
            Console.WriteLine("전화 번호 " + tel);
            Console.WriteLine("주소 " + address);
            Console.WriteLine("이메일 " + email);
            Console.WriteLine("------------------");
        }
    }
}
