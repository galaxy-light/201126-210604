namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label_1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.BackColor = System.Drawing.Color.Lime;
            this.label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_1.Location = new System.Drawing.Point(23, 13);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(47, 33);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "0";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_1.Click += new System.EventHandler(this.label_1_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(483, 19);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 33);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_7
            // 
            this.label_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_7.Location = new System.Drawing.Point(414, 19);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(50, 33);
            this.label_7.TabIndex = 7;
            this.label_7.Text = "-";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_6
            // 
            this.label_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_6.Location = new System.Drawing.Point(284, 13);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(51, 33);
            this.label_6.TabIndex = 5;
            this.label_6.Text = "0";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_5
            // 
            this.label_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_5.Location = new System.Drawing.Point(231, 13);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(47, 33);
            this.label_5.TabIndex = 4;
            this.label_5.Text = "0";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_4
            // 
            this.label_4.BackColor = System.Drawing.Color.Yellow;
            this.label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_4.Location = new System.Drawing.Point(184, 13);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(41, 33);
            this.label_4.TabIndex = 3;
            this.label_4.Text = "0";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_3
            // 
            this.label_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(131, 13);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(47, 33);
            this.label_3.TabIndex = 2;
            this.label_3.Text = "0";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_2.Location = new System.Drawing.Point(76, 13);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(49, 33);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "0";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "뽀나스";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 94);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_7);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_7;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label1;
    }
}

