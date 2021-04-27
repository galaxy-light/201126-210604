
namespace Guide_program
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
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
            this.touraddr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourlangCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourlangCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourimageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.touraddr2DataGridViewTextBoxColumn,
            this.tourlangCheckDataGridViewTextBoxColumn,
            this.tourlangCodeDataGridViewTextBoxColumn,
            this.tourimageUrlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guidelistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(844, 333);
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
            // touraddr2DataGridViewTextBoxColumn
            // 
            this.touraddr2DataGridViewTextBoxColumn.DataPropertyName = "Touraddr2";
            this.touraddr2DataGridViewTextBoxColumn.HeaderText = "Touraddr2";
            this.touraddr2DataGridViewTextBoxColumn.Name = "touraddr2DataGridViewTextBoxColumn";
            // 
            // tourlangCheckDataGridViewTextBoxColumn
            // 
            this.tourlangCheckDataGridViewTextBoxColumn.DataPropertyName = "TourlangCheck";
            this.tourlangCheckDataGridViewTextBoxColumn.HeaderText = "TourlangCheck";
            this.tourlangCheckDataGridViewTextBoxColumn.Name = "tourlangCheckDataGridViewTextBoxColumn";
            // 
            // tourlangCodeDataGridViewTextBoxColumn
            // 
            this.tourlangCodeDataGridViewTextBoxColumn.DataPropertyName = "TourlangCode";
            this.tourlangCodeDataGridViewTextBoxColumn.HeaderText = "TourlangCode";
            this.tourlangCodeDataGridViewTextBoxColumn.Name = "tourlangCodeDataGridViewTextBoxColumn";
            // 
            // tourimageUrlDataGridViewTextBoxColumn
            // 
            this.tourimageUrlDataGridViewTextBoxColumn.DataPropertyName = "TourimageUrl";
            this.tourimageUrlDataGridViewTextBoxColumn.HeaderText = "TourimageUrl";
            this.tourimageUrlDataGridViewTextBoxColumn.Name = "tourimageUrlDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 563);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn touraddr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourlangCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourlangCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourimageUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource guidelistBindingSource;
    }
}

