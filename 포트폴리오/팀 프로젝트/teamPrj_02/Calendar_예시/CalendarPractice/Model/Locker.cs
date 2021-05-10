using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIMHealth.Model
{
    class Locker
    {
        private int locknum;
        private bool mustUP;
        private bool mustDown;

        public int Locknum { get; set; }
        public bool MustUP { get; set; }
        public bool MustDown { get; set; }

        public Locker(int locknum, bool mustUP, bool mustDown)
        {
            Locknum = locknum;
            this.mustUP = mustUP;
            this.mustDown = mustDown;
        }
    }
}
