using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth.Model
{
    class Locker
    {
        private Label lockerLabel;
        private bool isBorrowed;
        private string borrowedAt;
        private int userId;
        private string userName;
        private bool trainerLocker;

        public Locker(Label lockerLabel, bool isBorrowed = false, bool trainerLocker = false)
        {
            this.lockerLabel = lockerLabel;
            this.isBorrowed = isBorrowed;
            this.trainerLocker = trainerLocker;
        }

        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }
        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public Label LockerLabel { get => lockerLabel; set => lockerLabel = value; }
        public string BorrowedAt { get => borrowedAt; set => borrowedAt = value; }
        public bool TrainerLock { get => trainerLocker; set => trainerLocker = value; }
    }
}
