
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiSymbolButton_help3 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(424, 147);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(148, 21);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_id_KeyDown);            
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(424, 191);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(148, 21);
            this.textBox_pw.TabIndex = 1;
            this.textBox_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pw_KeyDown);            
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 25);
            this.panel1.TabIndex = 20;
            // 
            // uiSymbolButton_help3
            // 
            this.uiSymbolButton_help3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_help3.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_help3.Location = new System.Drawing.Point(132, 30);
            this.uiSymbolButton_help3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_help3.Name = "uiSymbolButton_help3";
            this.uiSymbolButton_help3.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help3.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_help3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_help3.Symbol = 62108;
            this.uiSymbolButton_help3.SymbolSize = 35;
            this.uiSymbolButton_help3.TabIndex = 21;
            this.uiSymbolButton_help3.Click += new System.EventHandler(this.uiSymbolButton_help3_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 373);
            this.Controls.Add(this.uiSymbolButton_help3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_pw);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.KeyPreview = true;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton uiSymbolButton_help3;
    }
}