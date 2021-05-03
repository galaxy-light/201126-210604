
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.uiSymbolButton_refresh = new Sunny.UI.UISymbolButton();
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
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 25);
            this.panel1.TabIndex = 32;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(462, 410);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(88, 30);
            this.button_search.TabIndex = 39;
            this.button_search.Text = "조회";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(354, 415);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 21);
            this.textBox.TabIndex = 38;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(295, 420);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 12);
            this.label.TabIndex = 37;
            this.label.Text = "차량번호";
            // 
            // uiSymbolButton_refresh
            // 
            this.uiSymbolButton_refresh.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_refresh.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_refresh.Location = new System.Drawing.Point(153, 29);
            this.uiSymbolButton_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_refresh.Name = "uiSymbolButton_refresh";
            this.uiSymbolButton_refresh.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_refresh.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_refresh.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_refresh.Symbol = 61470;
            this.uiSymbolButton_refresh.SymbolSize = 30;
            this.uiSymbolButton_refresh.TabIndex = 40;
            this.uiSymbolButton_refresh.Click += new System.EventHandler(this.uiSymbolButton_refresh_Click);
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
            this.listView1.Location = new System.Drawing.Point(47, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 286);
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
            this.columnHeader_name.Width = 101;
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
            this.ClientSize = new System.Drawing.Size(871, 491);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.uiSymbolButton_refresh);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Name = "DB_view_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정기권 Data Base";
            this.Load += new System.EventHandler(this.DB_view_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private Sunny.UI.UISymbolButton uiSymbolButton_refresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_id;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_carnumber;
        private System.Windows.Forms.ColumnHeader columnHeader_phone;
        private System.Windows.Forms.ColumnHeader columnHeader_start;
        private System.Windows.Forms.ColumnHeader columnHeader_end;
    }
}