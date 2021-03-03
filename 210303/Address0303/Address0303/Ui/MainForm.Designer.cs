
namespace Address0303
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
            this.addrAdd = new CxFlatUI.CxFlatRoundButton();
            this.addrView = new CxFlatUI.CxFlatRoundButton();
            this.addrRand = new CxFlatUI.CxFlatRoundButton();
            this.addrDel = new CxFlatUI.CxFlatRoundButton();
            this.addrAllDel = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.arrHelp = new Sunny.UI.UISymbolButton();
            this.arrExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrAdd
            // 
            this.addrAdd.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrAdd.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrAdd.Location = new System.Drawing.Point(428, 82);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Size = new System.Drawing.Size(280, 46);
            this.addrAdd.TabIndex = 0;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.TextColor = System.Drawing.Color.White;
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // addrView
            // 
            this.addrView.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrView.Location = new System.Drawing.Point(459, 144);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(280, 46);
            this.addrView.TabIndex = 1;
            this.addrView.Text = "주소록 보기";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrRand
            // 
            this.addrRand.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrRand.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrRand.Location = new System.Drawing.Point(428, 206);
            this.addrRand.Name = "addrRand";
            this.addrRand.Size = new System.Drawing.Size(280, 46);
            this.addrRand.TabIndex = 2;
            this.addrRand.Text = "랜덤 주소록 추가";
            this.addrRand.TextColor = System.Drawing.Color.White;
            this.addrRand.Click += new System.EventHandler(this.addrRand_Click);
            // 
            // addrDel
            // 
            this.addrDel.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrDel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrDel.Location = new System.Drawing.Point(446, 268);
            this.addrDel.Name = "addrDel";
            this.addrDel.Size = new System.Drawing.Size(280, 46);
            this.addrDel.TabIndex = 3;
            this.addrDel.Text = "특정 주소록 삭제";
            this.addrDel.TextColor = System.Drawing.Color.White;
            this.addrDel.Click += new System.EventHandler(this.addrDel_Click);
            // 
            // addrAllDel
            // 
            this.addrAllDel.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrAllDel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrAllDel.Location = new System.Drawing.Point(428, 330);
            this.addrAllDel.Name = "addrAllDel";
            this.addrAllDel.Size = new System.Drawing.Size(280, 46);
            this.addrAllDel.TabIndex = 4;
            this.addrAllDel.Text = "주소록 전체 삭제";
            this.addrAllDel.TextColor = System.Drawing.Color.White;
            this.addrAllDel.Click += new System.EventHandler(this.addrAllDel_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrUpdate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addrUpdate.Location = new System.Drawing.Point(446, 392);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(280, 46);
            this.addrUpdate.TabIndex = 5;
            this.addrUpdate.Text = "주소록 수정";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(12, 71);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(374, 369);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cxFlatPictureBox1.TabIndex = 6;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 30);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(229, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 7;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 1.0";
            // 
            // arrHelp
            // 
            this.arrHelp.BackColor = System.Drawing.Color.Transparent;
            this.arrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrHelp.FillColor = System.Drawing.Color.HotPink;
            this.arrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.arrHelp.IsCircle = true;
            this.arrHelp.Location = new System.Drawing.Point(673, 30);
            this.arrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.arrHelp.Name = "arrHelp";
            this.arrHelp.RectColor = System.Drawing.Color.HotPink;
            this.arrHelp.Size = new System.Drawing.Size(53, 39);
            this.arrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.arrHelp.Symbol = 61736;
            this.arrHelp.TabIndex = 8;
            this.arrHelp.Click += new System.EventHandler(this.arrHelp_Click);
            // 
            // arrExit
            // 
            this.arrExit.BackColor = System.Drawing.Color.Transparent;
            this.arrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.arrExit.IsCircle = true;
            this.arrExit.Location = new System.Drawing.Point(732, 30);
            this.arrExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.arrExit.Name = "arrExit";
            this.arrExit.Size = new System.Drawing.Size(48, 39);
            this.arrExit.Symbol = 61453;
            this.arrExit.TabIndex = 9;
            this.arrExit.Click += new System.EventHandler(this.arrExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.arrExit);
            this.Controls.Add(this.arrHelp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.addrAllDel);
            this.Controls.Add(this.addrDel);
            this.Controls.Add(this.addrRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.addrAdd);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton addrAdd;
        private CxFlatUI.CxFlatRoundButton addrView;
        private CxFlatUI.CxFlatRoundButton addrRand;
        private CxFlatUI.CxFlatRoundButton addrDel;
        private CxFlatUI.CxFlatRoundButton addrAllDel;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton arrHelp;
        private Sunny.UI.UISymbolButton arrExit;
    }
}

