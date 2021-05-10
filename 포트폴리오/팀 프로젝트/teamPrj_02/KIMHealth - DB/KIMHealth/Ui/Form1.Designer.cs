
namespace KIMHealth.DB
{
    partial class manager_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.manageInput_btn = new System.Windows.Forms.Button();
            this.textBox_managerPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리모드에 진입하기 위해 암호를 입력하세요.";
            // 
            // manageInput_btn
            // 
            this.manageInput_btn.Location = new System.Drawing.Point(120, 64);
            this.manageInput_btn.Name = "manageInput_btn";
            this.manageInput_btn.Size = new System.Drawing.Size(75, 23);
            this.manageInput_btn.TabIndex = 1;
            this.manageInput_btn.Text = "입력";
            this.manageInput_btn.UseVisualStyleBackColor = true;
            this.manageInput_btn.Click += new System.EventHandler(this.manageInput_btn_Click);
            // 
            // textBox_managerPw
            // 
            this.textBox_managerPw.Location = new System.Drawing.Point(77, 32);
            this.textBox_managerPw.Name = "textBox_managerPw";
            this.textBox_managerPw.PasswordChar = '*';
            this.textBox_managerPw.Size = new System.Drawing.Size(161, 21);
            this.textBox_managerPw.TabIndex = 2;
            // 
            // manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 99);
            this.Controls.Add(this.textBox_managerPw);
            this.Controls.Add(this.manageInput_btn);
            this.Controls.Add(this.label1);
            this.Name = "manager_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "관리자용 조회";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageInput_btn;
        private System.Windows.Forms.TextBox textBox_managerPw;
    }
}