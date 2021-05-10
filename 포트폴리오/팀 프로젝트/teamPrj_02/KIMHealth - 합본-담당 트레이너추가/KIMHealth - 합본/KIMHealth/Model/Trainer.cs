using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIMHealth.Model
{
    class Trainer
    {
        public Trainer(string name, string age, string gender, string career)
        {
            t_name = name;
            t_age = age;
            t_gender = gender;
            t_career = career;
        }

        public string t_name { get; set; }
        public string t_age { get; set; }
        public string t_gender { get; set; }
        public string t_career { get; set; }

    }
}
