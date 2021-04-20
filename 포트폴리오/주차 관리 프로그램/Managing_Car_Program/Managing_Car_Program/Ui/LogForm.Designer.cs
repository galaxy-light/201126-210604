
namespace Managing_Car_Program
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pw = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(424, 147);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(148, 21);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(424, 191);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(148, 21);
            this.textBox_pw.TabIndex = 1;
            this.textBox_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pw_KeyPress);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(377, 150);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(41, 12);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "아이디";
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.BackColor = System.Drawing.Color.White;
            this.label_pw.Location = new System.Drawing.Point(365, 194);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(53, 12);
            this.label_pw.TabIndex = 3;
            this.label_pw.Text = "비밀번호";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(441, 247);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(84, 30);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_pw);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "관리자 로그인";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}