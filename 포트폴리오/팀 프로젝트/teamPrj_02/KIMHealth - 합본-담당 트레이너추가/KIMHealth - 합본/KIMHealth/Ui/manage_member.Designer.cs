
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_member));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serch_txt = new System.Windows.Forms.TextBox();
            this.serch_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_pt = new System.Windows.Forms.Label();
            this.lb_lent = new System.Windows.Forms.Label();
            this.lb_membership = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.settings_btn = new Sunny.UI.UISymbolButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 140);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.serch_txt);
            this.groupBox2.Controls.Add(this.serch_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 80);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원 검색";
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
            // serch_txt
            // 
            this.serch_txt.Location = new System.Drawing.Point(121, 38);
            this.serch_txt.Name = "serch_txt";
            this.serch_txt.Size = new System.Drawing.Size(126, 21);
            this.serch_txt.TabIndex = 1;
            // 
            // serch_btn
            // 
            this.serch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serch_btn.Location = new System.Drawing.Point(253, 39);
            this.serch_btn.Name = "serch_btn";
            this.serch_btn.Size = new System.Drawing.Size(75, 23);
            this.serch_btn.TabIndex = 0;
            this.serch_btn.Text = "조회";
            this.serch_btn.UseVisualStyleBackColor = true;
            this.serch_btn.Click += new System.EventHandler(this.serch_btn_Click);
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 208);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가입 회원 조회";
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Location = new System.Drawing.Point(99, 182);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(11, 12);
            this.lb_end.TabIndex = 16;
            this.lb_end.Text = "-";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(99, 158);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(11, 12);
            this.lb_start.TabIndex = 15;
            this.lb_start.Text = "-";
            // 
            // lb_pt
            // 
            this.lb_pt.AutoSize = true;
            this.lb_pt.Location = new System.Drawing.Point(99, 134);
            this.lb_pt.Name = "lb_pt";
            this.lb_pt.Size = new System.Drawing.Size(11, 12);
            this.lb_pt.TabIndex = 14;
            this.lb_pt.Text = "-";
            // 
            // lb_lent
            // 
            this.lb_lent.AutoSize = true;
            this.lb_lent.Location = new System.Drawing.Point(99, 110);
            this.lb_lent.Name = "lb_lent";
            this.lb_lent.Size = new System.Drawing.Size(11, 12);
            this.lb_lent.TabIndex = 13;
            this.lb_lent.Text = "-";
            // 
            // lb_membership
            // 
            this.lb_membership.AutoSize = true;
            this.lb_membership.Location = new System.Drawing.Point(99, 86);
            this.lb_membership.Name = "lb_membership";
            this.lb_membership.Size = new System.Drawing.Size(11, 12);
            this.lb_membership.TabIndex = 12;
            this.lb_membership.Text = "-";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(99, 38);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(11, 12);
            this.lb_id.TabIndex = 11;
            this.lb_id.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "만료일 :";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(99, 62);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(11, 12);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "회원번호 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "이름 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "등록 과정 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "등록일 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "렌트 여부 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "PT여부 :";
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
            this.settings_btn.Location = new System.Drawing.Point(618, 403);
            this.settings_btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.RectColor = System.Drawing.Color.White;
            this.settings_btn.Size = new System.Drawing.Size(34, 35);
            this.settings_btn.Style = Sunny.UI.UIStyle.Custom;
            this.settings_btn.Symbol = 61459;
            this.settings_btn.SymbolSize = 35;
            this.settings_btn.TabIndex = 27;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // manage_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manage_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            this.MouseEnter += new System.EventHandler(this.manage_member_MouseEnter);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox serch_txt;
        private System.Windows.Forms.Button serch_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_pt;
        private System.Windows.Forms.Label lb_lent;
        private System.Windows.Forms.Label lb_membership;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Sunny.UI.UISymbolButton settings_btn;
    }
}