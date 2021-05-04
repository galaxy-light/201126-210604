
namespace Managing_Car_Program.Ui
{
    partial class VipCustViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_carnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_phnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiSymbolButton_add = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_del = new Sunny.UI.UISymbolButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiCheckBox_end_2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox_end_1 = new Sunny.UI.UICheckBox();
            this.uiCheckBox_start_2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox_start_1 = new Sunny.UI.UICheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiCheckBox_enable = new Sunny.UI.UICheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_phnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_carnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.uiSymbolButton_update = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_help = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiSymbolButton_db = new Sunny.UI.UISymbolButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_num,
            this.columnHeader_nm,
            this.columnHeader_carnum,
            this.columnHeader_phnum,
            this.columnHeader_start,
            this.columnHeader_end});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(826, 254);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader_num
            // 
            this.columnHeader_num.Text = "번호";
            this.columnHeader_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_num.Width = 52;
            // 
            // columnHeader_nm
            // 
            this.columnHeader_nm.Text = "이름";
            this.columnHeader_nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_nm.Width = 110;
            // 
            // columnHeader_carnum
            // 
            this.columnHeader_carnum.Text = "차량번호";
            this.columnHeader_carnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_carnum.Width = 140;
            // 
            // columnHeader_phnum
            // 
            this.columnHeader_phnum.Text = "전화번호";
            this.columnHeader_phnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_phnum.Width = 160;
            // 
            // columnHeader_start
            // 
            this.columnHeader_start.Text = "정기권 시작일";
            this.columnHeader_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_start.Width = 180;
            // 
            // columnHeader_end
            // 
            this.columnHeader_end.Text = "정기권 종료일";
            this.columnHeader_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_end.Width = 180;
            // 
            // uiSymbolButton_add
            // 
            this.uiSymbolButton_add.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_add.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolButton_add.Location = new System.Drawing.Point(570, 29);
            this.uiSymbolButton_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_add.Name = "uiSymbolButton_add";
            this.uiSymbolButton_add.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.Size = new System.Drawing.Size(81, 31);
            this.uiSymbolButton_add.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_add.Symbol = 61543;
            this.uiSymbolButton_add.SymbolSize = 30;
            this.uiSymbolButton_add.TabIndex = 17;
            this.uiSymbolButton_add.Text = "추가";
            this.uiSymbolButton_add.Click += new System.EventHandler(this.uiSymbolButton_add_Click);
            // 
            // uiSymbolButton_del
            // 
            this.uiSymbolButton_del.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_del.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolButton_del.Location = new System.Drawing.Point(744, 29);
            this.uiSymbolButton_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_del.Name = "uiSymbolButton_del";
            this.uiSymbolButton_del.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_del.Size = new System.Drawing.Size(81, 31);
            this.uiSymbolButton_del.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_del.Symbol = 61544;
            this.uiSymbolButton_del.SymbolSize = 30;
            this.uiSymbolButton_del.TabIndex = 18;
            this.uiSymbolButton_del.Text = "삭제";
            this.uiSymbolButton_del.Click += new System.EventHandler(this.uiSymbolButton_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.uiCheckBox_end_2);
            this.groupBox2.Controls.Add(this.uiCheckBox_end_1);
            this.groupBox2.Controls.Add(this.uiCheckBox_start_2);
            this.groupBox2.Controls.Add(this.uiCheckBox_start_1);
            this.groupBox2.Location = new System.Drawing.Point(22, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 50);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "정렬";
            // 
            // uiCheckBox_end_2
            // 
            this.uiCheckBox_end_2.BackColor = System.Drawing.Color.White;
            this.uiCheckBox_end_2.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox_end_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_end_2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiCheckBox_end_2.Location = new System.Drawing.Point(636, 20);
            this.uiCheckBox_end_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_end_2.Name = "uiCheckBox_end_2";
            this.uiCheckBox_end_2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_end_2.Size = new System.Drawing.Size(155, 16);
            this.uiCheckBox_end_2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_end_2.TabIndex = 25;
            this.uiCheckBox_end_2.Text = "종료일 내림차순";
            this.uiCheckBox_end_2.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_end_2_ValueChanged);
            // 
            // uiCheckBox_end_1
            // 
            this.uiCheckBox_end_1.BackColor = System.Drawing.Color.White;
            this.uiCheckBox_end_1.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox_end_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_end_1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiCheckBox_end_1.Location = new System.Drawing.Point(443, 20);
            this.uiCheckBox_end_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_end_1.Name = "uiCheckBox_end_1";
            this.uiCheckBox_end_1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_end_1.Size = new System.Drawing.Size(155, 16);
            this.uiCheckBox_end_1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_end_1.TabIndex = 24;
            this.uiCheckBox_end_1.Text = "종료일 오름차순";
            this.uiCheckBox_end_1.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_end_1_ValueChanged);
            // 
            // uiCheckBox_start_2
            // 
            this.uiCheckBox_start_2.BackColor = System.Drawing.Color.White;
            this.uiCheckBox_start_2.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox_start_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_start_2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiCheckBox_start_2.Location = new System.Drawing.Point(248, 20);
            this.uiCheckBox_start_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_start_2.Name = "uiCheckBox_start_2";
            this.uiCheckBox_start_2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_start_2.Size = new System.Drawing.Size(155, 16);
            this.uiCheckBox_start_2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_start_2.TabIndex = 23;
            this.uiCheckBox_start_2.Text = "시작일 내림차순";
            this.uiCheckBox_start_2.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_start_2_ValueChanged);
            // 
            // uiCheckBox_start_1
            // 
            this.uiCheckBox_start_1.BackColor = System.Drawing.Color.White;
            this.uiCheckBox_start_1.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiCheckBox_start_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_start_1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiCheckBox_start_1.Location = new System.Drawing.Point(77, 20);
            this.uiCheckBox_start_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_start_1.Name = "uiCheckBox_start_1";
            this.uiCheckBox_start_1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_start_1.Size = new System.Drawing.Size(155, 16);
            this.uiCheckBox_start_1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_start_1.TabIndex = 22;
            this.uiCheckBox_start_1.Text = "시작일 오름차순";
            this.uiCheckBox_start_1.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_start_1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.uiCheckBox_enable);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_end);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_start);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_phnum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_carnum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_name);
            this.groupBox3.Location = new System.Drawing.Point(22, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 115);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "시작일 / 종료일 수정";
            // 
            // uiCheckBox_enable
            // 
            this.uiCheckBox_enable.BackColor = System.Drawing.Color.Transparent;
            this.uiCheckBox_enable.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.uiCheckBox_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox_enable.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiCheckBox_enable.Location = new System.Drawing.Point(34, 50);
            this.uiCheckBox_enable.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox_enable.Name = "uiCheckBox_enable";
            this.uiCheckBox_enable.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox_enable.Size = new System.Drawing.Size(72, 29);
            this.uiCheckBox_enable.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox_enable.TabIndex = 10;
            this.uiCheckBox_enable.Text = "활성화";
            this.uiCheckBox_enable.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.uiCheckBox_update_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "정기권 종료일";
            // 
            // textBox_end
            // 
            this.textBox_end.Location = new System.Drawing.Point(526, 73);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(127, 21);
            this.textBox_end.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "정기권 시작일";
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(293, 73);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(127, 21);
            this.textBox_start.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "전화번호";
            // 
            // textBox_phnum
            // 
            this.textBox_phnum.Location = new System.Drawing.Point(621, 35);
            this.textBox_phnum.Name = "textBox_phnum";
            this.textBox_phnum.Size = new System.Drawing.Size(127, 21);
            this.textBox_phnum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "차량번호";
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.Location = new System.Drawing.Point(406, 35);
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(127, 21);
            this.textBox_carnum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(178, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(127, 21);
            this.textBox_name.TabIndex = 0;
            // 
            // uiSymbolButton_update
            // 
            this.uiSymbolButton_update.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_update.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolButton_update.Location = new System.Drawing.Point(657, 29);
            this.uiSymbolButton_update.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_update.Name = "uiSymbolButton_update";
            this.uiSymbolButton_update.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_update.Size = new System.Drawing.Size(81, 31);
            this.uiSymbolButton_update.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_update.Symbol = 61508;
            this.uiSymbolButton_update.SymbolSize = 30;
            this.uiSymbolButton_update.TabIndex = 23;
            this.uiSymbolButton_update.Text = "수정";
            this.uiSymbolButton_update.Click += new System.EventHandler(this.uiSymbolButton_update_on_Click);
            // 
            // uiSymbolButton_help
            // 
            this.uiSymbolButton_help.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_help.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolButton_help.Location = new System.Drawing.Point(827, 29);
            this.uiSymbolButton_help.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_help.Name = "uiSymbolButton_help";
            this.uiSymbolButton_help.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help.Size = new System.Drawing.Size(27, 31);
            this.uiSymbolButton_help.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_help.Symbol = 61529;
            this.uiSymbolButton_help.SymbolSize = 30;
            this.uiSymbolButton_help.TabIndex = 24;
            this.uiSymbolButton_help.Click += new System.EventHandler(this.uiSymbolButton_help_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 25);
            this.panel1.TabIndex = 25;
            // 
            // uiSymbolButton_db
            // 
            this.uiSymbolButton_db.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_db.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_db.Location = new System.Drawing.Point(176, 29);
            this.uiSymbolButton_db.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_db.Name = "uiSymbolButton_db";
            this.uiSymbolButton_db.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_db.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_db.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_db.Symbol = 61717;
            this.uiSymbolButton_db.SymbolSize = 35;
            this.uiSymbolButton_db.TabIndex = 31;
            this.uiSymbolButton_db.Click += new System.EventHandler(this.uiSymbolButton_db_Click);
            // 
            // VipCustViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 576);
            this.Controls.Add(this.uiSymbolButton_db);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiSymbolButton_help);
            this.Controls.Add(this.uiSymbolButton_update);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uiSymbolButton_del);
            this.Controls.Add(this.uiSymbolButton_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "VipCustViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정기권 고객 리스트";
            this.Load += new System.EventHandler(this.Vip_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_num;
        private System.Windows.Forms.ColumnHeader columnHeader_nm;
        private System.Windows.Forms.ColumnHeader columnHeader_carnum;
        private System.Windows.Forms.ColumnHeader columnHeader_phnum;
        private System.Windows.Forms.ColumnHeader columnHeader_start;
        private Sunny.UI.UISymbolButton uiSymbolButton_add;
        private Sunny.UI.UISymbolButton uiSymbolButton_del;
        private System.Windows.Forms.ColumnHeader columnHeader_end;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UICheckBox uiCheckBox_start_1;
        private Sunny.UI.UICheckBox uiCheckBox_end_2;
        private Sunny.UI.UICheckBox uiCheckBox_end_1;
        private Sunny.UI.UICheckBox uiCheckBox_start_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_carnum;
        private Sunny.UI.UISymbolButton uiSymbolButton_update;
        private Sunny.UI.UICheckBox uiCheckBox_enable;
        private Sunny.UI.UISymbolButton uiSymbolButton_help;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton uiSymbolButton_db;
    }
}