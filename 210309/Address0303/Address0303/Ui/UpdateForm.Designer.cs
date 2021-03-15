
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
            this.redata = new Sunny.UI.UISymbolLabel();
            this.exnameBox = new Sunny.UI.UITextBox();
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
            this.extelBox = new Sunny.UI.UITextBox();
            this.exaddressBox = new Sunny.UI.UITextBox();
            this.exemailBox = new Sunny.UI.UITextBox();
            this.exnamech = new Sunny.UI.UICheckBox();
            this.extelch = new Sunny.UI.UICheckBox();
            this.exaddressch = new Sunny.UI.UICheckBox();
            this.exemailch = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // redata
            // 
            this.redata.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.redata.Location = new System.Drawing.Point(19, 354);
            this.redata.MinimumSize = new System.Drawing.Size(1, 1);
            this.redata.Name = "redata";
            this.redata.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.redata.Size = new System.Drawing.Size(125, 34);
            this.redata.TabIndex = 1;
            this.redata.Text = "변경 데이터";
            this.redata.Click += new System.EventHandler(this.redata_Click);
            // 
            // exnameBox
            // 
            this.exnameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exnameBox.FillColor = System.Drawing.Color.White;
            this.exnameBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exnameBox.Location = new System.Drawing.Point(96, 263);
            this.exnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exnameBox.Maximum = 2147483647D;
            this.exnameBox.Minimum = -2147483648D;
            this.exnameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exnameBox.Name = "exnameBox";
            this.exnameBox.Padding = new System.Windows.Forms.Padding(5);
            this.exnameBox.Size = new System.Drawing.Size(273, 29);
            this.exnameBox.TabIndex = 8;
            // 
            // redataBox
            // 
            this.redataBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.redataBox.FillColor = System.Drawing.Color.White;
            this.redataBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.redataBox.Location = new System.Drawing.Point(151, 357);
            this.redataBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redataBox.Maximum = 2147483647D;
            this.redataBox.Minimum = -2147483648D;
            this.redataBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.redataBox.Name = "redataBox";
            this.redataBox.Padding = new System.Windows.Forms.Padding(5);
            this.redataBox.Size = new System.Drawing.Size(602, 29);
            this.redataBox.TabIndex = 9;
            this.redataBox.TextChanged += new System.EventHandler(this.redataBox_TextChanged);
            // 
            // updateExit
            // 
            this.updateExit.BackColor = System.Drawing.Color.Transparent;
            this.updateExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.updateExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateExit.Location = new System.Drawing.Point(419, 400);
            this.updateExit.Name = "updateExit";
            this.updateExit.Size = new System.Drawing.Size(84, 35);
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
            this.addrUpdate.Location = new System.Drawing.Point(300, 400);
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
            this.uplistView.Size = new System.Drawing.Size(754, 183);
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
            // extelBox
            // 
            this.extelBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.extelBox.FillColor = System.Drawing.Color.White;
            this.extelBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.extelBox.Location = new System.Drawing.Point(481, 263);
            this.extelBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extelBox.Maximum = 2147483647D;
            this.extelBox.Minimum = -2147483648D;
            this.extelBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.extelBox.Name = "extelBox";
            this.extelBox.Padding = new System.Windows.Forms.Padding(5);
            this.extelBox.Size = new System.Drawing.Size(273, 29);
            this.extelBox.TabIndex = 10;
            this.extelBox.TextChanged += new System.EventHandler(this.extelBox_TextChanged);
            // 
            // exaddressBox
            // 
            this.exaddressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exaddressBox.FillColor = System.Drawing.Color.White;
            this.exaddressBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exaddressBox.Location = new System.Drawing.Point(96, 307);
            this.exaddressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exaddressBox.Maximum = 2147483647D;
            this.exaddressBox.Minimum = -2147483648D;
            this.exaddressBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exaddressBox.Name = "exaddressBox";
            this.exaddressBox.Padding = new System.Windows.Forms.Padding(5);
            this.exaddressBox.Size = new System.Drawing.Size(273, 29);
            this.exaddressBox.TabIndex = 12;
            this.exaddressBox.TextChanged += new System.EventHandler(this.exaddressBox_TextChanged);
            // 
            // exemailBox
            // 
            this.exemailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exemailBox.FillColor = System.Drawing.Color.White;
            this.exemailBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exemailBox.Location = new System.Drawing.Point(481, 307);
            this.exemailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exemailBox.Maximum = 2147483647D;
            this.exemailBox.Minimum = -2147483648D;
            this.exemailBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exemailBox.Name = "exemailBox";
            this.exemailBox.Padding = new System.Windows.Forms.Padding(5);
            this.exemailBox.Size = new System.Drawing.Size(273, 29);
            this.exemailBox.TabIndex = 14;
            this.exemailBox.TextChanged += new System.EventHandler(this.exemailBox_TextChanged);
            // 
            // exnamech
            // 
            this.exnamech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exnamech.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exnamech.Location = new System.Drawing.Point(21, 263);
            this.exnamech.MinimumSize = new System.Drawing.Size(1, 1);
            this.exnamech.Name = "exnamech";
            this.exnamech.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.exnamech.Size = new System.Drawing.Size(68, 29);
            this.exnamech.TabIndex = 40;
            this.exnamech.Text = "이름";
            this.exnamech.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.exnamech_ValueChanged);
            // 
            // extelch
            // 
            this.extelch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extelch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.extelch.Location = new System.Drawing.Point(376, 263);
            this.extelch.MinimumSize = new System.Drawing.Size(1, 1);
            this.extelch.Name = "extelch";
            this.extelch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.extelch.Size = new System.Drawing.Size(98, 29);
            this.extelch.TabIndex = 41;
            this.extelch.Text = "전화 번호";
            this.extelch.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.extelch_ValueChanged);
            // 
            // exaddressch
            // 
            this.exaddressch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exaddressch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exaddressch.Location = new System.Drawing.Point(21, 307);
            this.exaddressch.MinimumSize = new System.Drawing.Size(1, 1);
            this.exaddressch.Name = "exaddressch";
            this.exaddressch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.exaddressch.Size = new System.Drawing.Size(68, 29);
            this.exaddressch.TabIndex = 42;
            this.exaddressch.Text = "주소";
            this.exaddressch.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.exaddressch_ValueChanged);
            // 
            // exemailch
            // 
            this.exemailch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exemailch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exemailch.Location = new System.Drawing.Point(376, 307);
            this.exemailch.MinimumSize = new System.Drawing.Size(1, 1);
            this.exemailch.Name = "exemailch";
            this.exemailch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.exemailch.Size = new System.Drawing.Size(98, 29);
            this.exemailch.TabIndex = 43;
            this.exemailch.Text = "이메일";
            this.exemailch.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.exemailch_ValueChanged);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.exemailch);
            this.Controls.Add(this.exaddressch);
            this.Controls.Add(this.extelch);
            this.Controls.Add(this.exnamech);
            this.Controls.Add(this.exemailBox);
            this.Controls.Add(this.exaddressBox);
            this.Controls.Add(this.extelBox);
            this.Controls.Add(this.arrHelp);
            this.Controls.Add(this.uplistView);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.updateExit);
            this.Controls.Add(this.redataBox);
            this.Controls.Add(this.exnameBox);
            this.Controls.Add(this.redata);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 변경";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolLabel redata;
        private Sunny.UI.UITextBox exnameBox;
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
        private Sunny.UI.UITextBox extelBox;
        private Sunny.UI.UITextBox exaddressBox;
        private Sunny.UI.UITextBox exemailBox;
        private Sunny.UI.UICheckBox exnamech;
        private Sunny.UI.UICheckBox extelch;
        private Sunny.UI.UICheckBox exaddressch;
        private Sunny.UI.UICheckBox exemailch;
    }
}