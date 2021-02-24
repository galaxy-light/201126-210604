﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTest0219
{
    class Student
    {
        // 추상화  
        private string id;
        public string name;
        public string tel;
        public string address;
        public string email;
        private static Student inst;

        public static Student getInst()
        {
            if (inst == null)
            {
                inst = new Student();
            }
            return inst;
        }

        // 오류 해결을 위한 기본 생성자 추가
        public Student()
        {

        }


        public Student(string id, string name, string tel, string address, string email) : this(name, tel, address, email)
        {
            this.id = id;
        }


        // 기본 생성자
        public Student(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        // getter, setter
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        public void showAddress()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 번호 : " + tel);
            Console.WriteLine("주소 : {0}", address); // C#에서는 이런 식으로 적을 수도 있음
            Console.WriteLine("이메일 : {0}", email); // C#에서는 이런 식으로 적을 수도 있음
            Console.WriteLine("---------------------");
        }
    }
}