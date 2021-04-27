
namespace Guide_program.Ui
{
    partial class ViewForm
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
            this.guidelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.touridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourtlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.touraddr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guidelistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.touridDataGridViewTextBoxColumn,
            this.tourtlidDataGridViewTextBoxColumn,
            this.tourtitleDataGridViewTextBoxColumn,
            this.touraddr1DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.guidelistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(712, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // guidelistBindingSource
            // 
            this.guidelistBindingSource.DataSource = typeof(Guide_program.Model.Guidelist);
            // 
            // touridDataGridViewTextBoxColumn
            // 
            this.touridDataGridViewTextBoxColumn.DataPropertyName = "Tourid";
            this.touridDataGridViewTextBoxColumn.HeaderText = "Tourid";
            this.touridDataGridViewTextBoxColumn.Name = "touridDataGridViewTextBoxColumn";
            // 
            // tourtlidDataGridViewTextBoxColumn
            // 
            this.tourtlidDataGridViewTextBoxColumn.DataPropertyName = "Tourtlid";
            this.tourtlidDataGridViewTextBoxColumn.HeaderText = "Tourtlid";
            this.tourtlidDataGridViewTextBoxColumn.Name = "tourtlidDataGridViewTextBoxColumn";
            // 
            // tourtitleDataGridViewTextBoxColumn
            // 
            this.tourtitleDataGridViewTextBoxColumn.DataPropertyName = "Tourtitle";
            this.tourtitleDataGridViewTextBoxColumn.HeaderText = "Tourtitle";
            this.tourtitleDataGridViewTextBoxColumn.Name = "tourtitleDataGridViewTextBoxColumn";
            // 
            // touraddr1DataGridViewTextBoxColumn
            // 
            this.touraddr1DataGridViewTextBoxColumn.DataPropertyName = "Touraddr1";
            this.touraddr1DataGridViewTextBoxColumn.HeaderText = "Touraddr1";
            this.touraddr1DataGridViewTextBoxColumn.Name = "touraddr1DataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tourlangcheck";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tourlangcheck";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tourlangcode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tourlangcode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guidelistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn touridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourtlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn touraddr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource guidelistBindingSource;
    }
}