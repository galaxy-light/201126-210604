
namespace WindowsFormsApp0406
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
            this.yeartextbox = new System.Windows.Forms.TextBox();
            this.yearconvert = new System.Windows.Forms.Button();
            this.yearresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yeartextbox
            // 
            this.yeartextbox.Location = new System.Drawing.Point(49, 53);
            this.yeartextbox.Name = "yeartextbox";
            this.yeartextbox.Size = new System.Drawing.Size(100, 21);
            this.yeartextbox.TabIndex = 0;
            // 
            // yearconvert
            // 
            this.yearconvert.Location = new System.Drawing.Point(169, 53);
            this.yearconvert.Name = "yearconvert";
            this.yearconvert.Size = new System.Drawing.Size(75, 23);
            this.yearconvert.TabIndex = 1;
            this.yearconvert.Text = "띠 변환";
            this.yearconvert.UseVisualStyleBackColor = true;
            this.yearconvert.Click += new System.EventHandler(this.yearconvert_Click);
            // 
            // yearresult
            // 
            this.yearresult.Location = new System.Drawing.Point(265, 53);
            this.yearresult.Name = "yearresult";
            this.yearresult.Size = new System.Drawing.Size(100, 21);
            this.yearresult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearresult);
            this.Controls.Add(this.yearconvert);
            this.Controls.Add(this.yeartextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yeartextbox;
        private System.Windows.Forms.Button yearconvert;
        private System.Windows.Forms.TextBox yearresult;
    }
}

