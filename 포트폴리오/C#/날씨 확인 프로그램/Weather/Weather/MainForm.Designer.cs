
namespace Weather
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_avg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_weather_text6 = new System.Windows.Forms.Label();
            this.label_high_text6 = new System.Windows.Forms.Label();
            this.label_high6 = new System.Windows.Forms.Label();
            this.label_low_text6 = new System.Windows.Forms.Label();
            this.label_low6 = new System.Windows.Forms.Label();
            this.label_day6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_weather_text5 = new System.Windows.Forms.Label();
            this.label_high_text5 = new System.Windows.Forms.Label();
            this.label_high5 = new System.Windows.Forms.Label();
            this.label_low_text5 = new System.Windows.Forms.Label();
            this.label_low5 = new System.Windows.Forms.Label();
            this.label_day5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_weather_text4 = new System.Windows.Forms.Label();
            this.label_high_text4 = new System.Windows.Forms.Label();
            this.label_high4 = new System.Windows.Forms.Label();
            this.label_low_text4 = new System.Windows.Forms.Label();
            this.label_low4 = new System.Windows.Forms.Label();
            this.label_day4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_weather_text3 = new System.Windows.Forms.Label();
            this.label_high_text3 = new System.Windows.Forms.Label();
            this.label_high3 = new System.Windows.Forms.Label();
            this.label_low_text3 = new System.Windows.Forms.Label();
            this.label_low3 = new System.Windows.Forms.Label();
            this.label_day3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_weather_text2 = new System.Windows.Forms.Label();
            this.label_high_text2 = new System.Windows.Forms.Label();
            this.label_high2 = new System.Windows.Forms.Label();
            this.label_low_text2 = new System.Windows.Forms.Label();
            this.label_low2 = new System.Windows.Forms.Label();
            this.label_day2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_weather_text1 = new System.Windows.Forms.Label();
            this.label_high_text1 = new System.Windows.Forms.Label();
            this.label_high1 = new System.Windows.Forms.Label();
            this.label_low_text1 = new System.Windows.Forms.Label();
            this.label_low1 = new System.Windows.Forms.Label();
            this.label_day1 = new System.Windows.Forms.Label();
            this.label_nowday = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 539);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox_city);
            this.groupBox3.Location = new System.Drawing.Point(29, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 72);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "지역";
            // 
            // comboBox_city
            // 
            this.comboBox_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Items.AddRange(new object[] {
            "서울",
            "인천",
            "원주",
            "강릉",
            "대전",
            "세종",
            "홍성",
            "청주",
            "충주",
            "광주",
            "목포",
            "여수",
            "순천",
            "광양",
            "전주",
            "군산",
            "정읍",
            "남원",
            "고창",
            "부산",
            "울산",
            "창원",
            "진주",
            "거창",
            "통영",
            "대구",
            "안동",
            "포항",
            "경주",
            "울진",
            "울릉도",
            "제주",
            "서귀포"});
            this.comboBox_city.Location = new System.Drawing.Point(79, 29);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(121, 20);
            this.comboBox_city.TabIndex = 13;
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_avg);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(29, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 166);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "날씨 정리";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(99, 141);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(11, 12);
            this.label_avg.TabIndex = 15;
            this.label_avg.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 107);
            this.textBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label_weather_text6);
            this.panel6.Controls.Add(this.label_high_text6);
            this.panel6.Controls.Add(this.label_high6);
            this.panel6.Controls.Add(this.label_low_text6);
            this.panel6.Controls.Add(this.label_low6);
            this.panel6.Controls.Add(this.label_day6);
            this.panel6.Location = new System.Drawing.Point(421, 408);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 100);
            this.panel6.TabIndex = 23;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // label_weather_text6
            // 
            this.label_weather_text6.AutoSize = true;
            this.label_weather_text6.Location = new System.Drawing.Point(60, 79);
            this.label_weather_text6.Name = "label_weather_text6";
            this.label_weather_text6.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text6.TabIndex = 5;
            this.label_weather_text6.Text = "-";
            // 
            // label_high_text6
            // 
            this.label_high_text6.AutoSize = true;
            this.label_high_text6.Location = new System.Drawing.Point(77, 57);
            this.label_high_text6.Name = "label_high_text6";
            this.label_high_text6.Size = new System.Drawing.Size(11, 12);
            this.label_high_text6.TabIndex = 4;
            this.label_high_text6.Text = "-";
            // 
            // label_high6
            // 
            this.label_high6.AutoSize = true;
            this.label_high6.Location = new System.Drawing.Point(42, 57);
            this.label_high6.Name = "label_high6";
            this.label_high6.Size = new System.Drawing.Size(29, 12);
            this.label_high6.TabIndex = 3;
            this.label_high6.Text = "최고";
            // 
            // label_low_text6
            // 
            this.label_low_text6.AutoSize = true;
            this.label_low_text6.Location = new System.Drawing.Point(77, 33);
            this.label_low_text6.Name = "label_low_text6";
            this.label_low_text6.Size = new System.Drawing.Size(11, 12);
            this.label_low_text6.TabIndex = 2;
            this.label_low_text6.Text = "-";
            // 
            // label_low6
            // 
            this.label_low6.AutoSize = true;
            this.label_low6.Location = new System.Drawing.Point(42, 33);
            this.label_low6.Name = "label_low6";
            this.label_low6.Size = new System.Drawing.Size(29, 12);
            this.label_low6.TabIndex = 1;
            this.label_low6.Text = "최저";
            // 
            // label_day6
            // 
            this.label_day6.AutoSize = true;
            this.label_day6.Location = new System.Drawing.Point(54, 11);
            this.label_day6.Name = "label_day6";
            this.label_day6.Size = new System.Drawing.Size(11, 12);
            this.label_day6.TabIndex = 0;
            this.label_day6.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label_weather_text5);
            this.panel5.Controls.Add(this.label_high_text5);
            this.panel5.Controls.Add(this.label_high5);
            this.panel5.Controls.Add(this.label_low_text5);
            this.panel5.Controls.Add(this.label_low5);
            this.panel5.Controls.Add(this.label_day5);
            this.panel5.Location = new System.Drawing.Point(226, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 100);
            this.panel5.TabIndex = 22;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label_weather_text5
            // 
            this.label_weather_text5.AutoSize = true;
            this.label_weather_text5.Location = new System.Drawing.Point(60, 79);
            this.label_weather_text5.Name = "label_weather_text5";
            this.label_weather_text5.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text5.TabIndex = 5;
            this.label_weather_text5.Text = "-";
            // 
            // label_high_text5
            // 
            this.label_high_text5.AutoSize = true;
            this.label_high_text5.Location = new System.Drawing.Point(77, 57);
            this.label_high_text5.Name = "label_high_text5";
            this.label_high_text5.Size = new System.Drawing.Size(11, 12);
            this.label_high_text5.TabIndex = 4;
            this.label_high_text5.Text = "-";
            // 
            // label_high5
            // 
            this.label_high5.AutoSize = true;
            this.label_high5.Location = new System.Drawing.Point(42, 57);
            this.label_high5.Name = "label_high5";
            this.label_high5.Size = new System.Drawing.Size(29, 12);
            this.label_high5.TabIndex = 3;
            this.label_high5.Text = "최고";
            // 
            // label_low_text5
            // 
            this.label_low_text5.AutoSize = true;
            this.label_low_text5.Location = new System.Drawing.Point(77, 33);
            this.label_low_text5.Name = "label_low_text5";
            this.label_low_text5.Size = new System.Drawing.Size(11, 12);
            this.label_low_text5.TabIndex = 2;
            this.label_low_text5.Text = "-";
            // 
            // label_low5
            // 
            this.label_low5.AutoSize = true;
            this.label_low5.Location = new System.Drawing.Point(42, 33);
            this.label_low5.Name = "label_low5";
            this.label_low5.Size = new System.Drawing.Size(29, 12);
            this.label_low5.TabIndex = 1;
            this.label_low5.Text = "최저";
            // 
            // label_day5
            // 
            this.label_day5.AutoSize = true;
            this.label_day5.Location = new System.Drawing.Point(52, 11);
            this.label_day5.Name = "label_day5";
            this.label_day5.Size = new System.Drawing.Size(11, 12);
            this.label_day5.TabIndex = 0;
            this.label_day5.Text = "-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_weather_text4);
            this.panel4.Controls.Add(this.label_high_text4);
            this.panel4.Controls.Add(this.label_high4);
            this.panel4.Controls.Add(this.label_low_text4);
            this.panel4.Controls.Add(this.label_low4);
            this.panel4.Controls.Add(this.label_day4);
            this.panel4.Location = new System.Drawing.Point(29, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 100);
            this.panel4.TabIndex = 21;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label_weather_text4
            // 
            this.label_weather_text4.AutoSize = true;
            this.label_weather_text4.Location = new System.Drawing.Point(58, 79);
            this.label_weather_text4.Name = "label_weather_text4";
            this.label_weather_text4.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text4.TabIndex = 5;
            this.label_weather_text4.Text = "-";
            // 
            // label_high_text4
            // 
            this.label_high_text4.AutoSize = true;
            this.label_high_text4.Location = new System.Drawing.Point(77, 57);
            this.label_high_text4.Name = "label_high_text4";
            this.label_high_text4.Size = new System.Drawing.Size(11, 12);
            this.label_high_text4.TabIndex = 4;
            this.label_high_text4.Text = "-";
            // 
            // label_high4
            // 
            this.label_high4.AutoSize = true;
            this.label_high4.Location = new System.Drawing.Point(40, 57);
            this.label_high4.Name = "label_high4";
            this.label_high4.Size = new System.Drawing.Size(29, 12);
            this.label_high4.TabIndex = 3;
            this.label_high4.Text = "최고";
            // 
            // label_low_text4
            // 
            this.label_low_text4.AutoSize = true;
            this.label_low_text4.Location = new System.Drawing.Point(77, 33);
            this.label_low_text4.Name = "label_low_text4";
            this.label_low_text4.Size = new System.Drawing.Size(11, 12);
            this.label_low_text4.TabIndex = 2;
            this.label_low_text4.Text = "-";
            // 
            // label_low4
            // 
            this.label_low4.AutoSize = true;
            this.label_low4.Location = new System.Drawing.Point(40, 33);
            this.label_low4.Name = "label_low4";
            this.label_low4.Size = new System.Drawing.Size(29, 12);
            this.label_low4.TabIndex = 1;
            this.label_low4.Text = "최저";
            // 
            // label_day4
            // 
            this.label_day4.AutoSize = true;
            this.label_day4.Location = new System.Drawing.Point(50, 11);
            this.label_day4.Name = "label_day4";
            this.label_day4.Size = new System.Drawing.Size(11, 12);
            this.label_day4.TabIndex = 0;
            this.label_day4.Text = "-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label_weather_text3);
            this.panel3.Controls.Add(this.label_high_text3);
            this.panel3.Controls.Add(this.label_high3);
            this.panel3.Controls.Add(this.label_low_text3);
            this.panel3.Controls.Add(this.label_low3);
            this.panel3.Controls.Add(this.label_day3);
            this.panel3.Location = new System.Drawing.Point(421, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 100);
            this.panel3.TabIndex = 20;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label_weather_text3
            // 
            this.label_weather_text3.AutoSize = true;
            this.label_weather_text3.Location = new System.Drawing.Point(60, 79);
            this.label_weather_text3.Name = "label_weather_text3";
            this.label_weather_text3.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text3.TabIndex = 5;
            this.label_weather_text3.Text = "-";
            // 
            // label_high_text3
            // 
            this.label_high_text3.AutoSize = true;
            this.label_high_text3.Location = new System.Drawing.Point(77, 57);
            this.label_high_text3.Name = "label_high_text3";
            this.label_high_text3.Size = new System.Drawing.Size(11, 12);
            this.label_high_text3.TabIndex = 4;
            this.label_high_text3.Text = "-";
            // 
            // label_high3
            // 
            this.label_high3.AutoSize = true;
            this.label_high3.Location = new System.Drawing.Point(42, 57);
            this.label_high3.Name = "label_high3";
            this.label_high3.Size = new System.Drawing.Size(29, 12);
            this.label_high3.TabIndex = 3;
            this.label_high3.Text = "최고";
            // 
            // label_low_text3
            // 
            this.label_low_text3.AutoSize = true;
            this.label_low_text3.Location = new System.Drawing.Point(77, 33);
            this.label_low_text3.Name = "label_low_text3";
            this.label_low_text3.Size = new System.Drawing.Size(11, 12);
            this.label_low_text3.TabIndex = 2;
            this.label_low_text3.Text = "-";
            // 
            // label_low3
            // 
            this.label_low3.AutoSize = true;
            this.label_low3.Location = new System.Drawing.Point(42, 33);
            this.label_low3.Name = "label_low3";
            this.label_low3.Size = new System.Drawing.Size(29, 12);
            this.label_low3.TabIndex = 1;
            this.label_low3.Text = "최저";
            // 
            // label_day3
            // 
            this.label_day3.AutoSize = true;
            this.label_day3.Location = new System.Drawing.Point(54, 11);
            this.label_day3.Name = "label_day3";
            this.label_day3.Size = new System.Drawing.Size(11, 12);
            this.label_day3.TabIndex = 0;
            this.label_day3.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_weather_text2);
            this.panel2.Controls.Add(this.label_high_text2);
            this.panel2.Controls.Add(this.label_high2);
            this.panel2.Controls.Add(this.label_low_text2);
            this.panel2.Controls.Add(this.label_low2);
            this.panel2.Controls.Add(this.label_day2);
            this.panel2.Location = new System.Drawing.Point(226, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 100);
            this.panel2.TabIndex = 19;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label_weather_text2
            // 
            this.label_weather_text2.AutoSize = true;
            this.label_weather_text2.Location = new System.Drawing.Point(60, 79);
            this.label_weather_text2.Name = "label_weather_text2";
            this.label_weather_text2.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text2.TabIndex = 5;
            this.label_weather_text2.Text = "-";
            // 
            // label_high_text2
            // 
            this.label_high_text2.AutoSize = true;
            this.label_high_text2.Location = new System.Drawing.Point(77, 57);
            this.label_high_text2.Name = "label_high_text2";
            this.label_high_text2.Size = new System.Drawing.Size(11, 12);
            this.label_high_text2.TabIndex = 4;
            this.label_high_text2.Text = "-";
            // 
            // label_high2
            // 
            this.label_high2.AutoSize = true;
            this.label_high2.Location = new System.Drawing.Point(42, 57);
            this.label_high2.Name = "label_high2";
            this.label_high2.Size = new System.Drawing.Size(29, 12);
            this.label_high2.TabIndex = 3;
            this.label_high2.Text = "최고";
            // 
            // label_low_text2
            // 
            this.label_low_text2.AutoSize = true;
            this.label_low_text2.Location = new System.Drawing.Point(77, 33);
            this.label_low_text2.Name = "label_low_text2";
            this.label_low_text2.Size = new System.Drawing.Size(11, 12);
            this.label_low_text2.TabIndex = 2;
            this.label_low_text2.Text = "-";
            // 
            // label_low2
            // 
            this.label_low2.AutoSize = true;
            this.label_low2.Location = new System.Drawing.Point(42, 33);
            this.label_low2.Name = "label_low2";
            this.label_low2.Size = new System.Drawing.Size(29, 12);
            this.label_low2.TabIndex = 1;
            this.label_low2.Text = "최저";
            // 
            // label_day2
            // 
            this.label_day2.AutoSize = true;
            this.label_day2.Location = new System.Drawing.Point(52, 11);
            this.label_day2.Name = "label_day2";
            this.label_day2.Size = new System.Drawing.Size(11, 12);
            this.label_day2.TabIndex = 0;
            this.label_day2.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_weather_text1);
            this.panel1.Controls.Add(this.label_high_text1);
            this.panel1.Controls.Add(this.label_high1);
            this.panel1.Controls.Add(this.label_low_text1);
            this.panel1.Controls.Add(this.label_low1);
            this.panel1.Controls.Add(this.label_day1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(29, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 100);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label_weather_text1
            // 
            this.label_weather_text1.AutoSize = true;
            this.label_weather_text1.Location = new System.Drawing.Point(58, 79);
            this.label_weather_text1.Name = "label_weather_text1";
            this.label_weather_text1.Size = new System.Drawing.Size(11, 12);
            this.label_weather_text1.TabIndex = 5;
            this.label_weather_text1.Text = "-";
            // 
            // label_high_text1
            // 
            this.label_high_text1.AutoSize = true;
            this.label_high_text1.Location = new System.Drawing.Point(77, 57);
            this.label_high_text1.Name = "label_high_text1";
            this.label_high_text1.Size = new System.Drawing.Size(11, 12);
            this.label_high_text1.TabIndex = 4;
            this.label_high_text1.Text = "-";
            // 
            // label_high1
            // 
            this.label_high1.AutoSize = true;
            this.label_high1.Location = new System.Drawing.Point(40, 57);
            this.label_high1.Name = "label_high1";
            this.label_high1.Size = new System.Drawing.Size(29, 12);
            this.label_high1.TabIndex = 3;
            this.label_high1.Text = "최고";
            // 
            // label_low_text1
            // 
            this.label_low_text1.AutoSize = true;
            this.label_low_text1.Location = new System.Drawing.Point(77, 33);
            this.label_low_text1.Name = "label_low_text1";
            this.label_low_text1.Size = new System.Drawing.Size(11, 12);
            this.label_low_text1.TabIndex = 2;
            this.label_low_text1.Text = "-";
            // 
            // label_low1
            // 
            this.label_low1.AutoSize = true;
            this.label_low1.Location = new System.Drawing.Point(40, 33);
            this.label_low1.Name = "label_low1";
            this.label_low1.Size = new System.Drawing.Size(29, 12);
            this.label_low1.TabIndex = 1;
            this.label_low1.Text = "최저";
            // 
            // label_day1
            // 
            this.label_day1.AutoSize = true;
            this.label_day1.Location = new System.Drawing.Point(50, 11);
            this.label_day1.Name = "label_day1";
            this.label_day1.Size = new System.Drawing.Size(11, 12);
            this.label_day1.TabIndex = 0;
            this.label_day1.Text = "-";
            // 
            // label_nowday
            // 
            this.label_nowday.AutoSize = true;
            this.label_nowday.Location = new System.Drawing.Point(519, 38);
            this.label_nowday.Name = "label_nowday";
            this.label_nowday.Size = new System.Drawing.Size(11, 12);
            this.label_nowday.TabIndex = 16;
            this.label_nowday.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(628, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_nowday);
            this.Name = "MainForm";
            this.Text = "이틀 뒤 날씨는 어떨까";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_weather_text6;
        private System.Windows.Forms.Label label_high_text6;
        private System.Windows.Forms.Label label_high6;
        private System.Windows.Forms.Label label_low_text6;
        private System.Windows.Forms.Label label_low6;
        private System.Windows.Forms.Label label_day6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_weather_text5;
        private System.Windows.Forms.Label label_high_text5;
        private System.Windows.Forms.Label label_high5;
        private System.Windows.Forms.Label label_low_text5;
        private System.Windows.Forms.Label label_low5;
        private System.Windows.Forms.Label label_day5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_weather_text4;
        private System.Windows.Forms.Label label_high_text4;
        private System.Windows.Forms.Label label_high4;
        private System.Windows.Forms.Label label_low_text4;
        private System.Windows.Forms.Label label_low4;
        private System.Windows.Forms.Label label_day4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_weather_text3;
        private System.Windows.Forms.Label label_high_text3;
        private System.Windows.Forms.Label label_high3;
        private System.Windows.Forms.Label label_low_text3;
        private System.Windows.Forms.Label label_low3;
        private System.Windows.Forms.Label label_day3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_weather_text2;
        private System.Windows.Forms.Label label_high_text2;
        private System.Windows.Forms.Label label_high2;
        private System.Windows.Forms.Label label_low_text2;
        private System.Windows.Forms.Label label_low2;
        private System.Windows.Forms.Label label_day2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_weather_text1;
        private System.Windows.Forms.Label label_high_text1;
        private System.Windows.Forms.Label label_high1;
        private System.Windows.Forms.Label label_low_text1;
        private System.Windows.Forms.Label label_low1;
        private System.Windows.Forms.Label label_day1;
        private System.Windows.Forms.Label label_nowday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.Label label_avg;
    }
}

