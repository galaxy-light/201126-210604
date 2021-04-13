
namespace WindowsFormsApp0413
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
            this.test_button1 = new System.Windows.Forms.Button();
            this.Q_Box1 = new System.Windows.Forms.TextBox();
            this.A_Box1 = new System.Windows.Forms.TextBox();
            this.label_result_1 = new System.Windows.Forms.Label();
            this.Q_Box2 = new System.Windows.Forms.TextBox();
            this.label_result_2 = new System.Windows.Forms.Label();
            this.textBox_myresult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_compresult = new System.Windows.Forms.TextBox();
            this.label_P = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.button_F = new System.Windows.Forms.Button();
            this.button_P = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.label_result_3 = new System.Windows.Forms.Label();
            this.Q_Box3 = new System.Windows.Forms.TextBox();
            this.button_okay = new System.Windows.Forms.Button();
            this.label_textnum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add_12 = new System.Windows.Forms.Button();
            this.button_add_44 = new System.Windows.Forms.Button();
            this.label_add = new System.Windows.Forms.Label();
            this.label_del = new System.Windows.Forms.Label();
            this.button_add_27 = new System.Windows.Forms.Button();
            this.button_add_16 = new System.Windows.Forms.Button();
            this.button_del_12 = new System.Windows.Forms.Button();
            this.button_del_44 = new System.Windows.Forms.Button();
            this.button_del_27 = new System.Windows.Forms.Button();
            this.button_del_16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_button1
            // 
            this.test_button1.Location = new System.Drawing.Point(217, 95);
            this.test_button1.Name = "test_button1";
            this.test_button1.Size = new System.Drawing.Size(75, 23);
            this.test_button1.TabIndex = 0;
            this.test_button1.Text = "확인";
            this.test_button1.UseVisualStyleBackColor = true;
            this.test_button1.Click += new System.EventHandler(this.test_button1_Click);
            // 
            // Q_Box1
            // 
            this.Q_Box1.Location = new System.Drawing.Point(111, 35);
            this.Q_Box1.Multiline = true;
            this.Q_Box1.Name = "Q_Box1";
            this.Q_Box1.Size = new System.Drawing.Size(181, 44);
            this.Q_Box1.TabIndex = 1;
            this.Q_Box1.Text = "문제1. Random 함수를 이용하여 숫자 맞추기 프로그램을 Form 형태로 만들어보시오.";
            // 
            // A_Box1
            // 
            this.A_Box1.Location = new System.Drawing.Point(111, 97);
            this.A_Box1.Name = "A_Box1";
            this.A_Box1.Size = new System.Drawing.Size(100, 21);
            this.A_Box1.TabIndex = 2;
            // 
            // label_result_1
            // 
            this.label_result_1.AutoSize = true;
            this.label_result_1.Location = new System.Drawing.Point(109, 133);
            this.label_result_1.Name = "label_result_1";
            this.label_result_1.Size = new System.Drawing.Size(11, 12);
            this.label_result_1.TabIndex = 3;
            this.label_result_1.Text = "-";
            // 
            // Q_Box2
            // 
            this.Q_Box2.Location = new System.Drawing.Point(432, 48);
            this.Q_Box2.Multiline = true;
            this.Q_Box2.Name = "Q_Box2";
            this.Q_Box2.Size = new System.Drawing.Size(240, 31);
            this.Q_Box2.TabIndex = 4;
            this.Q_Box2.Text = "문제2. Random 함수를 이용하여 가위 바위 보 게임을 만들어보시오.(Form 이용)";
            // 
            // label_result_2
            // 
            this.label_result_2.AutoSize = true;
            this.label_result_2.Location = new System.Drawing.Point(597, 129);
            this.label_result_2.Name = "label_result_2";
            this.label_result_2.Size = new System.Drawing.Size(11, 12);
            this.label_result_2.TabIndex = 7;
            this.label_result_2.Text = "-";
            // 
            // textBox_myresult
            // 
            this.textBox_myresult.Location = new System.Drawing.Point(477, 126);
            this.textBox_myresult.Name = "textBox_myresult";
            this.textBox_myresult.Size = new System.Drawing.Size(100, 21);
            this.textBox_myresult.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_compresult
            // 
            this.textBox_compresult.Location = new System.Drawing.Point(477, 155);
            this.textBox_compresult.Name = "textBox_compresult";
            this.textBox_compresult.Size = new System.Drawing.Size(100, 21);
            this.textBox_compresult.TabIndex = 8;
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(430, 131);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(41, 12);
            this.label_P.TabIndex = 9;
            this.label_P.Text = "사용자";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(430, 158);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(41, 12);
            this.label_C.TabIndex = 10;
            this.label_C.Text = "컴퓨터";
            // 
            // button_F
            // 
            this.button_F.Location = new System.Drawing.Point(432, 95);
            this.button_F.Name = "button_F";
            this.button_F.Size = new System.Drawing.Size(75, 23);
            this.button_F.TabIndex = 11;
            this.button_F.Text = "-";
            this.button_F.UseVisualStyleBackColor = true;
            this.button_F.Click += new System.EventHandler(this.button_F_Click);
            // 
            // button_P
            // 
            this.button_P.Location = new System.Drawing.Point(513, 95);
            this.button_P.Name = "button_P";
            this.button_P.Size = new System.Drawing.Size(75, 23);
            this.button_P.TabIndex = 12;
            this.button_P.Text = "-";
            this.button_P.UseVisualStyleBackColor = true;
            this.button_P.Click += new System.EventHandler(this.button_P_Click);
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(594, 95);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(75, 23);
            this.button_S.TabIndex = 13;
            this.button_S.Text = "-";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // label_result_3
            // 
            this.label_result_3.AutoSize = true;
            this.label_result_3.Location = new System.Drawing.Point(109, 351);
            this.label_result_3.Name = "label_result_3";
            this.label_result_3.Size = new System.Drawing.Size(11, 12);
            this.label_result_3.TabIndex = 17;
            this.label_result_3.Text = "-";
            // 
            // Q_Box3
            // 
            this.Q_Box3.Location = new System.Drawing.Point(111, 249);
            this.Q_Box3.Multiline = true;
            this.Q_Box3.Name = "Q_Box3";
            this.Q_Box3.Size = new System.Drawing.Size(194, 43);
            this.Q_Box3.TabIndex = 15;
            this.Q_Box3.Text = "list에 임의의 문장들을 만들어 놓고 Random 함수를 이용하여 임의의 문장을 출력하도록 하시오.";
            // 
            // button_okay
            // 
            this.button_okay.Location = new System.Drawing.Point(111, 308);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(194, 23);
            this.button_okay.TabIndex = 14;
            this.button_okay.Text = "확인";
            this.button_okay.UseVisualStyleBackColor = true;
            this.button_okay.Click += new System.EventHandler(this.button_okay_Click);
            // 
            // label_textnum
            // 
            this.label_textnum.AutoSize = true;
            this.label_textnum.Location = new System.Drawing.Point(390, 284);
            this.label_textnum.Name = "label_textnum";
            this.label_textnum.Size = new System.Drawing.Size(11, 12);
            this.label_textnum.TabIndex = 20;
            this.label_textnum.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 19);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "문제4. List를 이용하여 문자열을 추가 및 제거하는 화면을 만드시오.";
            // 
            // button_add_12
            // 
            this.button_add_12.Location = new System.Drawing.Point(432, 314);
            this.button_add_12.Name = "button_add_12";
            this.button_add_12.Size = new System.Drawing.Size(75, 23);
            this.button_add_12.TabIndex = 21;
            this.button_add_12.Text = "14";
            this.button_add_12.UseVisualStyleBackColor = true;
            this.button_add_12.Click += new System.EventHandler(this.button_add_12_Click);
            // 
            // button_add_44
            // 
            this.button_add_44.Location = new System.Drawing.Point(513, 314);
            this.button_add_44.Name = "button_add_44";
            this.button_add_44.Size = new System.Drawing.Size(75, 23);
            this.button_add_44.TabIndex = 22;
            this.button_add_44.Text = "44";
            this.button_add_44.UseVisualStyleBackColor = true;
            this.button_add_44.Click += new System.EventHandler(this.button_add_44_Click);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(390, 319);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(29, 12);
            this.label_add.TabIndex = 23;
            this.label_add.Text = "추가";
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Location = new System.Drawing.Point(390, 362);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(29, 12);
            this.label_del.TabIndex = 24;
            this.label_del.Text = "제거";
            // 
            // button_add_27
            // 
            this.button_add_27.Location = new System.Drawing.Point(594, 314);
            this.button_add_27.Name = "button_add_27";
            this.button_add_27.Size = new System.Drawing.Size(75, 23);
            this.button_add_27.TabIndex = 25;
            this.button_add_27.Text = "27";
            this.button_add_27.UseVisualStyleBackColor = true;
            this.button_add_27.Click += new System.EventHandler(this.button_add_27_Click);
            // 
            // button_add_16
            // 
            this.button_add_16.Location = new System.Drawing.Point(675, 314);
            this.button_add_16.Name = "button_add_16";
            this.button_add_16.Size = new System.Drawing.Size(75, 23);
            this.button_add_16.TabIndex = 26;
            this.button_add_16.Text = "16";
            this.button_add_16.UseVisualStyleBackColor = true;
            this.button_add_16.Click += new System.EventHandler(this.button_add_16_Click);
            // 
            // button_del_12
            // 
            this.button_del_12.Location = new System.Drawing.Point(432, 357);
            this.button_del_12.Name = "button_del_12";
            this.button_del_12.Size = new System.Drawing.Size(75, 23);
            this.button_del_12.TabIndex = 27;
            this.button_del_12.Text = "14";
            this.button_del_12.UseVisualStyleBackColor = true;
            this.button_del_12.Click += new System.EventHandler(this.button_del_12_Click);
            // 
            // button_del_44
            // 
            this.button_del_44.Location = new System.Drawing.Point(511, 357);
            this.button_del_44.Name = "button_del_44";
            this.button_del_44.Size = new System.Drawing.Size(75, 23);
            this.button_del_44.TabIndex = 28;
            this.button_del_44.Text = "44";
            this.button_del_44.UseVisualStyleBackColor = true;
            this.button_del_44.Click += new System.EventHandler(this.button_del_44_Click);
            // 
            // button_del_27
            // 
            this.button_del_27.Location = new System.Drawing.Point(594, 357);
            this.button_del_27.Name = "button_del_27";
            this.button_del_27.Size = new System.Drawing.Size(75, 23);
            this.button_del_27.TabIndex = 29;
            this.button_del_27.Text = "27";
            this.button_del_27.UseVisualStyleBackColor = true;
            this.button_del_27.Click += new System.EventHandler(this.button_del_27_Click);
            // 
            // button_del_16
            // 
            this.button_del_16.Location = new System.Drawing.Point(675, 357);
            this.button_del_16.Name = "button_del_16";
            this.button_del_16.Size = new System.Drawing.Size(75, 23);
            this.button_del_16.TabIndex = 30;
            this.button_del_16.Text = "16";
            this.button_del_16.UseVisualStyleBackColor = true;
            this.button_del_16.Click += new System.EventHandler(this.button_del_16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_del_16);
            this.Controls.Add(this.button_del_27);
            this.Controls.Add(this.button_del_44);
            this.Controls.Add(this.button_del_12);
            this.Controls.Add(this.button_add_16);
            this.Controls.Add(this.button_add_27);
            this.Controls.Add(this.label_del);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.button_add_44);
            this.Controls.Add(this.button_add_12);
            this.Controls.Add(this.label_textnum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_result_3);
            this.Controls.Add(this.Q_Box3);
            this.Controls.Add(this.button_okay);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.button_P);
            this.Controls.Add(this.button_F);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_P);
            this.Controls.Add(this.textBox_compresult);
            this.Controls.Add(this.label_result_2);
            this.Controls.Add(this.textBox_myresult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Q_Box2);
            this.Controls.Add(this.label_result_1);
            this.Controls.Add(this.A_Box1);
            this.Controls.Add(this.Q_Box1);
            this.Controls.Add(this.test_button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test_button1;
        private System.Windows.Forms.TextBox Q_Box1;
        private System.Windows.Forms.TextBox A_Box1;
        private System.Windows.Forms.Label label_result_1;
        private System.Windows.Forms.TextBox Q_Box2;
        private System.Windows.Forms.Label label_result_2;
        private System.Windows.Forms.TextBox textBox_myresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_compresult;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Button button_F;
        private System.Windows.Forms.Button button_P;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.Label label_result_3;
        private System.Windows.Forms.TextBox Q_Box3;
        private System.Windows.Forms.Button button_okay;
        private System.Windows.Forms.Label label_textnum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add_12;
        private System.Windows.Forms.Button button_add_44;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Button button_add_27;
        private System.Windows.Forms.Button button_add_16;
        private System.Windows.Forms.Button button_del_12;
        private System.Windows.Forms.Button button_del_44;
        private System.Windows.Forms.Button button_del_27;
        private System.Windows.Forms.Button button_del_16;
    }
}

