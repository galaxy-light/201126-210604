using KIMHealth.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KIMHealth.Ui
{
    public partial class LockerForm : Form
    {
        List<Locker> lockers = new List<Locker>();

        public static string trainerId;

        int userNum = 1;
        int trainerNum = 1;
        public static string testId = "123";
        public LockerForm()
        {
            InitializeComponent();
            // List에 Label(lockerLabel) 정보를 포함한 Locker객체 추가
            lockers.Add(new Locker(lock_1));
            lockers.Add(new Locker(lock_2));
            lockers.Add(new Locker(lock_3));
            lockers.Add(new Locker(lock_4));
            lockers.Add(new Locker(lock_5));
            lockers.Add(new Locker(lock_6));
            lockers.Add(new Locker(lock_7));
            lockers.Add(new Locker(lock_8));
            lockers.Add(new Locker(lock_9));
            lockers.Add(new Locker(lock_10));
            lockers.Add(new Locker(lock_11));
            lockers.Add(new Locker(lock_12));
            lockers.Add(new Locker(lock_13));
            lockers.Add(new Locker(lock_14));
            lockers.Add(new Locker(lock_15));
            lockers.Add(new Locker(lock_16));
            lockers.Add(new Locker(lock_17));
            lockers.Add(new Locker(lock_18));
            lockers.Add(new Locker(lock_19));
            lockers.Add(new Locker(lock_20));
            lockers.Add(new Locker(lock_21));
            lockers.Add(new Locker(lock_22));
            lockers.Add(new Locker(lock_23));
            lockers.Add(new Locker(lock_24));
            lockers.Add(new Locker(lock_25));
            lockers.Add(new Locker(lock_26));
            lockers.Add(new Locker(lock_27));
            lockers.Add(new Locker(lock_28));
            lockers.Add(new Locker(lock_29));
            lockers.Add(new Locker(lock_30));
            lockers.Add(new Locker(lock_31));
            lockers.Add(new Locker(lock_32));
            lockers.Add(new Locker(lock_33));
            lockers.Add(new Locker(lock_34));
            lockers.Add(new Locker(lock_35));
            lockers.Add(new Locker(lock_36));
            lockers.Add(new Locker(lock_37));
            lockers.Add(new Locker(lock_38));
            lockers.Add(new Locker(lock_39));
            lockers.Add(new Locker(lock_40));
            setLockerColor();
        }

        private void setLockerColor()
        {
            foreach (var item in lockers)
            {
                if (item.IsBorrowed)
                {
                    if (item.TrainerLock)
                        item.LockerLabel.BackColor = Color.CornflowerBlue;
                    else
                        item.LockerLabel.BackColor = Color.Brown;
                }
                else
                    item.LockerLabel.BackColor = Color.Silver;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        //락커 대여
        private void button_lent_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() == "" || textBox_lockerNum.Text.Trim() == "")
            {
                MessageBox.Show("회원 Id와 락커번호를 확인해주세요.");
            }

            else
            {
                foreach (var item in lockers)
                {
                    if (textBox_lockerNum.Text == item.LockerLabel.Text)
                    {
                        if (item.IsBorrowed == true)
                        {
                            MessageBox.Show("락커가 이미 사용중입니다.");
                        }
                        else
                        {
                            item.IsBorrowed = true;
                            item.UserId = int.Parse(textBox_id.Text);
                            item.UserName = "사용자 " + userNum;
                            item.BorrowedAt = DateTime.Now.ToString("yyyy/MM/dd");
                        }
                    }
                }
            }
            userNum++;
            setLockerColor();
        }

        //락커 반납
        private void button_return_Click_1(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("회원번호를 입력해주세요.");
            }
            else
            {
                foreach (var item in lockers)
                {
                    if (item.LockerLabel.Text == textBox_lockerNum.Text)
                    {
                        if (item.TrainerLock)
                        {
                            MessageBox.Show("트레이너용 락커입니다.");
                        }
                        else
                        {
                            item.IsBorrowed = false;
                            item.BorrowedAt = null;
                            item.UserId = 0;
                            item.UserName = null;
                        }
                    }
                }
            }
            setLockerColor();
        }

        public static void Copy(string outputFilename)
        {
            //출처 : http://www.csharpstudy.com/Tip/Tip-screen-copy.aspx
            // 주화면의 크기 정보 읽기
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            // 2nd screen = Screen.AllScreens[1]

            // 픽셀 포맷 정보 얻기 (Optional)
            int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
            PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
            if (bitsPerPixel <= 16)
            {
                pixelFormat = PixelFormat.Format16bppRgb565;
            }
            if (bitsPerPixel == 24)
            {
                pixelFormat = PixelFormat.Format24bppRgb;
            }

            // 화면 크기만큼의 Bitmap 생성
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, pixelFormat);

            // Bitmap 이미지 변경을 위해 Graphics 객체 생성
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                // 화면을 그대로 카피해서 Bitmap 메모리에 저장
                gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }

            // Bitmap 데이타를 파일로 저장
            bmp.Save(outputFilename);
            bmp.Dispose();
        }

        //현재 열려있는 윈폼 그대로 캡쳐하기
        //https://etfplant.tistory.com/614
        public void FormCapture(string strOutput, Size _FormSize)
        {
            Bitmap bmp = new Bitmap(_FormSize.Width, _FormSize.Height);
            Graphics grp = Graphics.FromImage(bmp);
            grp.CopyFromScreen(new Point(this.Bounds.X, this.Bounds.Y), new Point(0, 0), _FormSize);
            bmp.Save(strOutput, System.Drawing.Imaging.ImageFormat.Png);
        }

        private static void SaveScreenshot(Form frm)
        {
            //string ImagePath = string.Format(@"C:\temp\Screen_{0}.png", DateTime.Now.Ticks);
            string ImagePath = DateTime.Now.Year + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.ToString("hh_mm_hh_ss_fff") + ".png";
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            //Copy(@"C:\Users\KB\Desktop\자리표\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ".png");
            MessageBox.Show("이전화면으로 돌아갑니다.");
            Close();
            //Copy(""+DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Copy(@"C:\Users\KB\Desktop\자리표\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day+".png");
            //FormCapture(DateTime.Now.Year + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.ToString("hh_mm_hh_ss_fff") + ".png", new Size(this.Bounds.Width, this.Bounds.Height));
            SaveScreenshot(Form.ActiveForm);
            //DataManager.SaveData();
            MessageBox.Show("이미지 저장되었습니다!");
        }

        // 클릭 할 때 락커번호 텍스트 박스에 삽입
        private void Locker_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            foreach (var item in lockers)
            {
                if (label == item.LockerLabel)
                {
                    if (item.UserId != 0)
                    {
                        textBox_id.Text = item.UserId.ToString();
                    }
                    else
                    {
                        textBox_id.Text = "";
                    }
                }
            }
            textBox_lockerNum.Text = label.Text;
        }

        // 락커에 마우스 가져다 댈때 락커 색, 커서 변함
        private void Locker_mouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.Gainsboro;
            label.Cursor = Cursors.Hand;
        }

        // 락커에 마우스 치울때 락커 색, 커서 변함
        private void Locker_mouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            setLockerColor();
            label.Cursor = Cursors.Default;
        }

        // 더블클릭하면 트레이너용 락커
        private void Locker_DoubleClick(object sender, EventArgs e)
        {
            new TrainerIdCheck(lockers, sender, trainerNum).ShowDialog();
            trainerNum++;
            setLockerColor();
        }
    }
}
