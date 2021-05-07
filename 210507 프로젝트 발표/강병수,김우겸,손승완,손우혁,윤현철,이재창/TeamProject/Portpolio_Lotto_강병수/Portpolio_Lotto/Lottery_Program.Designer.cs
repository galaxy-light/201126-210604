
namespace Portpolio_Lotto
{
    partial class Lottery_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lottery_Program));
            this.label1 = new System.Windows.Forms.Label();
            this.Prev_Num1 = new System.Windows.Forms.TextBox();
            this.Prev_Num2 = new System.Windows.Forms.TextBox();
            this.Prev_Num3 = new System.Windows.Forms.TextBox();
            this.Prev_Num4 = new System.Windows.Forms.TextBox();
            this.Prev_Num5 = new System.Windows.Forms.TextBox();
            this.Prev_Num6 = new System.Windows.Forms.TextBox();
            this.Prev_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Week_Number = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "지난 회차의 로또 당첨 번호 입력";
            // 
            // Prev_Num1
            // 
            this.Prev_Num1.Location = new System.Drawing.Point(447, 83);
            this.Prev_Num1.Name = "Prev_Num1";
            this.Prev_Num1.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num1.TabIndex = 1;
            // 
            // Prev_Num2
            // 
            this.Prev_Num2.Location = new System.Drawing.Point(574, 83);
            this.Prev_Num2.Name = "Prev_Num2";
            this.Prev_Num2.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num2.TabIndex = 2;
            // 
            // Prev_Num3
            // 
            this.Prev_Num3.Location = new System.Drawing.Point(700, 83);
            this.Prev_Num3.Name = "Prev_Num3";
            this.Prev_Num3.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num3.TabIndex = 3;
            // 
            // Prev_Num4
            // 
            this.Prev_Num4.Location = new System.Drawing.Point(447, 173);
            this.Prev_Num4.Name = "Prev_Num4";
            this.Prev_Num4.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num4.TabIndex = 4;
            // 
            // Prev_Num5
            // 
            this.Prev_Num5.Location = new System.Drawing.Point(574, 173);
            this.Prev_Num5.Name = "Prev_Num5";
            this.Prev_Num5.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num5.TabIndex = 5;
            // 
            // Prev_Num6
            // 
            this.Prev_Num6.Location = new System.Drawing.Point(700, 173);
            this.Prev_Num6.Name = "Prev_Num6";
            this.Prev_Num6.Size = new System.Drawing.Size(46, 21);
            this.Prev_Num6.TabIndex = 6;
            // 
            // Prev_Save
            // 
            this.Prev_Save.Location = new System.Drawing.Point(682, 200);
            this.Prev_Save.Name = "Prev_Save";
            this.Prev_Save.Size = new System.Drawing.Size(75, 23);
            this.Prev_Save.TabIndex = 7;
            this.Prev_Save.Text = "번호 저장";
            this.Prev_Save.UseVisualStyleBackColor = true;
            this.Prev_Save.Click += new System.EventHandler(this.Prev_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "첫번째 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "두번째 번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "세번째 번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "네번째 번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "다섯번째 번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "여섯번쨰 번호";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Week_Number
            // 
            this.Week_Number.Location = new System.Drawing.Point(502, 244);
            this.Week_Number.Name = "Week_Number";
            this.Week_Number.Size = new System.Drawing.Size(169, 51);
            this.Week_Number.TabIndex = 10;
            this.Week_Number.Text = "이번주에 뜰 번호는?";
            this.Week_Number.UseVisualStyleBackColor = true;
            this.Week_Number.Click += new System.EventHandler(this.Week_Number_Click);
            // 
            // Lottery_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 305);
            this.Controls.Add(this.Week_Number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prev_Save);
            this.Controls.Add(this.Prev_Num6);
            this.Controls.Add(this.Prev_Num5);
            this.Controls.Add(this.Prev_Num4);
            this.Controls.Add(this.Prev_Num3);
            this.Controls.Add(this.Prev_Num2);
            this.Controls.Add(this.Prev_Num1);
            this.Controls.Add(this.label1);
            this.Name = "Lottery_Program";
            this.Text = "로또 번호 예상 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prev_Num1;
        private System.Windows.Forms.TextBox Prev_Num2;
        private System.Windows.Forms.TextBox Prev_Num3;
        private System.Windows.Forms.TextBox Prev_Num4;
        private System.Windows.Forms.TextBox Prev_Num5;
        private System.Windows.Forms.TextBox Prev_Num6;
        private System.Windows.Forms.Button Prev_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Week_Number;
    }
}

