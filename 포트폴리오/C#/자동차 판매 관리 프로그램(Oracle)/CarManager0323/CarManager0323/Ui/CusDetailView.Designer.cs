
namespace CarManager0331.Ui
{
    partial class CusDetailView
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
            this.CusDetailList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addOkay = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // CusDetailList
            // 
            this.CusDetailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_address,
            this.list_email});
            this.CusDetailList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CusDetailList.FullRowSelect = true;
            this.CusDetailList.HideSelection = false;
            this.CusDetailList.Location = new System.Drawing.Point(11, 97);
            this.CusDetailList.Name = "CusDetailList";
            this.CusDetailList.Size = new System.Drawing.Size(779, 283);
            this.CusDetailList.TabIndex = 2;
            this.CusDetailList.UseCompatibleStateImageBehavior = false;
            this.CusDetailList.View = System.Windows.Forms.View.Details;
            this.CusDetailList.SelectedIndexChanged += new System.EventHandler(this.CusDetailList_SelectedIndexChanged);
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
            // addOkay
            // 
            this.addOkay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOkay.FillColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOkay.Location = new System.Drawing.Point(346, 419);
            this.addOkay.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOkay.Name = "addOkay";
            this.addOkay.RectColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Size = new System.Drawing.Size(109, 34);
            this.addOkay.Style = Sunny.UI.UIStyle.Custom;
            this.addOkay.TabIndex = 40;
            this.addOkay.Text = "확인";
            this.addOkay.Click += new System.EventHandler(this.addOkay_Click);
            // 
            // CusDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.addOkay);
            this.Controls.Add(this.CusDetailList);
            this.Name = "CusDetailView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 상세 정보";
            this.Load += new System.EventHandler(this.CusDetailView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CusDetailList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_address;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UISymbolButton addOkay;
    }
}