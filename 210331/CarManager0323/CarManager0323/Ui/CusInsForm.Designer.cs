
namespace CarManager0329.Ui
{
    partial class CusInsForm
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
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.addOkay = new Sunny.UI.UISymbolButton();
            this.AddCusTel = new Sunny.UI.UITextBox();
            this.AddCusAddr = new Sunny.UI.UITextBox();
            this.AddCusEmail = new Sunny.UI.UITextBox();
            this.AddCusName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.LightSalmon;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(435, 447);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.LightSalmon;
            this.addCancel.Size = new System.Drawing.Size(132, 38);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.TabIndex = 29;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addOkay
            // 
            this.addOkay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOkay.FillColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOkay.Location = new System.Drawing.Point(235, 447);
            this.addOkay.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOkay.Name = "addOkay";
            this.addOkay.RectColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Size = new System.Drawing.Size(132, 38);
            this.addOkay.Style = Sunny.UI.UIStyle.Custom;
            this.addOkay.TabIndex = 27;
            this.addOkay.Text = "확인";
            this.addOkay.Click += new System.EventHandler(this.addOkay_Click);
            // 
            // AddCusTel
            // 
            this.AddCusTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddCusTel.FillColor = System.Drawing.Color.White;
            this.AddCusTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddCusTel.Location = new System.Drawing.Point(189, 221);
            this.AddCusTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCusTel.Maximum = 2147483647D;
            this.AddCusTel.Minimum = -2147483648D;
            this.AddCusTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddCusTel.Name = "AddCusTel";
            this.AddCusTel.Padding = new System.Windows.Forms.Padding(5);
            this.AddCusTel.Size = new System.Drawing.Size(544, 29);
            this.AddCusTel.TabIndex = 23;
            // 
            // AddCusAddr
            // 
            this.AddCusAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddCusAddr.FillColor = System.Drawing.Color.White;
            this.AddCusAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddCusAddr.Location = new System.Drawing.Point(189, 293);
            this.AddCusAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCusAddr.Maximum = 2147483647D;
            this.AddCusAddr.Minimum = -2147483648D;
            this.AddCusAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddCusAddr.Name = "AddCusAddr";
            this.AddCusAddr.Padding = new System.Windows.Forms.Padding(5);
            this.AddCusAddr.Size = new System.Drawing.Size(544, 29);
            this.AddCusAddr.TabIndex = 24;
            // 
            // AddCusEmail
            // 
            this.AddCusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddCusEmail.FillColor = System.Drawing.Color.White;
            this.AddCusEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddCusEmail.Location = new System.Drawing.Point(189, 368);
            this.AddCusEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCusEmail.Maximum = 2147483647D;
            this.AddCusEmail.Minimum = -2147483648D;
            this.AddCusEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddCusEmail.Name = "AddCusEmail";
            this.AddCusEmail.Padding = new System.Windows.Forms.Padding(5);
            this.AddCusEmail.Size = new System.Drawing.Size(544, 29);
            this.AddCusEmail.TabIndex = 25;
            // 
            // AddCusName
            // 
            this.AddCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddCusName.FillColor = System.Drawing.Color.White;
            this.AddCusName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddCusName.Location = new System.Drawing.Point(189, 142);
            this.AddCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCusName.Maximum = 2147483647D;
            this.AddCusName.Minimum = -2147483648D;
            this.AddCusName.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddCusName.Name = "AddCusName";
            this.AddCusName.Padding = new System.Windows.Forms.Padding(5);
            this.AddCusName.Size = new System.Drawing.Size(544, 29);
            this.AddCusName.TabIndex = 22;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(67, 370);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(115, 29);
            this.uiSymbolLabel4.Symbol = 62059;
            this.uiSymbolLabel4.TabIndex = 21;
            this.uiSymbolLabel4.Text = "메   일";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(67, 293);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(115, 29);
            this.uiSymbolLabel3.Symbol = 61461;
            this.uiSymbolLabel3.TabIndex = 20;
            this.uiSymbolLabel3.Text = "주   소";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(67, 222);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(115, 29);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.TabIndex = 19;
            this.uiSymbolLabel2.Text = "번   호";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(67, 143);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(115, 29);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.TabIndex = 18;
            this.uiSymbolLabel1.Text = "이   름";
            // 
            // CusInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOkay);
            this.Controls.Add(this.AddCusTel);
            this.Controls.Add(this.AddCusAddr);
            this.Controls.Add(this.AddCusEmail);
            this.Controls.Add(this.AddCusName);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CusInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 정보 추가";
            this.Load += new System.EventHandler(this.CusInsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton addOkay;
        private Sunny.UI.UITextBox AddCusTel;
        private Sunny.UI.UITextBox AddCusAddr;
        private Sunny.UI.UITextBox AddCusEmail;
        private Sunny.UI.UITextBox AddCusName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}