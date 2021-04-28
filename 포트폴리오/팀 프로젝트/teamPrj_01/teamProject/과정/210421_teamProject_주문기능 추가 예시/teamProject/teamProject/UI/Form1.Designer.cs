
namespace teamProject.UI
{
    partial class Form1
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
            this.drugComp_dtGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.drugComp_dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drugComp_dtGridView
            // 
            this.drugComp_dtGridView.BackgroundColor = System.Drawing.Color.White;
            this.drugComp_dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugComp_dtGridView.Location = new System.Drawing.Point(57, 268);
            this.drugComp_dtGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drugComp_dtGridView.Name = "drugComp_dtGridView";
            this.drugComp_dtGridView.RowTemplate.Height = 30;
            this.drugComp_dtGridView.Size = new System.Drawing.Size(920, 407);
            this.drugComp_dtGridView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1061);
            this.Controls.Add(this.drugComp_dtGridView);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drugComp_dtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drugComp_dtGridView;
    }
}