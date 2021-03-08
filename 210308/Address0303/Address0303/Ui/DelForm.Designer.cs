
namespace Address0308.Ui
{
    partial class DelForm
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
            this.delName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.nameDelete = new CxFlatUI.CxFlatRoundButton();
            this.delTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.telDelete = new CxFlatUI.CxFlatRoundButton();
            this.delAddress = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addressDelete = new CxFlatUI.CxFlatRoundButton();
            this.delEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.emailDelete = new CxFlatUI.CxFlatRoundButton();
            this.deleteExit = new CxFlatUI.CxFlatRoundButton();
            this.allDeleteBox = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alladdrDel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // delName
            // 
            this.delName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delName.FillColor = System.Drawing.Color.White;
            this.delName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delName.Location = new System.Drawing.Point(137, 291);
            this.delName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delName.Maximum = 2147483647D;
            this.delName.Minimum = -2147483648D;
            this.delName.MinimumSize = new System.Drawing.Size(1, 1);
            this.delName.Name = "delName";
            this.delName.Padding = new System.Windows.Forms.Padding(5);
            this.delName.Size = new System.Drawing.Size(164, 29);
            this.delName.TabIndex = 20;
            this.delName.TextChanged += new System.EventHandler(this.delName_TextChanged);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(15, 288);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(110, 35);
            this.uiSymbolLabel1.TabIndex = 18;
            this.uiSymbolLabel1.Text = "삭제 이름";
            // 
            // nameDelete
            // 
            this.nameDelete.BackColor = System.Drawing.Color.Transparent;
            this.nameDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.nameDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameDelete.Location = new System.Drawing.Point(313, 285);
            this.nameDelete.Name = "nameDelete";
            this.nameDelete.Size = new System.Drawing.Size(84, 40);
            this.nameDelete.TabIndex = 25;
            this.nameDelete.Text = "삭제";
            this.nameDelete.TextColor = System.Drawing.Color.White;
            this.nameDelete.Click += new System.EventHandler(this.nameDelete_Click);
            // 
            // delTel
            // 
            this.delTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delTel.FillColor = System.Drawing.Color.White;
            this.delTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delTel.Location = new System.Drawing.Point(137, 349);
            this.delTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delTel.Maximum = 2147483647D;
            this.delTel.Minimum = -2147483648D;
            this.delTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.delTel.Name = "delTel";
            this.delTel.Padding = new System.Windows.Forms.Padding(5);
            this.delTel.Size = new System.Drawing.Size(164, 29);
            this.delTel.TabIndex = 24;
            this.delTel.TextChanged += new System.EventHandler(this.delTel_TextChanged);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(15, 346);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(110, 35);
            this.uiSymbolLabel2.TabIndex = 23;
            this.uiSymbolLabel2.Text = "삭제 전화";
            // 
            // telDelete
            // 
            this.telDelete.BackColor = System.Drawing.Color.Transparent;
            this.telDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.telDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.telDelete.Location = new System.Drawing.Point(313, 344);
            this.telDelete.Name = "telDelete";
            this.telDelete.Size = new System.Drawing.Size(84, 40);
            this.telDelete.TabIndex = 28;
            this.telDelete.Text = "삭제";
            this.telDelete.TextColor = System.Drawing.Color.White;
            this.telDelete.Click += new System.EventHandler(this.telDelete_Click);
            // 
            // delAddress
            // 
            this.delAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delAddress.FillColor = System.Drawing.Color.White;
            this.delAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delAddress.Location = new System.Drawing.Point(530, 291);
            this.delAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delAddress.Maximum = 2147483647D;
            this.delAddress.Minimum = -2147483648D;
            this.delAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.delAddress.Name = "delAddress";
            this.delAddress.Padding = new System.Windows.Forms.Padding(5);
            this.delAddress.Size = new System.Drawing.Size(164, 29);
            this.delAddress.TabIndex = 27;
            this.delAddress.TextChanged += new System.EventHandler(this.delAddress_TextChanged);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(408, 288);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(110, 35);
            this.uiSymbolLabel3.TabIndex = 26;
            this.uiSymbolLabel3.Text = "삭제 주소";
            // 
            // addressDelete
            // 
            this.addressDelete.BackColor = System.Drawing.Color.Transparent;
            this.addressDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.addressDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addressDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressDelete.Location = new System.Drawing.Point(706, 286);
            this.addressDelete.Name = "addressDelete";
            this.addressDelete.Size = new System.Drawing.Size(84, 40);
            this.addressDelete.TabIndex = 31;
            this.addressDelete.Text = "삭제";
            this.addressDelete.TextColor = System.Drawing.Color.White;
            this.addressDelete.Click += new System.EventHandler(this.addressDelete_Click);
            // 
            // delEmail
            // 
            this.delEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delEmail.FillColor = System.Drawing.Color.White;
            this.delEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delEmail.Location = new System.Drawing.Point(530, 348);
            this.delEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delEmail.Maximum = 2147483647D;
            this.delEmail.Minimum = -2147483648D;
            this.delEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.delEmail.Name = "delEmail";
            this.delEmail.Padding = new System.Windows.Forms.Padding(5);
            this.delEmail.Size = new System.Drawing.Size(164, 29);
            this.delEmail.TabIndex = 30;
            this.delEmail.TextChanged += new System.EventHandler(this.delEmail_TextChanged);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(408, 345);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(110, 35);
            this.uiSymbolLabel4.TabIndex = 29;
            this.uiSymbolLabel4.Text = "삭제 이메일";
            // 
            // emailDelete
            // 
            this.emailDelete.BackColor = System.Drawing.Color.Transparent;
            this.emailDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.emailDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailDelete.Location = new System.Drawing.Point(706, 343);
            this.emailDelete.Name = "emailDelete";
            this.emailDelete.Size = new System.Drawing.Size(84, 40);
            this.emailDelete.TabIndex = 32;
            this.emailDelete.Text = "삭제";
            this.emailDelete.TextColor = System.Drawing.Color.White;
            this.emailDelete.Click += new System.EventHandler(this.emailDelete_Click);
            // 
            // deleteExit
            // 
            this.deleteExit.BackColor = System.Drawing.Color.Transparent;
            this.deleteExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.deleteExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteExit.Location = new System.Drawing.Point(357, 398);
            this.deleteExit.Name = "deleteExit";
            this.deleteExit.Size = new System.Drawing.Size(84, 40);
            this.deleteExit.TabIndex = 34;
            this.deleteExit.Text = "닫기";
            this.deleteExit.TextColor = System.Drawing.Color.White;
            this.deleteExit.Click += new System.EventHandler(this.deleteExit_Click);
            // 
            // allDeleteBox
            // 
            this.allDeleteBox.AutoSize = true;
            this.allDeleteBox.BackColor = System.Drawing.Color.Transparent;
            this.allDeleteBox.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.allDeleteBox.ForeColor = System.Drawing.Color.White;
            this.allDeleteBox.Location = new System.Drawing.Point(526, 38);
            this.allDeleteBox.Name = "allDeleteBox";
            this.allDeleteBox.Size = new System.Drawing.Size(174, 22);
            this.allDeleteBox.TabIndex = 35;
            this.allDeleteBox.Text = "주소록 전체 삭제";
            this.allDeleteBox.UseVisualStyleBackColor = false;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_address,
            this.list_email});
            this.listView.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 84);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 195);
            this.listView.TabIndex = 36;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            this.list_count.Width = 110;
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 120;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전 화";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 150;
            // 
            // list_address
            // 
            this.list_address.Text = "주 소";
            this.list_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_address.Width = 200;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 160;
            // 
            // alladdrDel
            // 
            this.alladdrDel.BackColor = System.Drawing.Color.Transparent;
            this.alladdrDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alladdrDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.alladdrDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.alladdrDel.Location = new System.Drawing.Point(702, 35);
            this.alladdrDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.alladdrDel.Name = "alladdrDel";
            this.alladdrDel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.alladdrDel.Size = new System.Drawing.Size(71, 25);
            this.alladdrDel.Style = Sunny.UI.UIStyle.Custom;
            this.alladdrDel.TabIndex = 37;
            this.alladdrDel.Text = "삭제";
            this.alladdrDel.Click += new System.EventHandler(this.alladdrDel_Click);
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alladdrDel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.allDeleteBox);
            this.Controls.Add(this.deleteExit);
            this.Controls.Add(this.emailDelete);
            this.Controls.Add(this.addressDelete);
            this.Controls.Add(this.telDelete);
            this.Controls.Add(this.delEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.nameDelete);
            this.Controls.Add(this.delAddress);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.delTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.delName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 삭제";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox delName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatRoundButton nameDelete;
        private Sunny.UI.UITextBox delTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatRoundButton telDelete;
        private Sunny.UI.UITextBox delAddress;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatRoundButton addressDelete;
        private Sunny.UI.UITextBox delEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatRoundButton emailDelete;
        private CxFlatUI.CxFlatRoundButton deleteExit;
        private System.Windows.Forms.CheckBox allDeleteBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_address;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UIButton alladdrDel;
    }
}