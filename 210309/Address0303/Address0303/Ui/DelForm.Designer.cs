
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
            this.delBox = new Sunny.UI.UITextBox();
            this.dellabel = new Sunny.UI.UISymbolLabel();
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
            this.SuspendLayout();
            // 
            // delBox
            // 
            this.delBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delBox.FillColor = System.Drawing.Color.White;
            this.delBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delBox.Location = new System.Drawing.Point(392, 345);
            this.delBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delBox.Maximum = 2147483647D;
            this.delBox.Minimum = -2147483648D;
            this.delBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.delBox.Name = "delBox";
            this.delBox.Padding = new System.Windows.Forms.Padding(5);
            this.delBox.Size = new System.Drawing.Size(232, 29);
            this.delBox.TabIndex = 20;
            this.delBox.TextChanged += new System.EventHandler(this.delNameBox_TextChanged);
            // 
            // dellabel
            // 
            this.dellabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dellabel.Location = new System.Drawing.Point(268, 341);
            this.dellabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.dellabel.Name = "dellabel";
            this.dellabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.dellabel.Size = new System.Drawing.Size(117, 35);
            this.dellabel.TabIndex = 18;
            this.dellabel.Text = "전화 번호";
            this.dellabel.Click += new System.EventHandler(this.dellabel_Click);
            // 
            // idDelete
            // 
            this.idDelete.BackColor = System.Drawing.Color.Transparent;
            this.idDelete.ButtonType = CxFlatUI.ButtonType.Danger;
            this.idDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idDelete.Location = new System.Drawing.Point(176, 338);
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
            this.deleteExit.Location = new System.Drawing.Point(357, 393);
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
            this.dellistView.Size = new System.Drawing.Size(776, 251);
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
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrHelp);
            this.Controls.Add(this.alladdrDel);
            this.Controls.Add(this.dellistView);
            this.Controls.Add(this.allDeleteBox);
            this.Controls.Add(this.deleteExit);
            this.Controls.Add(this.idDelete);
            this.Controls.Add(this.delBox);
            this.Controls.Add(this.dellabel);
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 삭제";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox delBox;
        private Sunny.UI.UISymbolLabel dellabel;
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
    }
}