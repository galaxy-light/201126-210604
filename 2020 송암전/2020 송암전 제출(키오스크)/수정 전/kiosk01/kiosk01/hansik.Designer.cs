
namespace haksik_menu
{
    partial class hansik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hansik));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.userControl22 = new haksik_menu.UserControl2();
            this.userControl21 = new haksik_menu.UserControl2();
            this.userControl11 = new haksik_menu.UserControl1();
            this.userControl31 = new haksik_menu.UserControl3();
            this.userControl41 = new haksik_menu.UserControl4();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Controls.Add(this.userControl41);
            this.flowLayoutPanel1.Controls.Add(this.userControl31);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 65);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 469);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(570, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 164);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "25000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "총합";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "20%";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(21, 67);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "이벤트 할인";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "35000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "합계";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 43);
            this.label6.TabIndex = 9;
            this.label6.Text = "한식";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(570, 470);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(374, 45);
            this.button9.TabIndex = 10;
            this.button9.Text = "주문하기";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // userControl22
            // 
            this.userControl22.BackColor = System.Drawing.Color.White;
            this.userControl22.Location = new System.Drawing.Point(528, 150);
            this.userControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(434, 62);
            this.userControl22.TabIndex = 12;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Location = new System.Drawing.Point(528, 82);
            this.userControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(434, 62);
            this.userControl21.TabIndex = 11;
            // 
            // userControl11
            // 
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl11.Location = new System.Drawing.Point(3, 2);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(247, 165);
            this.userControl11.TabIndex = 0;
            // 
            // userControl31
            // 
            this.userControl31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl31.BackgroundImage")));
            this.userControl31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl31.Location = new System.Drawing.Point(3, 171);
            this.userControl31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(247, 165);
            this.userControl31.TabIndex = 1;
            // 
            // userControl41
            // 
            this.userControl41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl41.BackgroundImage")));
            this.userControl41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl41.Location = new System.Drawing.Point(256, 2);
            this.userControl41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(247, 165);
            this.userControl41.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 536);
            this.Controls.Add(this.userControl22);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private UserControl2 userControl21;
        private UserControl2 userControl22;
        private UserControl1 userControl11;
        private UserControl4 userControl41;
        private UserControl3 userControl31;
    }
}

