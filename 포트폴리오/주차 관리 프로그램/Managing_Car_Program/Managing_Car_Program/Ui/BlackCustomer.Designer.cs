
namespace Managing_Car_Program.Ui
{
    partial class BlackCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_carnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_phnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(32, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_num,
            this.columnHeader_nm,
            this.columnHeader_carnum,
            this.columnHeader_phnum,
            this.columnHeader_text});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(728, 264);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_num
            // 
            this.columnHeader_num.Text = "번호";
            this.columnHeader_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_num.Width = 100;
            // 
            // columnHeader_nm
            // 
            this.columnHeader_nm.Text = "이름";
            this.columnHeader_nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_nm.Width = 150;
            // 
            // columnHeader_carnum
            // 
            this.columnHeader_carnum.Text = "차량번호";
            this.columnHeader_carnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_carnum.Width = 150;
            // 
            // columnHeader_phnum
            // 
            this.columnHeader_phnum.Text = "전화번호";
            this.columnHeader_phnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_phnum.Width = 150;
            // 
            // columnHeader_text
            // 
            this.columnHeader_text.Text = "등록사유";
            this.columnHeader_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_text.Width = 180;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(354, 408);
            this.button_close.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(92, 35);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // BlackCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox1);
            this.Name = "BlackCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "블랙리스트";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_num;
        private System.Windows.Forms.ColumnHeader columnHeader_nm;
        private System.Windows.Forms.ColumnHeader columnHeader_carnum;
        private System.Windows.Forms.ColumnHeader columnHeader_phnum;
        private System.Windows.Forms.ColumnHeader columnHeader_text;
        private System.Windows.Forms.Button button_close;
    }
}