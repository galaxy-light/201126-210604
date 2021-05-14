
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
            this.helpbutton = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.searchbutton.FillHoverColor = System.Drawing.Color.DarkOrange;
            this.searchbutton.FillPressColor = System.Drawing.Color.DarkOrange;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchbutton.Location = new System.Drawing.Point(254, 19);
            this.searchbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.searchbutton.RectHoverColor = System.Drawing.Color.DarkOrange;
            this.searchbutton.RectPressColor = System.Drawing.Color.DarkOrange;
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
            this.dataGridView.Size = new System.Drawing.Size(675, 339);
            this.dataGridView.TabIndex = 40;
            // 
            // helpbutton
            // 
            this.helpbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbutton.FillColor = System.Drawing.Color.Tomato;
            this.helpbutton.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.helpbutton.FillPressColor = System.Drawing.Color.MediumPurple;
            this.helpbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.helpbutton.Location = new System.Drawing.Point(659, 408);
            this.helpbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.RectColor = System.Drawing.Color.Tomato;
            this.helpbutton.RectHoverColor = System.Drawing.Color.MediumPurple;
            this.helpbutton.RectPressColor = System.Drawing.Color.MediumPurple;
            this.helpbutton.Size = new System.Drawing.Size(39, 35);
            this.helpbutton.Style = Sunny.UI.UIStyle.Custom;
            this.helpbutton.Symbol = 61738;
            this.helpbutton.TabIndex = 41;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchbutton);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "역대 로또 당첨 번호";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton searchbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private Sunny.UI.UISymbolButton helpbutton;
    }
}