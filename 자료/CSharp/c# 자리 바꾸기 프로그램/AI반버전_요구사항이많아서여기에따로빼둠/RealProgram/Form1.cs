using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RealProgram
{
    public partial class Form1 : Form
    {

        private Point mousePoint;
        List<Label> computer_seat = new List<Label>();
        List<string> seat_number = new List<string>();
        Label[] labels = new Label [24];
        public Form1()
        {
            InitializeComponent();
            init();
            addMouseEvent();

            label_num1.MouseDown += Label_num1_MouseDown;
            label_num1.MouseMove += Label_num1_MouseMove;
            foreach (var item in Controls)
            {
                if(item is Label)
                {
                    if(!(item as Label).Text.Equals("교사") && !(item as Label).Text.Equals("문") && !(item as Label).Text.Equals("X"))
                    {
                        computer_seat.Add(item as Label);
                        seat_number.Add((item as Label).Text);
                    }
                }
            }
            DataManager.load_Students_List();

        }

        private void Label_num1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }

        private void Label_num1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        public void init()
        {
            //for (int i = 0; i < 22; i++)
            //{
            //    Console.WriteLine("labels[" + i + "]=label_num" + (i + 1)+";");
            //}
            labels[0] = label_num1;
            labels[1] = label_num2;
            labels[2] = label_num3;
            labels[3] = label_num4;
            labels[4] = label_num5;
            labels[5] = label_num6;
            labels[6] = label_num7;
            labels[7] = label_num8;
            labels[8] = label_num9;
            labels[9] = label_num10;
            labels[10] = label_num11;
            labels[11] = label_num12;
            labels[12] = label_num13;
            labels[13] = label_num14;
            labels[14] = label_num15;
            labels[15] = label_num16;
            labels[16] = label_num17;
            labels[17] = label_num18;
            labels[18] = label_num19;
            labels[19] = label_num20;
            labels[20] = label_num21;
            labels[21] = label_num22;
            labels[22] = label_num23;
            labels[23] = label_num24;
        }
        public void addMouseEvent()
        {
            foreach(var item in labels)
            {
                item.MouseDown += mouseDown;
                item.MouseMove += mouseMove;
                item.Click += changePosition; //기껏마우스 이벤트만들어놓고 필요없게하기...
            }
        }
        private int clickCount = 0;
        private Student tempStudent1;
        private Student tempStudent11;
        private Student tempStudent2;
        private Student tempStudent22;
        private void changePosition(object sender, EventArgs e)
        {
            try
            {

                if (!(sender as Label).Enabled) //중복 클릭 방지
                    return;

                clickCount++;

                if (clickCount % 2 != 0) //처음 클릭한 것은 Disable시키기
                {
                    (sender as Label).Enabled = false;
                    tempStudent1 = new Student(DataManager.students.Single((x) => x.name == (sender as Label).Text));
                    tempStudent11 = DataManager.students.Single((x) => x.name == (sender as Label).Text);
                }
                else
                {
                    tempStudent2 = new Student(DataManager.students.Single((x) => x.name == (sender as Label).Text));
                    tempStudent22 = DataManager.students.Single((x) => x.name == (sender as Label).Text);
                    /*
                     *         public int number;
        public string name;
        public string gender;
        public bool mustFront;
        public bool mustBack; 
        public bool isFixed;
                     */

                    //tempStudent22.number = tempStudent1.number;
                    tempStudent22.name = tempStudent1.name;
                    tempStudent22.gender = tempStudent1.gender;
                    tempStudent22.mustFront = tempStudent1.mustFront;
                    tempStudent22.mustBack = tempStudent1.mustBack;
                    tempStudent22.isFixed = tempStudent1.isFixed;


                    //tempStudent11.number = tempStudent2.number;
                    tempStudent11.name = tempStudent2.name;
                    tempStudent11.gender = tempStudent2.gender;
                    tempStudent11.mustFront = tempStudent2.mustFront;
                    tempStudent11.mustBack = tempStudent2.mustBack;
                    tempStudent11.isFixed = tempStudent2.isFixed;
                    //students.Sort();
                    resetUI();
                    SetUI();
                    foreach (var item in Controls)
                    {
                        if (item is Label)
                            (item as Label).Enabled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                foreach (var item in Controls)
                {
                    if (item is Label)
                        (item as Label).Enabled = true;
                }
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }



        private void resetUI()
        {
            for (int j = 0; j < computer_seat.Count; j++)
            {
                computer_seat[j].Text = seat_number[j];
                computer_seat[j].BackColor = Color.White;
                computer_seat[j].ForeColor = Color.Black;
            }
        }

        private void label_teacher_Click(object sender, EventArgs e)
        {
            DataManager.load_Students_List();
            resetUI();
            if(!DataManager.shuffleStudentList())
            {
                MessageBox.Show("셔플 과정에서 문제가 있습니다.");
                return;
            }
            SetUI();

            DataManager.students.Sort(); //number를 기준으로 정렬
        }

        private void SetUI()
        {
            for (int i = 1; i <= DataManager.students.Count; i++)
            {
                for (int j = 1; j <= computer_seat.Count; j++)
                {
                    if (int.Parse(seat_number[j - 1]) == DataManager.students[i - 1].number)//label_num1
                    {
                        computer_seat[j - 1].Text = DataManager.students[i - 1].name;
                        if (DataManager.students[i - 1].gender.Equals("여"))
                        {
                            computer_seat[j - 1].BackColor = Color.Black;
                            computer_seat[j - 1].ForeColor = Color.HotPink;
                        }
                        break;
                    }
                }
            }
        }

        private void label_teacher_MouseDown(object sender, MouseEventArgs e)
        {
            label_teacher.BackColor = Color.Red;
        }

        private void label_teacher_MouseUp(object sender, MouseEventArgs e)
        {
            label_teacher.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //Copy(@"C:\Users\KB\Desktop\자리표\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ".png");
            MessageBox.Show("프로그램이 종료됩니다.");
            Dispose();
            //Copy(""+DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            DataManager.load_Students_List();
            resetUI();
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
                if(sender is Form1)
                {
                    (sender as Form1).Location = new Point(this.Left - (mousePoint.X - e.X),
                       this.Top - (mousePoint.Y - e.Y));
                }
                else
                {
                    (sender as Label).Location = new Point((sender as Label).Left - (mousePoint.X - e.X),
                       (sender as Label).Top - (mousePoint.Y - e.Y));
                }
            }
                
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove( sender,  e);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Copy(@"C:\Users\KB\Desktop\자리표\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day+".png");
            //FormCapture(DateTime.Now.Year + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + "_" + DateTime.Now.ToString("hh_mm_hh_ss_fff") + ".png", new Size(this.Bounds.Width, this.Bounds.Height));
            SaveScreenshot(Form.ActiveForm);
            DataManager.SaveData();
            MessageBox.Show("이미지 저장되었습니다!");
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


        private void button_load_Click(object sender, EventArgs e)
        {
            DataManager.load_Students_List();
            resetUI();
            SetUI();
        }
    }
}
