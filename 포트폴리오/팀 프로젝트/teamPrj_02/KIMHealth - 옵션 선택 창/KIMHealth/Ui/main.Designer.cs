
namespace KIMHealth
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_change = new Sunny.UI.UIImageButton();
            this.manage = new Sunny.UI.UIImageButton();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.uiButton_1 = new Sunny.UI.UIButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.uiButton_2 = new Sunny.UI.UIButton();
            this.uiButton_3 = new Sunny.UI.UIButton();
            this.uiButton_4 = new Sunny.UI.UIButton();
            this.uiButton_5 = new Sunny.UI.UIButton();
            this.uiButton_6 = new Sunny.UI.UIButton();
            this.uiButton_7 = new Sunny.UI.UIButton();
            this.uiButton_8 = new Sunny.UI.UIButton();
            this.uiButton_9 = new Sunny.UI.UIButton();
            this.uiButton_0 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.add_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(477, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(99, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "KIM\'s Gym에 오신것을 환영합니다!";
            // 
            // add_change
            // 
            this.add_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_change.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.add_change.Image = ((System.Drawing.Image)(resources.GetObject("add_change.Image")));
            this.add_change.Location = new System.Drawing.Point(751, 12);
            this.add_change.Name = "add_change";
            this.add_change.Size = new System.Drawing.Size(37, 34);
            this.add_change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_change.TabIndex = 4;
            this.add_change.TabStop = false;
            this.add_change.Text = null;
            this.add_change.Click += new System.EventHandler(this.add_change_Click);
            // 
            // manage
            // 
            this.manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.manage.Image = ((System.Drawing.Image)(resources.GetObject("manage.Image")));
            this.manage.Location = new System.Drawing.Point(703, 12);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(42, 34);
            this.manage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manage.TabIndex = 5;
            this.manage.TabStop = false;
            this.manage.Text = null;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_id.Location = new System.Drawing.Point(556, 235);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(174, 24);
            this.textBox_id.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(520, 466);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(619, 466);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(75, 23);
            this.outButton.TabIndex = 7;
            this.outButton.Text = "Out";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // uiButton_1
            // 
            this.uiButton_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_1.Location = new System.Drawing.Point(538, 290);
            this.uiButton_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_1.Name = "uiButton_1";
            this.uiButton_1.Size = new System.Drawing.Size(39, 35);
            this.uiButton_1.TabIndex = 8;
            this.uiButton_1.Text = "1";
            this.uiButton_1.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 235);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // uiButton_2
            // 
            this.uiButton_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_2.Location = new System.Drawing.Point(588, 290);
            this.uiButton_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_2.Name = "uiButton_2";
            this.uiButton_2.Size = new System.Drawing.Size(39, 35);
            this.uiButton_2.TabIndex = 10;
            this.uiButton_2.Text = "2";
            this.uiButton_2.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_3
            // 
            this.uiButton_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_3.Location = new System.Drawing.Point(638, 290);
            this.uiButton_3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_3.Name = "uiButton_3";
            this.uiButton_3.Size = new System.Drawing.Size(39, 35);
            this.uiButton_3.TabIndex = 11;
            this.uiButton_3.Text = "3";
            this.uiButton_3.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_4
            // 
            this.uiButton_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_4.Location = new System.Drawing.Point(538, 331);
            this.uiButton_4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_4.Name = "uiButton_4";
            this.uiButton_4.Size = new System.Drawing.Size(39, 35);
            this.uiButton_4.TabIndex = 12;
            this.uiButton_4.Text = "4";
            this.uiButton_4.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_5
            // 
            this.uiButton_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_5.Location = new System.Drawing.Point(588, 331);
            this.uiButton_5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_5.Name = "uiButton_5";
            this.uiButton_5.Size = new System.Drawing.Size(39, 35);
            this.uiButton_5.TabIndex = 13;
            this.uiButton_5.Text = "5";
            this.uiButton_5.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_6
            // 
            this.uiButton_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_6.Location = new System.Drawing.Point(638, 331);
            this.uiButton_6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_6.Name = "uiButton_6";
            this.uiButton_6.Size = new System.Drawing.Size(39, 35);
            this.uiButton_6.TabIndex = 14;
            this.uiButton_6.Text = "6";
            this.uiButton_6.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_7
            // 
            this.uiButton_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_7.Location = new System.Drawing.Point(538, 372);
            this.uiButton_7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_7.Name = "uiButton_7";
            this.uiButton_7.Size = new System.Drawing.Size(39, 35);
            this.uiButton_7.TabIndex = 15;
            this.uiButton_7.Text = "7";
            this.uiButton_7.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_8
            // 
            this.uiButton_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_8.Location = new System.Drawing.Point(588, 372);
            this.uiButton_8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_8.Name = "uiButton_8";
            this.uiButton_8.Size = new System.Drawing.Size(39, 35);
            this.uiButton_8.TabIndex = 16;
            this.uiButton_8.Text = "8";
            this.uiButton_8.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_9
            // 
            this.uiButton_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_9.Location = new System.Drawing.Point(638, 372);
            this.uiButton_9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_9.Name = "uiButton_9";
            this.uiButton_9.Size = new System.Drawing.Size(39, 35);
            this.uiButton_9.TabIndex = 17;
            this.uiButton_9.Text = "9";
            this.uiButton_9.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // uiButton_0
            // 
            this.uiButton_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_0.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_0.Location = new System.Drawing.Point(588, 413);
            this.uiButton_0.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_0.Name = "uiButton_0";
            this.uiButton_0.Size = new System.Drawing.Size(39, 35);
            this.uiButton_0.TabIndex = 18;
            this.uiButton_0.Text = "0";
            this.uiButton_0.Click += new System.EventHandler(this.bnt_number_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.uiButton_0);
            this.Controls.Add(this.uiButton_9);
            this.Controls.Add(this.uiButton_8);
            this.Controls.Add(this.uiButton_7);
            this.Controls.Add(this.uiButton_6);
            this.Controls.Add(this.uiButton_5);
            this.Controls.Add(this.uiButton_4);
            this.Controls.Add(this.uiButton_3);
            this.Controls.Add(this.uiButton_2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.uiButton_1);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.add_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            ((System.ComponentModel.ISupportInitialize)(this.add_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIImageButton add_change;
        private Sunny.UI.UIImageButton manage;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button outButton;
        private Sunny.UI.UIButton uiButton_1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Sunny.UI.UIButton uiButton_2;
        private Sunny.UI.UIButton uiButton_3;
        private Sunny.UI.UIButton uiButton_4;
        private Sunny.UI.UIButton uiButton_5;
        private Sunny.UI.UIButton uiButton_6;
        private Sunny.UI.UIButton uiButton_7;
        private Sunny.UI.UIButton uiButton_8;
        private Sunny.UI.UIButton uiButton_9;
        private Sunny.UI.UIButton uiButton_0;
    }
}

