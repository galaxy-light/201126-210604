
namespace Managing_Car_Program.Ui
{
    partial class Txt_view_Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiSymbolButton_view = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_help4 = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(833, 444);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 25);
            this.panel1.TabIndex = 26;
            // 
            // uiSymbolButton_view
            // 
            this.uiSymbolButton_view.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_view.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_view.Location = new System.Drawing.Point(156, 32);
            this.uiSymbolButton_view.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_view.Name = "uiSymbolButton_view";
            this.uiSymbolButton_view.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_view.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_view.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_view.Symbol = 57591;
            this.uiSymbolButton_view.SymbolSize = 35;
            this.uiSymbolButton_view.TabIndex = 18;
            this.uiSymbolButton_view.Click += new System.EventHandler(this.uiSymbolButton_view_Click);
            // 
            // uiSymbolButton_help4
            // 
            this.uiSymbolButton_help4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_help4.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton_help4.Location = new System.Drawing.Point(818, 32);
            this.uiSymbolButton_help4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_help4.Name = "uiSymbolButton_help4";
            this.uiSymbolButton_help4.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.RectPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton_help4.Size = new System.Drawing.Size(36, 31);
            this.uiSymbolButton_help4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_help4.Symbol = 61553;
            this.uiSymbolButton_help4.SymbolSize = 35;
            this.uiSymbolButton_help4.TabIndex = 27;
            this.uiSymbolButton_help4.Click += new System.EventHandler(this.uiSymbolButton_help4_Click);
            // 
            // Txt_view_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 581);
            this.Controls.Add(this.uiSymbolButton_help4);
            this.Controls.Add(this.uiSymbolButton_view);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Txt_view_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "백업 데이터 확인";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton uiSymbolButton_view;
        private Sunny.UI.UISymbolButton uiSymbolButton_help4;
    }
}