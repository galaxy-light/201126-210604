
namespace CarManager0323
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.BackColor = System.Drawing.Color.Transparent;
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.createTB.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(569, 27);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.createTB.RectDisableColor = System.Drawing.Color.White;
            this.createTB.Size = new System.Drawing.Size(100, 35);
            this.createTB.Style = Sunny.UI.UIStyle.Custom;
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블 생성";
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.BackColor = System.Drawing.Color.Transparent;
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.dropTB.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(675, 27);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.dropTB.RectDisableColor = System.Drawing.Color.White;
            this.dropTB.Size = new System.Drawing.Size(100, 35);
            this.dropTB.Style = Sunny.UI.UIStyle.Custom;
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "테이블 삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

