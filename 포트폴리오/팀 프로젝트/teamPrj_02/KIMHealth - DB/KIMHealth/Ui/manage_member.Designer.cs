
namespace KIMHealth
{
    partial class manage_member
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
            this.serch_btn = new System.Windows.Forms.Button();
            this.serch_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_pt = new System.Windows.Forms.Label();
            this.lb_lent = new System.Windows.Forms.Label();
            this.lb_membership = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settings_btn = new Sunny.UI.UISymbolButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serch_btn
            // 
            this.serch_btn.Location = new System.Drawing.Point(253, 39);
            this.serch_btn.Name = "serch_btn";
            this.serch_btn.Size = new System.Drawing.Size(75, 23);
            this.serch_btn.TabIndex = 0;
            this.serch_btn.Text = "조회";
            this.serch_btn.UseVisualStyleBackColor = true;
            this.serch_btn.Click += new System.EventHandler(this.serch_btn_Click);
            // 
            // serch_txt
            // 
            this.serch_txt.Location = new System.Drawing.Point(121, 38);
            this.serch_txt.Name = "serch_txt";
            this.serch_txt.Size = new System.Drawing.Size(126, 21);
            this.serch_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "등록 과정 :";
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(14, 128);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(53, 12);
            this.term.TabIndex = 6;
            this.term.Text = "PT여부 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "등록일 :";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(2, 104);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(69, 12);
            this.course.TabIndex = 8;
            this.course.Text = "렌트 여부 : ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(50, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(77, 56);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(11, 12);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름 :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 12);
            this.name.TabIndex = 3;
            this.name.Text = "회원번호 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_end);
            this.groupBox1.Controls.Add(this.lb_start);
            this.groupBox1.Controls.Add(this.lb_pt);
            this.groupBox1.Controls.Add(this.lb_lent);
            this.groupBox1.Controls.Add(this.lb_membership);
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.course);
            this.groupBox1.Controls.Add(this.term);
            this.groupBox1.Location = new System.Drawing.Point(346, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 208);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가입 회원 조회";
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Location = new System.Drawing.Point(77, 176);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(11, 12);
            this.lb_end.TabIndex = 16;
            this.lb_end.Text = "-";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(77, 152);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(11, 12);
            this.lb_start.TabIndex = 15;
            this.lb_start.Text = "-";
            // 
            // lb_pt
            // 
            this.lb_pt.AutoSize = true;
            this.lb_pt.Location = new System.Drawing.Point(77, 128);
            this.lb_pt.Name = "lb_pt";
            this.lb_pt.Size = new System.Drawing.Size(11, 12);
            this.lb_pt.TabIndex = 14;
            this.lb_pt.Text = "-";
            // 
            // lb_lent
            // 
            this.lb_lent.AutoSize = true;
            this.lb_lent.Location = new System.Drawing.Point(77, 104);
            this.lb_lent.Name = "lb_lent";
            this.lb_lent.Size = new System.Drawing.Size(11, 12);
            this.lb_lent.TabIndex = 13;
            this.lb_lent.Text = "-";
            // 
            // lb_membership
            // 
            this.lb_membership.AutoSize = true;
            this.lb_membership.Location = new System.Drawing.Point(77, 80);
            this.lb_membership.Name = "lb_membership";
            this.lb_membership.Size = new System.Drawing.Size(11, 12);
            this.lb_membership.TabIndex = 12;
            this.lb_membership.Text = "-";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(77, 32);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(11, 12);
            this.lb_id.TabIndex = 11;
            this.lb_id.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "만료일 :";
            // 
            // settings_btn
            // 
            this.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_btn.FillColor = System.Drawing.Color.White;
            this.settings_btn.FillHoverColor = System.Drawing.Color.White;
            this.settings_btn.FillPressColor = System.Drawing.Color.White;
            this.settings_btn.FillSelectedColor = System.Drawing.Color.White;
            this.settings_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.settings_btn.ForeColor = System.Drawing.Color.DimGray;
            this.settings_btn.Location = new System.Drawing.Point(754, 289);
            this.settings_btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.RectColor = System.Drawing.Color.White;
            this.settings_btn.Size = new System.Drawing.Size(34, 35);
            this.settings_btn.Style = Sunny.UI.UIStyle.Custom;
            this.settings_btn.Symbol = 61459;
            this.settings_btn.TabIndex = 22;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.serch_txt);
            this.groupBox2.Controls.Add(this.serch_btn);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 80);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원 검색";
            // 
            // manage_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "manage_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.MouseEnter += new System.EventHandler(this.manage_member_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serch_btn;
        private System.Windows.Forms.TextBox serch_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_pt;
        private System.Windows.Forms.Label lb_lent;
        private System.Windows.Forms.Label lb_membership;
        private System.Windows.Forms.Label lb_id;
        private Sunny.UI.UISymbolButton settings_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}