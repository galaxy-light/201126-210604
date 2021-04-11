
namespace WindowsFormsApp0408
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.randombutton = new Sunny.UI.UISymbolButton();
            this.texttext = new System.Windows.Forms.TextBox();
            this.linkbutton = new Sunny.UI.UISymbolButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // randombutton
            // 
            this.randombutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randombutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(86)))), ((int)(((byte)(159)))));
            this.randombutton.FillHoverColor = System.Drawing.Color.LightSkyBlue;
            this.randombutton.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randombutton.Location = new System.Drawing.Point(428, 189);
            this.randombutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.randombutton.Name = "randombutton";
            this.randombutton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(86)))), ((int)(((byte)(159)))));
            this.randombutton.RectHoverColor = System.Drawing.Color.LightSkyBlue;
            this.randombutton.Size = new System.Drawing.Size(231, 74);
            this.randombutton.Style = Sunny.UI.UIStyle.Custom;
            this.randombutton.Symbol = 61736;
            this.randombutton.SymbolSize = 50;
            this.randombutton.TabIndex = 8;
            this.randombutton.Text = "역전 VS 여전";
            this.randombutton.Click += new System.EventHandler(this.randombutton_Click);
            // 
            // texttext
            // 
            this.texttext.BackColor = System.Drawing.Color.White;
            this.texttext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttext.Font = new System.Drawing.Font("문체부 제목 바탕체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.texttext.Location = new System.Drawing.Point(519, 401);
            this.texttext.Multiline = true;
            this.texttext.Name = "texttext";
            this.texttext.Size = new System.Drawing.Size(200, 50);
            this.texttext.TabIndex = 9;
            this.texttext.Text = "나만 잘 되게 해주세요.\r\n꼭 나만..";
            // 
            // linkbutton
            // 
            this.linkbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkbutton.FillColor = System.Drawing.Color.Transparent;
            this.linkbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.linkbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.linkbutton.ForeHoverColor = System.Drawing.Color.Crimson;
            this.linkbutton.Location = new System.Drawing.Point(5, 414);
            this.linkbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.linkbutton.Name = "linkbutton";
            this.linkbutton.RectColor = System.Drawing.Color.Transparent;
            this.linkbutton.RectHoverColor = System.Drawing.Color.Transparent;
            this.linkbutton.RectPressColor = System.Drawing.Color.Transparent;
            this.linkbutton.Size = new System.Drawing.Size(31, 34);
            this.linkbutton.Style = Sunny.UI.UIStyle.Custom;
            this.linkbutton.Symbol = 62059;
            this.linkbutton.SymbolSize = 30;
            this.linkbutton.TabIndex = 10;
            this.linkbutton.Click += new System.EventHandler(this.linkbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.linkbutton);
            this.Controls.Add(this.texttext);
            this.Controls.Add(this.randombutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Hoxy...?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton randombutton;
        private System.Windows.Forms.TextBox texttext;
        private Sunny.UI.UISymbolButton linkbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

