using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIMHealth.Model
{
    class Member
    {
        private string Name;

        public Member(string name)
        {
            Name = name;
        }

        public string Name1 { get => Name; set => Name = value; }
    }
}
