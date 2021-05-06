
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createTB = new Sunny.UI.UISymbolButton();
            this.dropTB = new Sunny.UI.UISymbolButton();
            this.insertAll = new Sunny.UI.UISymbolButton();
            this.insertCar = new Sunny.UI.UISymbolButton();
            this.insertCustomer = new Sunny.UI.UISymbolButton();
            this.insesrtSeller = new Sunny.UI.UISymbolButton();
            this.insertDeal = new Sunny.UI.UISymbolButton();
            this.pro_Exit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.DateView = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // createTB
            // 
            this.createTB.BackColor = System.Drawing.Color.Transparent;
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.FillColor = System.Drawing.Color.Transparent;
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(704, 27);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.RectColor = System.Drawing.Color.Transparent;
            this.createTB.Size = new System.Drawing.Size(35, 35);
            this.createTB.Style = Sunny.UI.UIStyle.Custom;
            this.createTB.Symbol = 61543;
            this.createTB.SymbolSize = 30;
            this.createTB.TabIndex = 3;
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.BackColor = System.Drawing.Color.Transparent;
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.FillColor = System.Drawing.Color.Transparent;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(745, 27);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.RectColor = System.Drawing.Color.Transparent;
            this.dropTB.Size = new System.Drawing.Size(34, 35);
            this.dropTB.Style = Sunny.UI.UIStyle.Custom;
            this.dropTB.Symbol = 61544;
            this.dropTB.SymbolSize = 30;
            this.dropTB.TabIndex = 4;
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // insertAll
            // 
            this.insertAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertAll.Location = new System.Drawing.Point(22, 447);
            this.insertAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertAll.Name = "insertAll";
            this.insertAll.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertAll.Size = new System.Drawing.Size(227, 35);
            this.insertAll.Style = Sunny.UI.UIStyle.Custom;
            this.insertAll.Symbol = 61584;
            this.insertAll.TabIndex = 5;
            this.insertAll.Text = "모든 데이터 추가";
            this.insertAll.Click += new System.EventHandler(this.insertAll_Click);
            // 
            // insertCar
            // 
            this.insertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCar.Location = new System.Drawing.Point(286, 447);
            this.insertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCar.Name = "insertCar";
            this.insertCar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertCar.Size = new System.Drawing.Size(227, 35);
            this.insertCar.Style = Sunny.UI.UIStyle.Custom;
            this.insertCar.Symbol = 61882;
            this.insertCar.TabIndex = 6;
            this.insertCar.Text = "차량 정보 추가";
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertCustomer
            // 
            this.insertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCustomer.Location = new System.Drawing.Point(552, 447);
            this.insertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCustomer.Name = "insertCustomer";
            this.insertCustomer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertCustomer.Size = new System.Drawing.Size(227, 35);
            this.insertCustomer.Style = Sunny.UI.UIStyle.Custom;
            this.insertCustomer.Symbol = 61870;
            this.insertCustomer.TabIndex = 7;
            this.insertCustomer.Text = "고객 정보 추가";
            this.insertCustomer.Click += new System.EventHandler(this.insertCustomer_Click);
            // 
            // insesrtSeller
            // 
            this.insesrtSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insesrtSeller.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insesrtSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insesrtSeller.Location = new System.Drawing.Point(22, 488);
            this.insesrtSeller.MinimumSize = new System.Drawing.Size(1, 1);
            this.insesrtSeller.Name = "insesrtSeller";
            this.insesrtSeller.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insesrtSeller.Size = new System.Drawing.Size(227, 35);
            this.insesrtSeller.Style = Sunny.UI.UIStyle.Custom;
            this.insesrtSeller.Symbol = 61617;
            this.insesrtSeller.TabIndex = 8;
            this.insesrtSeller.Text = "판매자 정보 추가";
            this.insesrtSeller.Click += new System.EventHandler(this.insesrtSeller_Click);
            // 
            // insertDeal
            // 
            this.insertDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertDeal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertDeal.Location = new System.Drawing.Point(286, 488);
            this.insertDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertDeal.Name = "insertDeal";
            this.insertDeal.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.insertDeal.Size = new System.Drawing.Size(227, 35);
            this.insertDeal.Style = Sunny.UI.UIStyle.Custom;
            this.insertDeal.Symbol = 62133;
            this.insertDeal.TabIndex = 9;
            this.insertDeal.Text = "거래 정보 추가";
            this.insertDeal.Click += new System.EventHandler(this.insertDeal_Click);
            // 
            // pro_Exit
            // 
            this.pro_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pro_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pro_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.pro_Exit.Location = new System.Drawing.Point(552, 488);
            this.pro_Exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.pro_Exit.Name = "pro_Exit";
            this.pro_Exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pro_Exit.Size = new System.Drawing.Size(227, 35);
            this.pro_Exit.Style = Sunny.UI.UIStyle.Custom;
            this.pro_Exit.Symbol = 61579;
            this.pro_Exit.TabIndex = 10;
            this.pro_Exit.Text = "프로그램 종료";
            this.pro_Exit.Click += new System.EventHandler(this.pro_Exit_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FillColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.help.Location = new System.Drawing.Point(249, 27);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.Transparent;
            this.help.Size = new System.Drawing.Size(35, 35);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 61529;
            this.help.SymbolSize = 30;
            this.help.TabIndex = 11;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // DateView
            // 
            this.DateView.BackColor = System.Drawing.Color.Transparent;
            this.DateView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateView.FillColor = System.Drawing.Color.Transparent;
            this.DateView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DateView.Location = new System.Drawing.Point(663, 27);
            this.DateView.MinimumSize = new System.Drawing.Size(1, 1);
            this.DateView.Name = "DateView";
            this.DateView.RectColor = System.Drawing.Color.Transparent;
            this.DateView.Size = new System.Drawing.Size(35, 35);
            this.DateView.Style = Sunny.UI.UIStyle.Custom;
            this.DateView.Symbol = 61442;
            this.DateView.SymbolSize = 30;
            this.DateView.TabIndex = 13;
            this.DateView.Click += new System.EventHandler(this.DateView_Click);
            this.DateView.MouseHover += new System.EventHandler(this.DateView_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.DateView);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pro_Exit);
            this.Controls.Add(this.insertDeal);
            this.Controls.Add(this.insesrtSeller);
            this.Controls.Add(this.insertCustomer);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.insertAll);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton createTB;
        private Sunny.UI.UISymbolButton dropTB;
        private Sunny.UI.UISymbolButton insertAll;
        private Sunny.UI.UISymbolButton insertCar;
        private Sunny.UI.UISymbolButton insertCustomer;
        private Sunny.UI.UISymbolButton insesrtSeller;
        private Sunny.UI.UISymbolButton insertDeal;
        private Sunny.UI.UISymbolButton pro_Exit;
        private Sunny.UI.UISymbolButton help;
        private Sunny.UI.UISymbolButton DateView;
    }
}

