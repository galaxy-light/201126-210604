
namespace Address0303.Ui
{
    partial class UpdateForm
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
            this.exdata = new Sunny.UI.UISymbolLabel();
            this.redata = new Sunny.UI.UISymbolLabel();
            this.exdataBox = new Sunny.UI.UITextBox();
            this.redataBox = new Sunny.UI.UITextBox();
            this.updateExit = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.uplistView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrHelp = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // exdata
            // 
            this.exdata.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exdata.Location = new System.Drawing.Point(123, 309);
            this.exdata.MinimumSize = new System.Drawing.Size(1, 1);
            this.exdata.Name = "exdata";
            this.exdata.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.exdata.Size = new System.Drawing.Size(158, 40);
            this.exdata.TabIndex = 0;
            this.exdata.Text = "변경 전 데이터";
            this.exdata.Click += new System.EventHandler(this.exdata_Click);
            // 
            // redata
            // 
            this.redata.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.redata.Location = new System.Drawing.Point(123, 349);
            this.redata.MinimumSize = new System.Drawing.Size(1, 1);
            this.redata.Name = "redata";
            this.redata.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.redata.Size = new System.Drawing.Size(158, 40);
            this.redata.TabIndex = 1;
            this.redata.Text = "변경 후 데이터";
            this.redata.Click += new System.EventHandler(this.redata_Click);
            // 
            // exdataBox
            // 
            this.exdataBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exdataBox.FillColor = System.Drawing.Color.White;
            this.exdataBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exdataBox.Location = new System.Drawing.Point(281, 315);
            this.exdataBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exdataBox.Maximum = 2147483647D;
            this.exdataBox.Minimum = -2147483648D;
            this.exdataBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exdataBox.Name = "exdataBox";
            this.exdataBox.Padding = new System.Windows.Forms.Padding(5);
            this.exdataBox.Size = new System.Drawing.Size(468, 29);
            this.exdataBox.TabIndex = 8;
            this.exdataBox.TextChanged += new System.EventHandler(this.exdataBox_TextChanged);
            // 
            // redataBox
            // 
            this.redataBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.redataBox.FillColor = System.Drawing.Color.White;
            this.redataBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.redataBox.Location = new System.Drawing.Point(281, 357);
            this.redataBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redataBox.Maximum = 2147483647D;
            this.redataBox.Minimum = -2147483648D;
            this.redataBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.redataBox.Name = "redataBox";
            this.redataBox.Padding = new System.Windows.Forms.Padding(5);
            this.redataBox.Size = new System.Drawing.Size(468, 29);
            this.redataBox.TabIndex = 9;
            this.redataBox.TextChanged += new System.EventHandler(this.redataBox_TextChanged);
            // 
            // updateExit
            // 
            this.updateExit.BackColor = System.Drawing.Color.Transparent;
            this.updateExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.updateExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateExit.Location = new System.Drawing.Point(348, 400);
            this.updateExit.Name = "updateExit";
            this.updateExit.Size = new System.Drawing.Size(84, 39);
            this.updateExit.TabIndex = 16;
            this.updateExit.Text = "닫기";
            this.updateExit.TextColor = System.Drawing.Color.White;
            this.updateExit.Click += new System.EventHandler(this.updateExit_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.BackColor = System.Drawing.Color.Transparent;
            this.addrUpdate.ButtonType = CxFlatUI.ButtonType.Success;
            this.addrUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrUpdate.Location = new System.Drawing.Point(33, 331);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(84, 35);
            this.addrUpdate.TabIndex = 17;
            this.addrUpdate.Text = "변경";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // uplistView
            // 
            this.uplistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_address,
            this.list_email});
            this.uplistView.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uplistView.FullRowSelect = true;
            this.uplistView.HideSelection = false;
            this.uplistView.Location = new System.Drawing.Point(12, 72);
            this.uplistView.Name = "uplistView";
            this.uplistView.Size = new System.Drawing.Size(754, 231);
            this.uplistView.TabIndex = 37;
            this.uplistView.UseCompatibleStateImageBehavior = false;
            this.uplistView.View = System.Windows.Forms.View.Details;
            this.uplistView.SelectedIndexChanged += new System.EventHandler(this.uplistView_SelectedIndexChanged);
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
            this.list_tel.Text = "전화 번호";
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
            // arrHelp
            // 
            this.arrHelp.BackColor = System.Drawing.Color.Transparent;
            this.arrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrHelp.FillColor = System.Drawing.Color.LightSkyBlue;
            this.arrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.arrHelp.IsCircle = true;
            this.arrHelp.Location = new System.Drawing.Point(123, 26);
            this.arrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.arrHelp.Name = "arrHelp";
            this.arrHelp.RectColor = System.Drawing.Color.LightSkyBlue;
            this.arrHelp.Size = new System.Drawing.Size(31, 29);
            this.arrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.arrHelp.Symbol = 61736;
            this.arrHelp.TabIndex = 38;
            this.arrHelp.Click += new System.EventHandler(this.arrHelp_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.arrHelp);
            this.Controls.Add(this.uplistView);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.updateExit);
            this.Controls.Add(this.redataBox);
            this.Controls.Add(this.exdataBox);
            this.Controls.Add(this.redata);
            this.Controls.Add(this.exdata);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 변경";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel exdata;
        private Sunny.UI.UISymbolLabel redata;
        private Sunny.UI.UITextBox exdataBox;
        private Sunny.UI.UITextBox redataBox;
        private CxFlatUI.CxFlatRoundButton updateExit;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private System.Windows.Forms.ListView uplistView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_address;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UISymbolButton arrHelp;
    }
}