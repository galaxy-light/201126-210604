
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_carnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_phnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_close = new System.Windows.Forms.Button();
            this.uiSymbolButton_add = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_del = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_refresh = new Sunny.UI.UISymbolButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 297);
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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 264);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader_num
            // 
            this.columnHeader_num.Text = "번호";
            this.columnHeader_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_num.Width = 50;
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
            this.columnHeader_carnum.Width = 130;
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
            this.columnHeader_start.Width = 135;
            // 
            // columnHeader_end
            // 
            this.columnHeader_end.Text = "정기권 종료일";
            this.columnHeader_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_end.Width = 135;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(354, 408);
            this.button_close.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(92, 35);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // uiSymbolButton_add
            // 
            this.uiSymbolButton_add.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_add.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_add.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_add.Location = new System.Drawing.Point(604, 29);
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
            this.uiSymbolButton_del.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_del.Location = new System.Drawing.Point(691, 29);
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
            // 
            // uiSymbolButton_refresh
            // 
            this.uiSymbolButton_refresh.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_refresh.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_refresh.Location = new System.Drawing.Point(178, 29);
            this.uiSymbolButton_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_refresh.Name = "uiSymbolButton_refresh";
            this.uiSymbolButton_refresh.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Size = new System.Drawing.Size(27, 31);
            this.uiSymbolButton_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_refresh.Symbol = 61473;
            this.uiSymbolButton_refresh.SymbolSize = 30;
            this.uiSymbolButton_refresh.TabIndex = 19;
            this.uiSymbolButton_refresh.Click += new System.EventHandler(this.uiSymbolButton_refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VipCustViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.uiSymbolButton_refresh);
            this.Controls.Add(this.uiSymbolButton_del);
            this.Controls.Add(this.uiSymbolButton_add);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox1);
            this.Name = "VipCustViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정기권 고객 리스트";
            this.Load += new System.EventHandler(this.Vip_Customer_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_close;
        private Sunny.UI.UISymbolButton uiSymbolButton_add;
        private Sunny.UI.UISymbolButton uiSymbolButton_del;
        private System.Windows.Forms.ColumnHeader columnHeader_end;
        private Sunny.UI.UISymbolButton uiSymbolButton_refresh;
        private System.Windows.Forms.Timer timer1;
    }
}