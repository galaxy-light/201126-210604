
namespace Managing_Car_Program.Ui
{
    partial class Other_view_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            this.apiparkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiparkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.pcountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apiparkingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(654, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(305, 428);
            this.button_close.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(105, 33);
            this.button_close.TabIndex = 17;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // apiparkingBindingSource
            // 
            this.apiparkingBindingSource.DataSource = typeof(Managing_Car_Program.Model.Api_parking);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "주차장명";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "위치";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 260;
            // 
            // pcountDataGridViewTextBoxColumn
            // 
            this.pcountDataGridViewTextBoxColumn.DataPropertyName = "Pcount";
            this.pcountDataGridViewTextBoxColumn.HeaderText = "면수";
            this.pcountDataGridViewTextBoxColumn.Name = "pcountDataGridViewTextBoxColumn";
            this.pcountDataGridViewTextBoxColumn.Width = 150;
            // 
            // Other_view_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Other_view_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "다른 주차장 보기";
            this.Load += new System.EventHandler(this.Other_view_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apiparkingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource apiparkingBindingSource;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcountDataGridViewTextBoxColumn;
    }
}