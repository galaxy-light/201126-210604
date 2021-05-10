using KIMHealth.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth.Ui
{
    partial class TrainerIdCheck : Form
    {
        List<Locker> lockers;
        Label label;
        int trainerNum;
        public TrainerIdCheck(List<Locker> lockers, object sender1, int trainerNum)
        {
            InitializeComponent();
            this.lockers = lockers;
            this.label = sender1 as Label;
            this.trainerNum = trainerNum;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

            trainerok();
        }
        private void trainerok()
        {

            if (textBox1.Text == LockerForm.testId)
            {
                foreach (var item in lockers)
                {
                    if (label == item.LockerLabel)
                    {
                        // 트레이너용 락커 지정
                        if (item.TrainerLock == false)
                        {
                            item.TrainerLock = true;
                            item.IsBorrowed = true;
                            item.UserName = "트레이너 " + trainerNum;
                        }

                        // 트레이너용 락커 해제
                        else
                        {
                            item.TrainerLock = false;
                            item.IsBorrowed = false;
                            item.UserName = string.Empty;
                        }
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("트레이너 정보가 없습니다.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                const char ENTER_KEY = (char)Keys.Enter;
                if (e.KeyChar == ENTER_KEY)
                    trainerok();
            }
            catch (FormatException)
            {

            }
        }
    }
}
