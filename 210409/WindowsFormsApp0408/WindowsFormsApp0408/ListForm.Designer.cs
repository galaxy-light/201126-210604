
namespace WindowsFormsApp0409
{
    partial class ListForm
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
            this.searchbutton = new Sunny.UI.UISymbolButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(123)))));
            this.searchbutton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(74)))));
            this.searchbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchbutton.Location = new System.Drawing.Point(254, 19);
            this.searchbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(179)))), ((int)(((byte)(123)))));
            this.searchbutton.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(119)))), ((int)(((byte)(74)))));
            this.searchbutton.Size = new System.Drawing.Size(80, 35);
            this.searchbutton.Style = Sunny.UI.UIStyle.Custom;
            this.searchbutton.Symbol = 85;
            this.searchbutton.TabIndex = 39;
            this.searchbutton.Text = "조회";
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(754, 364);
            this.dataGridView.TabIndex = 40;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchbutton);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "역대 로또 당첨 번호";
            this.Load += new System.EventHandler(this.listForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton searchbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}