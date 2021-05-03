
namespace Managing_Car_Program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cust_end = new System.Windows.Forms.TextBox();
            this.textBox_cust_start = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_out = new System.Windows.Forms.Button();
            this.button_in = new System.Windows.Forms.Button();
            this.textBox_carnum = new System.Windows.Forms.TextBox();
            this.label_out_time = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.label_in_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_check2 = new System.Windows.Forms.Button();
            this.label_spot_num = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_spotnum = new System.Windows.Forms.TextBox();
            this.button_check1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_adminlog = new Sunny.UI.UISymbolButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_result = new System.Windows.Forms.Label();
            this.label_in_out_result = new System.Windows.Forms.Label();
            this.label_money_result = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiSymbolButton_help = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_cust_add = new Sunny.UI.UISymbolButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Current_Time = new System.Windows.Forms.Label();
            this.uiSymbolButton_other = new Sunny.UI.UISymbolButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button_out);
            this.groupBox1.Controls.Add(this.button_in);
            this.groupBox1.Controls.Add(this.textBox_carnum);
            this.groupBox1.Controls.Add(this.label_out_time);
            this.groupBox1.Controls.Add(this.textBox_num);
            this.groupBox1.Controls.Add(this.label_in_time);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(306, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox1.Size = new System.Drawing.Size(388, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차 / 출차";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox_cust_end);
            this.groupBox4.Controls.Add(this.textBox_cust_start);
            this.groupBox4.Location = new System.Drawing.Point(9, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 84);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "정기권";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "시작일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "종료일";
            // 
            // textBox_cust_end
            // 
            this.textBox_cust_end.Location = new System.Drawing.Point(65, 50);
            this.textBox_cust_end.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.textBox_cust_end.Name = "textBox_cust_end";
            this.textBox_cust_end.Size = new System.Drawing.Size(155, 23);
            this.textBox_cust_end.TabIndex = 7;
            // 
            // textBox_cust_start
            // 
            this.textBox_cust_start.Location = new System.Drawing.Point(65, 20);
            this.textBox_cust_start.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.textBox_cust_start.Name = "textBox_cust_start";
            this.textBox_cust_start.Size = new System.Drawing.Size(155, 23);
            this.textBox_cust_start.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(246, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "출차시간";
            // 
            // button_out
            // 
            this.button_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_out.ForeColor = System.Drawing.Color.White;
            this.button_out.Location = new System.Drawing.Point(275, 126);
            this.button_out.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(84, 30);
            this.button_out.TabIndex = 8;
            this.button_out.Text = "출차";
            this.button_out.UseVisualStyleBackColor = false;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_in.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_in.ForeColor = System.Drawing.Color.White;
            this.button_in.Location = new System.Drawing.Point(275, 92);
            this.button_in.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(84, 30);
            this.button_in.TabIndex = 9;
            this.button_in.Text = "주차";
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.Location = new System.Drawing.Point(74, 51);
            this.textBox_carnum.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(155, 23);
            this.textBox_carnum.TabIndex = 5;
            // 
            // label_out_time
            // 
            this.label_out_time.AutoSize = true;
            this.label_out_time.BackColor = System.Drawing.Color.White;
            this.label_out_time.Location = new System.Drawing.Point(312, 58);
            this.label_out_time.Name = "label_out_time";
            this.label_out_time.Size = new System.Drawing.Size(15, 14);
            this.label_out_time.TabIndex = 10;
            this.label_out_time.Text = "-";
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(74, 24);
            this.textBox_num.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(155, 23);
            this.textBox_num.TabIndex = 4;
            // 
            // label_in_time
            // 
            this.label_in_time.AutoSize = true;
            this.label_in_time.BackColor = System.Drawing.Color.White;
            this.label_in_time.Location = new System.Drawing.Point(312, 31);
            this.label_in_time.Name = "label_in_time";
            this.label_in_time.Size = new System.Drawing.Size(15, 14);
            this.label_in_time.TabIndex = 8;
            this.label_in_time.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "차량번호";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(246, 30);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "주차시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "공간번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_check2);
            this.groupBox2.Controls.Add(this.label_spot_num);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_spotnum);
            this.groupBox2.Controls.Add(this.button_check1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(699, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox2.Size = new System.Drawing.Size(263, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 조회";
            // 
            // button_check2
            // 
            this.button_check2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_check2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_check2.ForeColor = System.Drawing.Color.White;
            this.button_check2.Location = new System.Drawing.Point(167, 99);
            this.button_check2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_check2.Name = "button_check2";
            this.button_check2.Size = new System.Drawing.Size(84, 30);
            this.button_check2.TabIndex = 15;
            this.button_check2.Text = "조회";
            this.button_check2.UseVisualStyleBackColor = false;
            this.button_check2.Click += new System.EventHandler(this.button_check2_Click);
            // 
            // label_spot_num
            // 
            this.label_spot_num.AutoSize = true;
            this.label_spot_num.Location = new System.Drawing.Point(116, 108);
            this.label_spot_num.Margin = new System.Windows.Forms.Padding(0);
            this.label_spot_num.Name = "label_spot_num";
            this.label_spot_num.Size = new System.Drawing.Size(15, 14);
            this.label_spot_num.TabIndex = 14;
            this.label_spot_num.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "빈 주차 공간";
            // 
            // textBox_spotnum
            // 
            this.textBox_spotnum.Location = new System.Drawing.Point(85, 55);
            this.textBox_spotnum.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.textBox_spotnum.Name = "textBox_spotnum";
            this.textBox_spotnum.Size = new System.Drawing.Size(69, 23);
            this.textBox_spotnum.TabIndex = 10;
            // 
            // button_check1
            // 
            this.button_check1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_check1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_check1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_check1.ForeColor = System.Drawing.Color.White;
            this.button_check1.Location = new System.Drawing.Point(167, 49);
            this.button_check1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_check1.Name = "button_check1";
            this.button_check1.Size = new System.Drawing.Size(84, 30);
            this.button_check1.TabIndex = 10;
            this.button_check1.Text = "조회";
            this.button_check1.UseVisualStyleBackColor = false;
            this.button_check1.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "공간번호";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(301, 532);
            this.listBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(661, 160);
            this.listBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Button_adminlog
            // 
            this.Button_adminlog.BackColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_adminlog.FillColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.FillHoverColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.FillPressColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Button_adminlog.Location = new System.Drawing.Point(919, 29);
            this.Button_adminlog.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button_adminlog.Name = "Button_adminlog";
            this.Button_adminlog.RectColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.RectHoverColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.RectPressColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.RectSelectedColor = System.Drawing.Color.Transparent;
            this.Button_adminlog.Size = new System.Drawing.Size(36, 31);
            this.Button_adminlog.Style = Sunny.UI.UIStyle.Custom;
            this.Button_adminlog.Symbol = 61459;
            this.Button_adminlog.SymbolSize = 30;
            this.Button_adminlog.TabIndex = 14;
            this.Button_adminlog.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label_result);
            this.groupBox3.Controls.Add(this.label_in_out_result);
            this.groupBox3.Controls.Add(this.label_money_result);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label_money);
            this.groupBox3.Controls.Add(this.label_time);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(306, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.groupBox3.Size = new System.Drawing.Size(656, 56);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "요금 안내";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(331, 26);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(63, 14);
            this.label_result.TabIndex = 18;
            this.label_result.Text = "이용시간";
            // 
            // label_in_out_result
            // 
            this.label_in_out_result.AutoSize = true;
            this.label_in_out_result.Location = new System.Drawing.Point(403, 26);
            this.label_in_out_result.Name = "label_in_out_result";
            this.label_in_out_result.Size = new System.Drawing.Size(15, 14);
            this.label_in_out_result.TabIndex = 17;
            this.label_in_out_result.Text = "-";
            // 
            // label_money_result
            // 
            this.label_money_result.AutoSize = true;
            this.label_money_result.BackColor = System.Drawing.Color.White;
            this.label_money_result.Location = new System.Drawing.Point(563, 26);
            this.label_money_result.Name = "label_money_result";
            this.label_money_result.Size = new System.Drawing.Size(15, 14);
            this.label_money_result.TabIndex = 15;
            this.label_money_result.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(486, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "정산 요금";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(240, 26);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(31, 14);
            this.label_money.TabIndex = 13;
            this.label_money.Text = "500";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(121, 26);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(23, 14);
            this.label_time.TabIndex = 12;
            this.label_time.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "원";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(200, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "요금";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(52, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "단위시간";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.dataGridView_main);
            this.groupBox5.Location = new System.Drawing.Point(301, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 201);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "주차 현황";
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AutoGenerateColumns = false;
            this.dataGridView_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView_main.DataSource = this.parkingCarBindingSource;
            this.dataGridView_main.GridColor = System.Drawing.Color.Black;
            this.dataGridView_main.Location = new System.Drawing.Point(5, 17);
            this.dataGridView_main.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.RowTemplate.Height = 23;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(650, 175);
            this.dataGridView_main.TabIndex = 6;
            this.dataGridView_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellClick);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "parkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "공간번호";
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.Width = 120;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "carNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "차량번호";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.Width = 230;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "parkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "주차/출차시간";
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.Width = 257;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(Managing_Car_Program.ParkingCar);
            // 
            // uiSymbolButton_help
            // 
            this.uiSymbolButton_help.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_help.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_help.Location = new System.Drawing.Point(886, 29);
            this.uiSymbolButton_help.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_help.Name = "uiSymbolButton_help";
            this.uiSymbolButton_help.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_help.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_help.Symbol = 61736;
            this.uiSymbolButton_help.SymbolSize = 30;
            this.uiSymbolButton_help.TabIndex = 16;
            this.uiSymbolButton_help.Click += new System.EventHandler(this.uiSymbolButton_help_Click);
            // 
            // uiSymbolButton_cust_add
            // 
            this.uiSymbolButton_cust_add.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_cust_add.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_cust_add.Location = new System.Drawing.Point(855, 29);
            this.uiSymbolButton_cust_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_cust_add.Name = "uiSymbolButton_cust_add";
            this.uiSymbolButton_cust_add.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_cust_add.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_cust_add.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_cust_add.Symbol = 61785;
            this.uiSymbolButton_cust_add.SymbolSize = 30;
            this.uiSymbolButton_cust_add.TabIndex = 17;
            this.uiSymbolButton_cust_add.Click += new System.EventHandler(this.uiSymbolButton_cust_add_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.Label_Current_Time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 703);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 25);
            this.panel1.TabIndex = 19;
            // 
            // Label_Current_Time
            // 
            this.Label_Current_Time.AutoSize = true;
            this.Label_Current_Time.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Current_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Current_Time.Location = new System.Drawing.Point(380, 6);
            this.Label_Current_Time.Name = "Label_Current_Time";
            this.Label_Current_Time.Size = new System.Drawing.Size(83, 13);
            this.Label_Current_Time.TabIndex = 0;
            this.Label_Current_Time.Text = "CurrentTime";
            // 
            // uiSymbolButton_other
            // 
            this.uiSymbolButton_other.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_other.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_other.Location = new System.Drawing.Point(173, 29);
            this.uiSymbolButton_other.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_other.Name = "uiSymbolButton_other";
            this.uiSymbolButton_other.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_other.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_other.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_other.Symbol = 61442;
            this.uiSymbolButton_other.SymbolSize = 30;
            this.uiSymbolButton_other.TabIndex = 20;
            this.uiSymbolButton_other.Click += new System.EventHandler(this.uiSymbolButton_other_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 728);
            this.Controls.Add(this.uiSymbolButton_other);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiSymbolButton_cust_add);
            this.Controls.Add(this.uiSymbolButton_help);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Button_adminlog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주차 관리 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_check1;
        private System.Windows.Forms.TextBox textBox_cust_end;
        private System.Windows.Forms.TextBox textBox_cust_start;
        private System.Windows.Forms.TextBox textBox_carnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.TextBox textBox_spotnum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton Button_adminlog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Label label_out_time;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Label label_in_time;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_spot_num;
        private System.Windows.Forms.Button button_check2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.Label label_money_result;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UISymbolButton uiSymbolButton_help;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private Sunny.UI.UISymbolButton uiSymbolButton_cust_add;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_Current_Time;
        private System.Windows.Forms.Label label_in_out_result;
        private System.Windows.Forms.Label label_result;
        private Sunny.UI.UISymbolButton uiSymbolButton_other;
    }
}

