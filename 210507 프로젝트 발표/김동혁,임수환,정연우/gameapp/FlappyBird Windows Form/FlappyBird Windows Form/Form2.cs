using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird_Windows_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //data.Load();
            dataGridView1.DataSource = data.rankings;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //공간번호
            if (textBox1.Text.Trim() == "") //Trim 공백 제거 함수
            {
                MessageBox.Show("이름 입력해라");
                writeLog("이름 입력하라고");

            }
            else
            {
                try
                {                   
                    List<Ranking> tempList = new List<Ranking>();
                    foreach (var item in data.rankings)
                    {
                        if (item.Name == textBox1.Text)
                            tempList.Add(item);
                    }
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tempList;
                    if(tempList.Count==0)
                    {
                        string contents = "이름: " + textBox1.Text + "은 없습니다.";
                        writeLog(contents);      
                    }
                    //data.Save();
                }
                catch (Exception ex)
                {
                    string contents = "이름: " + textBox1.Text + "은 없습니다.";
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Ranking temp = dataGridView1.CurrentRow.DataBoundItem as Ranking;
                textBox1.Text = temp.Name.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);

            }
        }
        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            //listBox1.Items.Add(logContents);
            //옛날 것이 가장 위에 올라가는 방식

            //새로운 것이 가장 위에 올라가는 방식
            listBox1.Items.Insert(0, logContents);
            data.printLog(logContents);
        }

        //writeLog() 오버로딩
        private void writeLog(string contents, string date)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            listBox1.Items.Insert(0, logContents);
            data.printLog(logContents, date);
        }
    }
}

