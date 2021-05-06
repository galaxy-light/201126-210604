
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
            this.components = new System.ComponentModel.Container();
            this.exnameBox = new Sunny.UI.UITextBox();
            this.updateExit = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.extelBox = new Sunny.UI.UITextBox();
            this.exaddressBox = new Sunny.UI.UITextBox();
            this.exemailBox = new Sunny.UI.UITextBox();
            this.uiLabel_name = new Sunny.UI.UILabel();
            this.uiLabel_phone = new Sunny.UI.UILabel();
            this.uiLabel_address = new Sunny.UI.UILabel();
            this.uiLabel_email = new Sunny.UI.UILabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressattriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDelete = new CxFlatUI.CxFlatRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressattriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exnameBox
            // 
            this.exnameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exnameBox.FillColor = System.Drawing.Color.White;
            this.exnameBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exnameBox.Location = new System.Drawing.Point(119, 331);
            this.exnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exnameBox.Maximum = 2147483647D;
            this.exnameBox.Minimum = -2147483648D;
            this.exnameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exnameBox.Name = "exnameBox";
            this.exnameBox.Padding = new System.Windows.Forms.Padding(5);
            this.exnameBox.Size = new System.Drawing.Size(223, 29);
            this.exnameBox.TabIndex = 8;
            // 
            // updateExit
            // 
            this.updateExit.BackColor = System.Drawing.Color.Transparent;
            this.updateExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.updateExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateExit.Location = new System.Drawing.Point(463, 432);
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
            this.addrUpdate.Location = new System.Drawing.Point(257, 432);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(84, 35);
            this.addrUpdate.TabIndex = 17;
            this.addrUpdate.Text = "수정";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // extelBox
            // 
            this.extelBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.extelBox.FillColor = System.Drawing.Color.White;
            this.extelBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.extelBox.Location = new System.Drawing.Point(529, 331);
            this.extelBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extelBox.Maximum = 2147483647D;
            this.extelBox.Minimum = -2147483648D;
            this.extelBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.extelBox.Name = "extelBox";
            this.extelBox.Padding = new System.Windows.Forms.Padding(5);
            this.extelBox.Size = new System.Drawing.Size(223, 29);
            this.extelBox.TabIndex = 10;
            // 
            // exaddressBox
            // 
            this.exaddressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exaddressBox.FillColor = System.Drawing.Color.White;
            this.exaddressBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exaddressBox.Location = new System.Drawing.Point(119, 375);
            this.exaddressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exaddressBox.Maximum = 2147483647D;
            this.exaddressBox.Minimum = -2147483648D;
            this.exaddressBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exaddressBox.Name = "exaddressBox";
            this.exaddressBox.Padding = new System.Windows.Forms.Padding(5);
            this.exaddressBox.Size = new System.Drawing.Size(223, 29);
            this.exaddressBox.TabIndex = 12;
            // 
            // exemailBox
            // 
            this.exemailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exemailBox.FillColor = System.Drawing.Color.White;
            this.exemailBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exemailBox.Location = new System.Drawing.Point(529, 375);
            this.exemailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exemailBox.Maximum = 2147483647D;
            this.exemailBox.Minimum = -2147483648D;
            this.exemailBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.exemailBox.Name = "exemailBox";
            this.exemailBox.Padding = new System.Windows.Forms.Padding(5);
            this.exemailBox.Size = new System.Drawing.Size(223, 29);
            this.exemailBox.TabIndex = 14;
            // 
            // uiLabel_name
            // 
            this.uiLabel_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel_name.Location = new System.Drawing.Point(64, 335);
            this.uiLabel_name.Name = "uiLabel_name";
            this.uiLabel_name.Size = new System.Drawing.Size(48, 23);
            this.uiLabel_name.TabIndex = 45;
            this.uiLabel_name.Text = "이름";
            this.uiLabel_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_phone
            // 
            this.uiLabel_phone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel_phone.Location = new System.Drawing.Point(445, 335);
            this.uiLabel_phone.Name = "uiLabel_phone";
            this.uiLabel_phone.Size = new System.Drawing.Size(77, 23);
            this.uiLabel_phone.TabIndex = 46;
            this.uiLabel_phone.Text = "전화번호";
            this.uiLabel_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_address
            // 
            this.uiLabel_address.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel_address.Location = new System.Drawing.Point(64, 379);
            this.uiLabel_address.Name = "uiLabel_address";
            this.uiLabel_address.Size = new System.Drawing.Size(48, 23);
            this.uiLabel_address.TabIndex = 47;
            this.uiLabel_address.Text = "주소";
            this.uiLabel_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel_email
            // 
            this.uiLabel_email.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel_email.Location = new System.Drawing.Point(450, 379);
            this.uiLabel_email.Name = "uiLabel_email";
            this.uiLabel_email.Size = new System.Drawing.Size(72, 23);
            this.uiLabel_email.TabIndex = 48;
            this.uiLabel_email.Text = "이메일";
            this.uiLabel_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressattriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 230);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "주소";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 230;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "이메일";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // addressattriBindingSource
            // 
            this.addressattriBindingSource.DataSource = typeof(AddressTest0222.Address_attri);
            // 
            // idDelete
            // 
            this.idDelete.BackColor = System.Drawing.Color.Transparent;
            this.idDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.idDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idDelete.Location = new System.Drawing.Point(359, 432);
            this.idDelete.Name = "idDelete";
            this.idDelete.Size = new System.Drawing.Size(84, 35);
            this.idDelete.TabIndex = 50;
            this.idDelete.Text = "삭제";
            this.idDelete.TextColor = System.Drawing.Color.White;
            this.idDelete.Click += new System.EventHandler(this.idDelete_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 490);
            this.Controls.Add(this.idDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uiLabel_email);
            this.Controls.Add(this.uiLabel_address);
            this.Controls.Add(this.uiLabel_phone);
            this.Controls.Add(this.uiLabel_name);
            this.Controls.Add(this.exemailBox);
            this.Controls.Add(this.exaddressBox);
            this.Controls.Add(this.extelBox);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.updateExit);
            this.Controls.Add(this.exnameBox);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 변경";
            this.Load += new System.EventHandler(this.DelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressattriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox exnameBox;
        private CxFlatUI.CxFlatRoundButton updateExit;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private Sunny.UI.UITextBox extelBox;
        private Sunny.UI.UITextBox exaddressBox;
        private Sunny.UI.UITextBox exemailBox;
        private Sunny.UI.UILabel uiLabel_name;
        private Sunny.UI.UILabel uiLabel_phone;
        private Sunny.UI.UILabel uiLabel_address;
        private Sunny.UI.UILabel uiLabel_email;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource addressattriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private CxFlatUI.CxFlatRoundButton idDelete;
    }
}