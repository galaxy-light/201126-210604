
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
            this.delnameBox = new Sunny.UI.UITextBox();
            this.delnamelabel = new Sunny.UI.UISymbolLabel();
            this.idDelete = new CxFlatUI.CxFlatRoundButton();
            this.deleteExit = new CxFlatUI.CxFlatRoundButton();
            this.allDeleteBox = new System.Windows.Forms.CheckBox();
            this.dellistView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alladdrDel = new Sunny.UI.UIButton();
            this.arrHelp = new Sunny.UI.UISymbolButton();
            this.deltelBox = new Sunny.UI.UITextBox();
            this.deltellabel = new Sunny.UI.UISymbolLabel();
            this.deladdressBox = new Sunny.UI.UITextBox();
            this.deladdresslabel = new Sunny.UI.UISymbolLabel();
            this.delemailBox = new Sunny.UI.UITextBox();
            this.delemaillabel = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // delnameBox
            // 
            this.delnameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delnameBox.FillColor = System.Drawing.Color.White;
            this.delnameBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delnameBox.Location = new System.Drawing.Point(97, 291);
            this.delnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delnameBox.Maximum = 2147483647D;
            this.delnameBox.Minimum = -2147483648D;
            this.delnameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.delnameBox.Name = "delnameBox";
            this.delnameBox.Padding = new System.Windows.Forms.Padding(5);
            this.delnameBox.Size = new System.Drawing.Size(277, 29);
            this.delnameBox.TabIndex = 20;
            this.delnameBox.TextChanged += new System.EventHandler(this.delNameBox_TextChanged);
            // 
            // delnamelabel
            // 
            this.delnamelabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delnamelabel.Location = new System.Drawing.Point(6, 289);
            this.delnamelabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.delnamelabel.Name = "delnamelabel";
            this.delnamelabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.delnamelabel.Size = new System.Drawing.Size(84, 29);
            this.delnamelabel.TabIndex = 18;
            this.delnamelabel.Text = "이름";
            this.delnamelabel.Click += new System.EventHandler(this.dellabel_Click);
            // 
            // idDelete
            // 
            this.idDelete.BackColor = System.Drawing.Color.Transparent;
            this.idDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.idDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idDelete.Location = new System.Drawing.Point(304, 398);
            this.idDelete.Name = "idDelete";
            this.idDelete.Size = new System.Drawing.Size(84, 40);
            this.idDelete.TabIndex = 25;
            this.idDelete.Text = "삭제";
            this.idDelete.TextColor = System.Drawing.Color.White;
            this.idDelete.Click += new System.EventHandler(this.idDelete_Click);
            // 
            // deleteExit
            // 
            this.deleteExit.BackColor = System.Drawing.Color.Transparent;
            this.deleteExit.ButtonType = CxFlatUI.ButtonType.Primary;
            this.deleteExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteExit.Location = new System.Drawing.Point(410, 398);
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
            // dellistView
            // 
            this.dellistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_address,
            this.list_email});
            this.dellistView.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dellistView.FullRowSelect = true;
            this.dellistView.HideSelection = false;
            this.dellistView.Location = new System.Drawing.Point(12, 72);
            this.dellistView.Name = "dellistView";
            this.dellistView.Size = new System.Drawing.Size(776, 203);
            this.dellistView.TabIndex = 36;
            this.dellistView.UseCompatibleStateImageBehavior = false;
            this.dellistView.View = System.Windows.Forms.View.Details;
            this.dellistView.SelectedIndexChanged += new System.EventHandler(this.dellistView_SelectedIndexChanged);
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
            this.arrHelp.TabIndex = 39;
            this.arrHelp.Click += new System.EventHandler(this.arrHelp_Click);
            // 
            // deltelBox
            // 
            this.deltelBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deltelBox.FillColor = System.Drawing.Color.White;
            this.deltelBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deltelBox.Location = new System.Drawing.Point(484, 291);
            this.deltelBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deltelBox.Maximum = 2147483647D;
            this.deltelBox.Minimum = -2147483648D;
            this.deltelBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.deltelBox.Name = "deltelBox";
            this.deltelBox.Padding = new System.Windows.Forms.Padding(5);
            this.deltelBox.Size = new System.Drawing.Size(298, 29);
            this.deltelBox.TabIndex = 22;
            this.deltelBox.TextChanged += new System.EventHandler(this.deltelBox_TextChanged);
            // 
            // deltellabel
            // 
            this.deltellabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deltellabel.Location = new System.Drawing.Point(381, 291);
            this.deltellabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.deltellabel.Name = "deltellabel";
            this.deltellabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.deltellabel.Size = new System.Drawing.Size(96, 29);
            this.deltellabel.TabIndex = 21;
            this.deltellabel.Text = "전화 번호";
            // 
            // deladdressBox
            // 
            this.deladdressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deladdressBox.FillColor = System.Drawing.Color.White;
            this.deladdressBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deladdressBox.Location = new System.Drawing.Point(97, 340);
            this.deladdressBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deladdressBox.Maximum = 2147483647D;
            this.deladdressBox.Minimum = -2147483648D;
            this.deladdressBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.deladdressBox.Name = "deladdressBox";
            this.deladdressBox.Padding = new System.Windows.Forms.Padding(5);
            this.deladdressBox.Size = new System.Drawing.Size(277, 29);
            this.deladdressBox.TabIndex = 24;
            this.deladdressBox.TextChanged += new System.EventHandler(this.deladdressBox_TextChanged);
            // 
            // deladdresslabel
            // 
            this.deladdresslabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deladdresslabel.Location = new System.Drawing.Point(6, 338);
            this.deladdresslabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.deladdresslabel.Name = "deladdresslabel";
            this.deladdresslabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.deladdresslabel.Size = new System.Drawing.Size(84, 29);
            this.deladdresslabel.TabIndex = 23;
            this.deladdresslabel.Text = "주소";
            // 
            // delemailBox
            // 
            this.delemailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delemailBox.FillColor = System.Drawing.Color.White;
            this.delemailBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delemailBox.Location = new System.Drawing.Point(484, 340);
            this.delemailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delemailBox.Maximum = 2147483647D;
            this.delemailBox.Minimum = -2147483648D;
            this.delemailBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.delemailBox.Name = "delemailBox";
            this.delemailBox.Padding = new System.Windows.Forms.Padding(5);
            this.delemailBox.Size = new System.Drawing.Size(298, 29);
            this.delemailBox.TabIndex = 26;
            this.delemailBox.TextChanged += new System.EventHandler(this.delemailBox_TextChanged);
            // 
            // delemaillabel
            // 
            this.delemaillabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delemaillabel.Location = new System.Drawing.Point(381, 340);
            this.delemaillabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.delemaillabel.Name = "delemaillabel";
            this.delemaillabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.delemaillabel.Size = new System.Drawing.Size(96, 29);
            this.delemaillabel.TabIndex = 25;
            this.delemaillabel.Text = "이메일";
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delemailBox);
            this.Controls.Add(this.delemaillabel);
            this.Controls.Add(this.deladdressBox);
            this.Controls.Add(this.deladdresslabel);
            this.Controls.Add(this.deltelBox);
            this.Controls.Add(this.deltellabel);
            this.Controls.Add(this.arrHelp);
            this.Controls.Add(this.alladdrDel);
            this.Controls.Add(this.dellistView);
            this.Controls.Add(this.allDeleteBox);
            this.Controls.Add(this.deleteExit);
            this.Controls.Add(this.idDelete);
            this.Controls.Add(this.delnameBox);
            this.Controls.Add(this.delnamelabel);
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 삭제";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox delnameBox;
        private Sunny.UI.UISymbolLabel delnamelabel;
        private CxFlatUI.CxFlatRoundButton idDelete;
        private CxFlatUI.CxFlatRoundButton deleteExit;
        private System.Windows.Forms.CheckBox allDeleteBox;
        private System.Windows.Forms.ListView dellistView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_address;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UIButton alladdrDel;
        private Sunny.UI.UISymbolButton arrHelp;
        private Sunny.UI.UITextBox deltelBox;
        private Sunny.UI.UISymbolLabel deltellabel;
        private Sunny.UI.UITextBox deladdressBox;
        private Sunny.UI.UISymbolLabel deladdresslabel;
        private Sunny.UI.UITextBox delemailBox;
        private Sunny.UI.UISymbolLabel delemaillabel;
    }
}