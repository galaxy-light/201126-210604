
namespace Managing_Car_Program.Ui
{
    partial class Cust_ma_add_Form
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
            this.uiTextBox_nm = new Sunny.UI.UITextBox();
            this.uiSymbolLabel_nm = new Sunny.UI.UISymbolLabel();
            this.uiTextBox_carnum = new Sunny.UI.UITextBox();
            this.uiSymbolLabel_carnum = new Sunny.UI.UISymbolLabel();
            this.uiTextBox_ph = new Sunny.UI.UITextBox();
            this.uiSymbolLabel_ph = new Sunny.UI.UISymbolLabel();
            this.uiTextBox_start = new Sunny.UI.UITextBox();
            this.uiSymbolLabel_start = new Sunny.UI.UISymbolLabel();
            this.uiTextBox_end = new Sunny.UI.UITextBox();
            this.uiSymbolLabel_end = new Sunny.UI.UISymbolLabel();
            this.button_okay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // uiTextBox_nm
            // 
            this.uiTextBox_nm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_nm.FillColor = System.Drawing.Color.White;
            this.uiTextBox_nm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox_nm.Location = new System.Drawing.Point(498, 128);
            this.uiTextBox_nm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox_nm.Maximum = 2147483647D;
            this.uiTextBox_nm.Minimum = -2147483648D;
            this.uiTextBox_nm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_nm.Name = "uiTextBox_nm";
            this.uiTextBox_nm.Padding = new System.Windows.Forms.Padding(6);
            this.uiTextBox_nm.Size = new System.Drawing.Size(218, 29);
            this.uiTextBox_nm.TabIndex = 6;
            this.uiTextBox_nm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_nm_KeyPress);
            // 
            // uiSymbolLabel_nm
            // 
            this.uiSymbolLabel_nm.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel_nm.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel_nm.Location = new System.Drawing.Point(359, 124);
            this.uiSymbolLabel_nm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolLabel_nm.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel_nm.Name = "uiSymbolLabel_nm";
            this.uiSymbolLabel_nm.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel_nm.Size = new System.Drawing.Size(131, 44);
            this.uiSymbolLabel_nm.Symbol = 61447;
            this.uiSymbolLabel_nm.SymbolSize = 35;
            this.uiSymbolLabel_nm.TabIndex = 5;
            this.uiSymbolLabel_nm.Text = "차주이름";
            // 
            // uiTextBox_carnum
            // 
            this.uiTextBox_carnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_carnum.FillColor = System.Drawing.Color.White;
            this.uiTextBox_carnum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox_carnum.Location = new System.Drawing.Point(498, 181);
            this.uiTextBox_carnum.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox_carnum.Maximum = 2147483647D;
            this.uiTextBox_carnum.Minimum = -2147483648D;
            this.uiTextBox_carnum.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_carnum.Name = "uiTextBox_carnum";
            this.uiTextBox_carnum.Padding = new System.Windows.Forms.Padding(6);
            this.uiTextBox_carnum.Size = new System.Drawing.Size(218, 29);
            this.uiTextBox_carnum.TabIndex = 8;
            this.uiTextBox_carnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_carnum_KeyPress);
            // 
            // uiSymbolLabel_carnum
            // 
            this.uiSymbolLabel_carnum.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel_carnum.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel_carnum.Location = new System.Drawing.Point(359, 177);
            this.uiSymbolLabel_carnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolLabel_carnum.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel_carnum.Name = "uiSymbolLabel_carnum";
            this.uiSymbolLabel_carnum.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel_carnum.Size = new System.Drawing.Size(131, 44);
            this.uiSymbolLabel_carnum.Symbol = 61881;
            this.uiSymbolLabel_carnum.SymbolSize = 35;
            this.uiSymbolLabel_carnum.TabIndex = 7;
            this.uiSymbolLabel_carnum.Text = "차량번호";
            // 
            // uiTextBox_ph
            // 
            this.uiTextBox_ph.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_ph.FillColor = System.Drawing.Color.White;
            this.uiTextBox_ph.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox_ph.Location = new System.Drawing.Point(498, 235);
            this.uiTextBox_ph.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox_ph.Maximum = 2147483647D;
            this.uiTextBox_ph.Minimum = -2147483648D;
            this.uiTextBox_ph.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_ph.Name = "uiTextBox_ph";
            this.uiTextBox_ph.Padding = new System.Windows.Forms.Padding(6);
            this.uiTextBox_ph.Size = new System.Drawing.Size(218, 29);
            this.uiTextBox_ph.TabIndex = 10;
            this.uiTextBox_ph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_ph_KeyPress);
            // 
            // uiSymbolLabel_ph
            // 
            this.uiSymbolLabel_ph.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel_ph.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel_ph.Location = new System.Drawing.Point(359, 232);
            this.uiSymbolLabel_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolLabel_ph.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel_ph.Name = "uiSymbolLabel_ph";
            this.uiSymbolLabel_ph.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel_ph.Size = new System.Drawing.Size(131, 44);
            this.uiSymbolLabel_ph.Symbol = 61589;
            this.uiSymbolLabel_ph.SymbolSize = 35;
            this.uiSymbolLabel_ph.TabIndex = 9;
            this.uiSymbolLabel_ph.Text = "전화번호";
            // 
            // uiTextBox_start
            // 
            this.uiTextBox_start.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_start.FillColor = System.Drawing.Color.White;
            this.uiTextBox_start.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox_start.Location = new System.Drawing.Point(498, 288);
            this.uiTextBox_start.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox_start.Maximum = 2147483647D;
            this.uiTextBox_start.Minimum = -2147483648D;
            this.uiTextBox_start.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_start.Name = "uiTextBox_start";
            this.uiTextBox_start.Padding = new System.Windows.Forms.Padding(6);
            this.uiTextBox_start.Size = new System.Drawing.Size(218, 29);
            this.uiTextBox_start.TabIndex = 12;
            this.uiTextBox_start.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_start_KeyPress);
            // 
            // uiSymbolLabel_start
            // 
            this.uiSymbolLabel_start.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel_start.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel_start.Location = new System.Drawing.Point(322, 288);
            this.uiSymbolLabel_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolLabel_start.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel_start.Name = "uiSymbolLabel_start";
            this.uiSymbolLabel_start.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel_start.Size = new System.Drawing.Size(168, 44);
            this.uiSymbolLabel_start.Symbol = 61584;
            this.uiSymbolLabel_start.SymbolSize = 35;
            this.uiSymbolLabel_start.TabIndex = 11;
            this.uiSymbolLabel_start.Text = "정기권 시작일";
            // 
            // uiTextBox_end
            // 
            this.uiTextBox_end.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox_end.FillColor = System.Drawing.Color.White;
            this.uiTextBox_end.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox_end.Location = new System.Drawing.Point(498, 343);
            this.uiTextBox_end.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiTextBox_end.Maximum = 2147483647D;
            this.uiTextBox_end.Minimum = -2147483648D;
            this.uiTextBox_end.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox_end.Name = "uiTextBox_end";
            this.uiTextBox_end.Padding = new System.Windows.Forms.Padding(6);
            this.uiTextBox_end.Size = new System.Drawing.Size(218, 29);
            this.uiTextBox_end.TabIndex = 14;
            this.uiTextBox_end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox_end_KeyPress);
            // 
            // uiSymbolLabel_end
            // 
            this.uiSymbolLabel_end.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel_end.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel_end.Location = new System.Drawing.Point(322, 338);
            this.uiSymbolLabel_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolLabel_end.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel_end.Name = "uiSymbolLabel_end";
            this.uiSymbolLabel_end.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.uiSymbolLabel_end.Size = new System.Drawing.Size(168, 44);
            this.uiSymbolLabel_end.Symbol = 61579;
            this.uiSymbolLabel_end.SymbolSize = 35;
            this.uiSymbolLabel_end.TabIndex = 13;
            this.uiSymbolLabel_end.Text = "정기권 종료일";
            // 
            // button_okay
            // 
            this.button_okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_okay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_okay.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_okay.ForeColor = System.Drawing.Color.White;
            this.button_okay.Location = new System.Drawing.Point(331, 417);
            this.button_okay.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(105, 33);
            this.button_okay.TabIndex = 16;
            this.button_okay.Text = "등록";
            this.button_okay.UseVisualStyleBackColor = false;
            this.button_okay.Click += new System.EventHandler(this.button_okay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 25);
            this.panel1.TabIndex = 20;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 170);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Cust_ma_add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 498);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_okay);
            this.Controls.Add(this.uiTextBox_end);
            this.Controls.Add(this.uiSymbolLabel_end);
            this.Controls.Add(this.uiTextBox_start);
            this.Controls.Add(this.uiSymbolLabel_start);
            this.Controls.Add(this.uiTextBox_ph);
            this.Controls.Add(this.uiSymbolLabel_ph);
            this.Controls.Add(this.uiTextBox_carnum);
            this.Controls.Add(this.uiSymbolLabel_carnum);
            this.Controls.Add(this.uiTextBox_nm);
            this.Controls.Add(this.uiSymbolLabel_nm);
            this.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cust_ma_add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정기권 고객 등록";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uiTextBox_nm;
        private Sunny.UI.UISymbolLabel uiSymbolLabel_nm;
        private Sunny.UI.UITextBox uiTextBox_carnum;
        private Sunny.UI.UISymbolLabel uiSymbolLabel_carnum;
        private Sunny.UI.UITextBox uiTextBox_ph;
        private Sunny.UI.UISymbolLabel uiSymbolLabel_ph;
        private Sunny.UI.UITextBox uiTextBox_start;
        private Sunny.UI.UISymbolLabel uiSymbolLabel_start;
        private Sunny.UI.UITextBox uiTextBox_end;
        private Sunny.UI.UISymbolLabel uiSymbolLabel_end;
        private System.Windows.Forms.Button button_okay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}