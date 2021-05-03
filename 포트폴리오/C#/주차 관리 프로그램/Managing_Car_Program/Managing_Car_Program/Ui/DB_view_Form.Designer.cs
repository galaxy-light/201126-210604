
namespace Managing_Car_Program.Ui
{
    partial class DB_view_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_carnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 25);
            this.panel1.TabIndex = 32;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id,
            this.columnHeader_name,
            this.columnHeader_carnumber,
            this.columnHeader_phone,
            this.columnHeader_start,
            this.columnHeader_end});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 311);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_id
            // 
            this.columnHeader_id.Text = "번호";
            this.columnHeader_id.Width = 50;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "이름";
            this.columnHeader_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_name.Width = 100;
            // 
            // columnHeader_carnumber
            // 
            this.columnHeader_carnumber.Text = "차량번호";
            this.columnHeader_carnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_carnumber.Width = 130;
            // 
            // columnHeader_phone
            // 
            this.columnHeader_phone.Text = "전화번호";
            this.columnHeader_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_phone.Width = 150;
            // 
            // columnHeader_start
            // 
            this.columnHeader_start.Text = "정기권 시작일";
            this.columnHeader_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_start.Width = 170;
            // 
            // columnHeader_end
            // 
            this.columnHeader_end.Text = "정기권 종료일";
            this.columnHeader_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_end.Width = 170;
            // 
            // DB_view_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "DB_view_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base";
            this.Load += new System.EventHandler(this.DB_view_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_carnumber;
        private System.Windows.Forms.ColumnHeader columnHeader_phone;
        private System.Windows.Forms.ColumnHeader columnHeader_start;
        private System.Windows.Forms.ColumnHeader columnHeader_end;
    }
}