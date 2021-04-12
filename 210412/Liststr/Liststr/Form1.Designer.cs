
namespace Liststr
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
            this.text_label = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.del_label = new System.Windows.Forms.Label();
            this.button_add_12 = new System.Windows.Forms.Button();
            this.button_add_44 = new System.Windows.Forms.Button();
            this.button_add_27 = new System.Windows.Forms.Button();
            this.button_add_16 = new System.Windows.Forms.Button();
            this.button_del_12 = new System.Windows.Forms.Button();
            this.button_del_44 = new System.Windows.Forms.Button();
            this.button_del_27 = new System.Windows.Forms.Button();
            this.button_del_16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(142, 100);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(38, 12);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "label1";
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Location = new System.Drawing.Point(142, 145);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(29, 12);
            this.add_label.TabIndex = 1;
            this.add_label.Text = "추가";
            // 
            // del_label
            // 
            this.del_label.AutoSize = true;
            this.del_label.Location = new System.Drawing.Point(142, 197);
            this.del_label.Name = "del_label";
            this.del_label.Size = new System.Drawing.Size(29, 12);
            this.del_label.TabIndex = 2;
            this.del_label.Text = "제거";
            // 
            // button_add_12
            // 
            this.button_add_12.Location = new System.Drawing.Point(219, 140);
            this.button_add_12.Name = "button_add_12";
            this.button_add_12.Size = new System.Drawing.Size(75, 23);
            this.button_add_12.TabIndex = 3;
            this.button_add_12.Text = "12";
            this.button_add_12.UseVisualStyleBackColor = true;
            this.button_add_12.Click += new System.EventHandler(this.button_add_12_Click);
            // 
            // button_add_44
            // 
            this.button_add_44.Location = new System.Drawing.Point(331, 140);
            this.button_add_44.Name = "button_add_44";
            this.button_add_44.Size = new System.Drawing.Size(75, 23);
            this.button_add_44.TabIndex = 4;
            this.button_add_44.Text = "44";
            this.button_add_44.UseVisualStyleBackColor = true;
            // 
            // button_add_27
            // 
            this.button_add_27.Location = new System.Drawing.Point(439, 140);
            this.button_add_27.Name = "button_add_27";
            this.button_add_27.Size = new System.Drawing.Size(75, 23);
            this.button_add_27.TabIndex = 5;
            this.button_add_27.Text = "27";
            this.button_add_27.UseVisualStyleBackColor = true;
            // 
            // button_add_16
            // 
            this.button_add_16.Location = new System.Drawing.Point(543, 140);
            this.button_add_16.Name = "button_add_16";
            this.button_add_16.Size = new System.Drawing.Size(75, 23);
            this.button_add_16.TabIndex = 6;
            this.button_add_16.Text = "16";
            this.button_add_16.UseVisualStyleBackColor = true;
            // 
            // button_del_12
            // 
            this.button_del_12.Location = new System.Drawing.Point(219, 192);
            this.button_del_12.Name = "button_del_12";
            this.button_del_12.Size = new System.Drawing.Size(75, 23);
            this.button_del_12.TabIndex = 7;
            this.button_del_12.Text = "12";
            this.button_del_12.UseVisualStyleBackColor = true;
            // 
            // button_del_44
            // 
            this.button_del_44.Location = new System.Drawing.Point(331, 192);
            this.button_del_44.Name = "button_del_44";
            this.button_del_44.Size = new System.Drawing.Size(75, 23);
            this.button_del_44.TabIndex = 8;
            this.button_del_44.Text = "44";
            this.button_del_44.UseVisualStyleBackColor = true;
            // 
            // button_del_27
            // 
            this.button_del_27.Location = new System.Drawing.Point(439, 192);
            this.button_del_27.Name = "button_del_27";
            this.button_del_27.Size = new System.Drawing.Size(75, 23);
            this.button_del_27.TabIndex = 9;
            this.button_del_27.Text = "27";
            this.button_del_27.UseVisualStyleBackColor = true;
            // 
            // button_del_16
            // 
            this.button_del_16.Location = new System.Drawing.Point(543, 192);
            this.button_del_16.Name = "button_del_16";
            this.button_del_16.Size = new System.Drawing.Size(75, 23);
            this.button_del_16.TabIndex = 10;
            this.button_del_16.Text = "16";
            this.button_del_16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_del_16);
            this.Controls.Add(this.button_del_27);
            this.Controls.Add(this.button_del_44);
            this.Controls.Add(this.button_del_12);
            this.Controls.Add(this.button_add_16);
            this.Controls.Add(this.button_add_27);
            this.Controls.Add(this.button_add_44);
            this.Controls.Add(this.button_add_12);
            this.Controls.Add(this.del_label);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.text_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Label del_label;
        private System.Windows.Forms.Button button_add_12;
        private System.Windows.Forms.Button button_add_44;
        private System.Windows.Forms.Button button_add_27;
        private System.Windows.Forms.Button button_add_16;
        private System.Windows.Forms.Button button_del_12;
        private System.Windows.Forms.Button button_del_44;
        private System.Windows.Forms.Button button_del_27;
        private System.Windows.Forms.Button button_del_16;
    }
}

