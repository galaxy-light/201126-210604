using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTest0222
{
    class Address_attri
    {
        // private static Student inst;

        /*public static Student getInst()
        {
            if (inst == null)
            {
                inst = new Student();
            }
            return inst;
        }*/

        public Address_attri()
        { 
        
        }

        public Address_attri(string name, string tel, string address, string email)
        {
            this.Name = name;
            this.Tel = tel;
            this.Address = address;
            this.Email = email;
        }

        // 오버로딩
        /*public Address_attri(string id, string name, string tel, string address, string email) : this(name, tel, address, email)
        {
            this.Id = id;            
        }*/

        //public string Name { get => name; set => name = value; }
        //public string Tel { get => tel; set => tel = value; }
        //public string Address { get => address; set => address = value; }
        //public string Email { get => email; set => email = value; }
        //public string Id { get => id; set => id = value; }

        // auto 속성 사용
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        //public string Id { get; set; }

        public void showAddress()
        {
            Console.WriteLine("이름: {0}", Name);
            Console.WriteLine("전화: " + Tel);
            Console.WriteLine("주소: " + Address);
            Console.WriteLine("이메일: " + Email);
            Console.WriteLine("-----------------");
        }
    }
}
