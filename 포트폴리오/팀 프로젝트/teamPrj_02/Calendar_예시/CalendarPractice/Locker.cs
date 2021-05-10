using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth.Ui
{
    public partial class Locker : Form
    {
        private Point mousePoint;
        List<Locker> computer_lock = new List<Locker>();
        List<string> seat_lock = new List<string>();
        Label[] labels = new Label[40];

        public Locker()
        {
            InitializeComponent();
            addMouseEvent();
            lock_1.MouseDown += Lock_1_MouseDown;
            lock_1.MouseMove += Lock_1_MouseMove;


        }

        private void addMouseEvent()
        {
            foreach (var item in labels)
            {
                item.MouseDown += mouseDown;
                item.MouseMove += mouseMove;
                //item.Click += changePosition;
            }
        }

        private void Lock_1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void Lock_1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        private void Locker_Load(object sender, EventArgs e)
        {
            



        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void lock_full_MouseDown(object sender, MouseEventArgs e)
        {
            lock_full.BackColor = Color.Red;
        }

        private void label_empty_MouseUp(object sender, MouseEventArgs e)
        {
            lock_empty.BackColor = Color.White;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (sender is Locker)
                {
                    (sender as Locker).Location = new Point(this.Left - (mousePoint.X - e.X),
                       this.Top - (mousePoint.Y - e.Y));
                }
                else
                {
                    (sender as Locker).Location = new Point((sender as Locker).Left - (mousePoint.X - e.X),
                       (sender as Locker).Top - (mousePoint.Y - e.Y));
                }
            }

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
            //Dispose();
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

    }
}
