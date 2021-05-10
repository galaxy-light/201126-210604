
namespace KIMHealth.DB
{
    partial class totalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(totalInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_member = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_trainer = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_trainer_txt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.m_end_txt = new System.Windows.Forms.TextBox();
            this.m_start_txt = new System.Windows.Forms.TextBox();
            this.m_pt_txt = new System.Windows.Forms.TextBox();
            this.m_lent_txt = new System.Windows.Forms.TextBox();
            this.m_membership_txt = new System.Windows.Forms.TextBox();
            this.m_bmi_txt = new System.Windows.Forms.TextBox();
            this.m_weight_txt = new System.Windows.Forms.TextBox();
            this.m_height_txt = new System.Windows.Forms.TextBox();
            this.m_gender_txt = new System.Windows.Forms.TextBox();
            this.m_age_txt = new System.Windows.Forms.TextBox();
            this.m_addr_txt = new System.Windows.Forms.TextBox();
            this.m_phone_txt = new System.Windows.Forms.TextBox();
            this.m_name_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.t_del_btn = new System.Windows.Forms.Button();
            this.t_edit_btn = new System.Windows.Forms.Button();
            this.t_career_txt = new System.Windows.Forms.TextBox();
            this.t_gender_txt = new System.Windows.Forms.TextBox();
            this.t_age_txt = new System.Windows.Forms.TextBox();
            this.t_name_txt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trainer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.dataGridView_member);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 276);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원정보 통합 조회";
            // 
            // dataGridView_member
            // 
            this.dataGridView_member.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_member.Location = new System.Drawing.Point(18, 20);
            this.dataGridView_member.Name = "dataGridView_member";
            this.dataGridView_member.RowTemplate.Height = 23;
            this.dataGridView_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_member.Size = new System.Drawing.Size(622, 245);
            this.dataGridView_member.TabIndex = 0;
            this.dataGridView_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_member_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_trainer);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "트레이너 통합 조회";
            // 
            // dataGridView_trainer
            // 
            this.dataGridView_trainer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_trainer.Location = new System.Drawing.Point(17, 20);
            this.dataGridView_trainer.Name = "dataGridView_trainer";
            this.dataGridView_trainer.RowTemplate.Height = 23;
            this.dataGridView_trainer.Size = new System.Drawing.Size(623, 150);
            this.dataGridView_trainer.TabIndex = 0;
            this.dataGridView_trainer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_trainer_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_trainer_txt);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.del_btn);
            this.groupBox4.Controls.Add(this.edit_btn);
            this.groupBox4.Controls.Add(this.m_end_txt);
            this.groupBox4.Controls.Add(this.m_start_txt);
            this.groupBox4.Controls.Add(this.m_pt_txt);
            this.groupBox4.Controls.Add(this.m_lent_txt);
            this.groupBox4.Controls.Add(this.m_membership_txt);
            this.groupBox4.Controls.Add(this.m_bmi_txt);
            this.groupBox4.Controls.Add(this.m_weight_txt);
            this.groupBox4.Controls.Add(this.m_height_txt);
            this.groupBox4.Controls.Add(this.m_gender_txt);
            this.groupBox4.Controls.Add(this.m_age_txt);
            this.groupBox4.Controls.Add(this.m_addr_txt);
            this.groupBox4.Controls.Add(this.m_phone_txt);
            this.groupBox4.Controls.Add(this.m_name_txt);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(694, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 275);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "회원 정보 수정/삭제";
            // 
            // m_trainer_txt
            // 
            this.m_trainer_txt.Location = new System.Drawing.Point(317, 145);
            this.m_trainer_txt.Name = "m_trainer_txt";
            this.m_trainer_txt.Size = new System.Drawing.Size(154, 21);
            this.m_trainer_txt.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(226, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 12);
            this.label18.TabIndex = 28;
            this.label18.Text = "담당 트레이너:";
            // 
            // del_btn
            // 
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Location = new System.Drawing.Point(384, 241);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(87, 23);
            this.del_btn.TabIndex = 27;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Location = new System.Drawing.Point(291, 241);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(87, 23);
            this.edit_btn.TabIndex = 26;
            this.edit_btn.Text = "수정";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // m_end_txt
            // 
            this.m_end_txt.Location = new System.Drawing.Point(291, 202);
            this.m_end_txt.Name = "m_end_txt";
            this.m_end_txt.Size = new System.Drawing.Size(180, 21);
            this.m_end_txt.TabIndex = 25;
            // 
            // m_start_txt
            // 
            this.m_start_txt.Location = new System.Drawing.Point(291, 174);
            this.m_start_txt.Name = "m_start_txt";
            this.m_start_txt.Size = new System.Drawing.Size(180, 21);
            this.m_start_txt.TabIndex = 24;
            // 
            // m_pt_txt
            // 
            this.m_pt_txt.Location = new System.Drawing.Point(291, 118);
            this.m_pt_txt.Name = "m_pt_txt";
            this.m_pt_txt.Size = new System.Drawing.Size(180, 21);
            this.m_pt_txt.TabIndex = 23;
            // 
            // m_lent_txt
            // 
            this.m_lent_txt.Location = new System.Drawing.Point(291, 90);
            this.m_lent_txt.Name = "m_lent_txt";
            this.m_lent_txt.Size = new System.Drawing.Size(180, 21);
            this.m_lent_txt.TabIndex = 22;
            // 
            // m_membership_txt
            // 
            this.m_membership_txt.Location = new System.Drawing.Point(291, 62);
            this.m_membership_txt.Name = "m_membership_txt";
            this.m_membership_txt.Size = new System.Drawing.Size(180, 21);
            this.m_membership_txt.TabIndex = 21;
            // 
            // m_bmi_txt
            // 
            this.m_bmi_txt.Location = new System.Drawing.Point(291, 34);
            this.m_bmi_txt.Name = "m_bmi_txt";
            this.m_bmi_txt.Size = new System.Drawing.Size(180, 21);
            this.m_bmi_txt.TabIndex = 20;
            // 
            // m_weight_txt
            // 
            this.m_weight_txt.Location = new System.Drawing.Point(73, 202);
            this.m_weight_txt.Name = "m_weight_txt";
            this.m_weight_txt.Size = new System.Drawing.Size(147, 21);
            this.m_weight_txt.TabIndex = 19;
            // 
            // m_height_txt
            // 
            this.m_height_txt.Location = new System.Drawing.Point(73, 174);
            this.m_height_txt.Name = "m_height_txt";
            this.m_height_txt.Size = new System.Drawing.Size(147, 21);
            this.m_height_txt.TabIndex = 18;
            // 
            // m_gender_txt
            // 
            this.m_gender_txt.Location = new System.Drawing.Point(73, 146);
            this.m_gender_txt.Name = "m_gender_txt";
            this.m_gender_txt.Size = new System.Drawing.Size(147, 21);
            this.m_gender_txt.TabIndex = 17;
            // 
            // m_age_txt
            // 
            this.m_age_txt.Location = new System.Drawing.Point(73, 118);
            this.m_age_txt.Name = "m_age_txt";
            this.m_age_txt.Size = new System.Drawing.Size(147, 21);
            this.m_age_txt.TabIndex = 16;
            // 
            // m_addr_txt
            // 
            this.m_addr_txt.Location = new System.Drawing.Point(73, 90);
            this.m_addr_txt.Name = "m_addr_txt";
            this.m_addr_txt.Size = new System.Drawing.Size(147, 21);
            this.m_addr_txt.TabIndex = 15;
            // 
            // m_phone_txt
            // 
            this.m_phone_txt.Location = new System.Drawing.Point(73, 62);
            this.m_phone_txt.Name = "m_phone_txt";
            this.m_phone_txt.Size = new System.Drawing.Size(147, 21);
            this.m_phone_txt.TabIndex = 14;
            // 
            // m_name_txt
            // 
            this.m_name_txt.Location = new System.Drawing.Point(73, 34);
            this.m_name_txt.Name = "m_name_txt";
            this.m_name_txt.Size = new System.Drawing.Size(147, 21);
            this.m_name_txt.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(232, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "종료일 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "시작일 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "PT : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "대여 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "회원권 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "bmi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "몸무게 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "신장 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "나이 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "전화 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.t_del_btn);
            this.groupBox5.Controls.Add(this.t_edit_btn);
            this.groupBox5.Controls.Add(this.t_career_txt);
            this.groupBox5.Controls.Add(this.t_gender_txt);
            this.groupBox5.Controls.Add(this.t_age_txt);
            this.groupBox5.Controls.Add(this.t_name_txt);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(695, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(476, 195);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "트레이너 정보 수정 / 삭제";
            // 
            // t_del_btn
            // 
            this.t_del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t_del_btn.Location = new System.Drawing.Point(383, 162);
            this.t_del_btn.Name = "t_del_btn";
            this.t_del_btn.Size = new System.Drawing.Size(87, 23);
            this.t_del_btn.TabIndex = 28;
            this.t_del_btn.Text = "삭제";
            this.t_del_btn.UseVisualStyleBackColor = true;
            this.t_del_btn.Click += new System.EventHandler(this.t_del_btn_Click);
            // 
            // t_edit_btn
            // 
            this.t_edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t_edit_btn.Location = new System.Drawing.Point(290, 162);
            this.t_edit_btn.Name = "t_edit_btn";
            this.t_edit_btn.Size = new System.Drawing.Size(87, 23);
            this.t_edit_btn.TabIndex = 27;
            this.t_edit_btn.Text = "수정";
            this.t_edit_btn.UseVisualStyleBackColor = true;
            this.t_edit_btn.Click += new System.EventHandler(this.t_edit_btn_Click);
            // 
            // t_career_txt
            // 
            this.t_career_txt.Location = new System.Drawing.Point(91, 148);
            this.t_career_txt.Name = "t_career_txt";
            this.t_career_txt.Size = new System.Drawing.Size(100, 21);
            this.t_career_txt.TabIndex = 7;
            // 
            // t_gender_txt
            // 
            this.t_gender_txt.Location = new System.Drawing.Point(91, 110);
            this.t_gender_txt.Name = "t_gender_txt";
            this.t_gender_txt.Size = new System.Drawing.Size(100, 21);
            this.t_gender_txt.TabIndex = 6;
            // 
            // t_age_txt
            // 
            this.t_age_txt.Location = new System.Drawing.Point(91, 69);
            this.t_age_txt.Name = "t_age_txt";
            this.t_age_txt.Size = new System.Drawing.Size(100, 21);
            this.t_age_txt.TabIndex = 5;
            // 
            // t_name_txt
            // 
            this.t_name_txt.Location = new System.Drawing.Point(91, 24);
            this.t_name_txt.Name = "t_name_txt";
            this.t_name_txt.Size = new System.Drawing.Size(100, 21);
            this.t_name_txt.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "경력 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "성별 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "나이 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "이름 :";
            // 
            // totalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 506);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "totalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "관리자용 통합 조회";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_trainer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_member;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_trainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox m_end_txt;
        private System.Windows.Forms.TextBox m_start_txt;
        private System.Windows.Forms.TextBox m_pt_txt;
        private System.Windows.Forms.TextBox m_lent_txt;
        private System.Windows.Forms.TextBox m_membership_txt;
        private System.Windows.Forms.TextBox m_bmi_txt;
        private System.Windows.Forms.TextBox m_weight_txt;
        private System.Windows.Forms.TextBox m_height_txt;
        private System.Windows.Forms.TextBox m_gender_txt;
        private System.Windows.Forms.TextBox m_age_txt;
        private System.Windows.Forms.TextBox m_addr_txt;
        private System.Windows.Forms.TextBox m_phone_txt;
        private System.Windows.Forms.TextBox m_name_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox t_career_txt;
        private System.Windows.Forms.TextBox t_gender_txt;
        private System.Windows.Forms.TextBox t_age_txt;
        private System.Windows.Forms.TextBox t_name_txt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button t_del_btn;
        private System.Windows.Forms.Button t_edit_btn;
        private System.Windows.Forms.TextBox m_trainer_txt;
        private System.Windows.Forms.Label label18;
    }
}