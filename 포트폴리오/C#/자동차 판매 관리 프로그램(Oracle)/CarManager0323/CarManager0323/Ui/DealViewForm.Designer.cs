
namespace CarManager0331.Ui
{
    partial class DealViewForm
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
            this.DealList = new System.Windows.Forms.ListView();
            this.list_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deal_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deal_Car = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deal_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deal_Seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deal_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addOkay = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // DealList
            // 
            this.DealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_number,
            this.Deal_Name,
            this.Deal_Car,
            this.Deal_Price,
            this.Deal_Seller,
            this.Deal_Date});
            this.DealList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DealList.FullRowSelect = true;
            this.DealList.HideSelection = false;
            this.DealList.Location = new System.Drawing.Point(12, 76);
            this.DealList.Name = "DealList";
            this.DealList.Size = new System.Drawing.Size(779, 340);
            this.DealList.TabIndex = 1;
            this.DealList.UseCompatibleStateImageBehavior = false;
            this.DealList.View = System.Windows.Forms.View.Details;
            this.DealList.SelectedIndexChanged += new System.EventHandler(this.DealList_SelectedIndexChanged);
            // 
            // list_number
            // 
            this.list_number.Text = "번호";
            this.list_number.Width = 100;
            // 
            // Deal_Name
            // 
            this.Deal_Name.Text = "고객 이름";
            this.Deal_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Name.Width = 100;
            // 
            // Deal_Car
            // 
            this.Deal_Car.Text = "구매 차량";
            this.Deal_Car.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Car.Width = 200;
            // 
            // Deal_Price
            // 
            this.Deal_Price.Text = "구매 가격";
            this.Deal_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Price.Width = 150;
            // 
            // Deal_Seller
            // 
            this.Deal_Seller.Text = "판매자";
            this.Deal_Seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Seller.Width = 100;
            // 
            // Deal_Date
            // 
            this.Deal_Date.Text = "거래 날짜";
            this.Deal_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Date.Width = 100;
            // 
            // addOkay
            // 
            this.addOkay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOkay.FillColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOkay.Location = new System.Drawing.Point(343, 481);
            this.addOkay.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOkay.Name = "addOkay";
            this.addOkay.RectColor = System.Drawing.Color.MediumAquamarine;
            this.addOkay.Size = new System.Drawing.Size(109, 34);
            this.addOkay.Style = Sunny.UI.UIStyle.Custom;
            this.addOkay.TabIndex = 39;
            this.addOkay.Text = "확인";
            this.addOkay.Click += new System.EventHandler(this.addOkay_Click);
            // 
            // DealViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.addOkay);
            this.Controls.Add(this.DealList);
            this.Name = "DealViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래 내역 보기";
            this.Load += new System.EventHandler(this.DealViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DealList;
        private Sunny.UI.UISymbolButton addOkay;
        private System.Windows.Forms.ColumnHeader list_number;
        private System.Windows.Forms.ColumnHeader Deal_Name;
        private System.Windows.Forms.ColumnHeader Deal_Car;
        private System.Windows.Forms.ColumnHeader Deal_Price;
        private System.Windows.Forms.ColumnHeader Deal_Seller;
        private System.Windows.Forms.ColumnHeader Deal_Date;
    }
}