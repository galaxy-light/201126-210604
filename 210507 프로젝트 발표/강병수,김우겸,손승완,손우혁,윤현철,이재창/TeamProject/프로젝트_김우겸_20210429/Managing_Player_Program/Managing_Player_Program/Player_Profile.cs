using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    public partial class Player_Profile : Form
    {
        public Player_Profile()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = DataManager.Players;
            textBox1.Text = DataManager.Players[0].Name.ToString();
            textBox2.Text = DataManager.Players[0].Number.ToString();
            textBox3.Text = DataManager.Players[0].Team.ToString();
            textBox4.Text = DataManager.Players[0].Height.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : "
                 + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("입력 버튼 클릭");
            if (textBox1.Text.Trim() == "") // Trim : 공백 제거 함수
            {
                MessageBox.Show("선수이름을 입력해라.");
                writeLog("선수이름을 입력해라.");
            }
            else if (textBox2.Text.Trim() == "") // 선수 번호를 입력하지 않은 경우
            {
                MessageBox.Show("선수번호를 입력해라.");
                writeLog("선수번호를 입력해라.");
            }
            else
            {
                try
                {
                    //참조변수, 람다 개념을 알고 있을 때
                    Player players = DataManager.Players.Single
                        ((x) => x.Number.ToString() == textBox2.Text);
                    if (players.Name.Trim() != "") // 이미 선수 정보가 저장되어있음
                    {
                        MessageBox.Show("이미 선수가 있어요." + textBox1.Text);
                        writeLog("이미 선수가 있어요." + textBox1.Text);
                    }
                    else
                    {
                        players.Name = textBox1.Text;
                        players.Number = textBox2.Text;
                        players.Team = textBox3.Text;
                        players.Height = textBox4.Text;
                        players.InsertTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Players;
                        DataManager.Save();

                        string contents = $"선수이름 {textBox1.Text}와(과) 등번호 {textBox2.Text}가 있음.";
                        MessageBox.Show(contents);
                        writeLog(contents, DateTime.Now.ToString("yyyy-MM-dd"));
                    }

                }

                catch (Exception ex)
                {
                    string contents = "들어갈 수 있는 선수가 없습니다.";
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("삭제 버튼 클릭");

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("선수이름을 입력해주세요!");
                return;
            }

            // single 없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Players.Count; i++)
                {
                    if (DataManager.Players[i].Name.ToString() == textBox1.Text)
                    {
                        if (DataManager.Players[i].Name.Trim() == "")
                        {
                            MessageBox.Show("아직 선수 없음");
                            writeLog("아직 선수 없음");
                            break;
                        }
                        else
                        {
                            DataManager.Players[i].Name = "";
                            DataManager.Players[i].Number = "";
                            DataManager.Players[i].Team = "";
                            DataManager.Players[i].Height = "";
                            DataManager.Players[i].InsertTime = DateTime.Now;
                            string contents = $"선수이름 {textBox1.Text} 삭제";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; // dataGridView1의 데이터를 한 번 지워주고
                            dataGridView1.DataSource = DataManager.Players; // 다시 리셋
                            DataManager.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("삭제 안 됨.");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //writeLog("3번 버튼 클릭");
                //writeLog("3번 버튼 클릭",DateTime.Now.ToString("yyyy_MM_dd"));
                writeLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
                string Number = textBox5.Text;
                string Name = lookUpFunction(Number);
                string contents = string.Empty;
                if (Number.Trim() != "")
                {
                    contents = $"등번호 {textBox5.Text}을(를) 쓰고 있는 선수는 {Name}입니다.";
                }
                else
                {
                    contents = $"등번호 {textBox5.Text}을(를) 쓰고 있는 선수가 없습니다.";
                }
                writeLog(contents);
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("선수번호가 입력되지 않았습니다.");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private string lookUpFunction(string Number) //조회하는 함수(연계 필요 데이터 식별)
        {
            try
            {
                //ver2
                // foreach문으로 조회한다.(single이 어려울 경우)
                string PlayerNumber = "";
                foreach (var item in DataManager.Players)
                {
                    if (item.Number == Number)
                        Name = item.Name;
                }
                return Name;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void writeLog(string contents)
        {
            // int a = 1;
            // MessageBox.Show(a.ToString("00")); // 01로 출력됨
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            // 옛날 것이 가장 위에 있는 방식
            listBox1.Items.Add(logContents);

            // 최근 것이 가장 위에 있는 방식
            // listBox1.Items.Insert(0, logContents);

            DataManager.printLog(logContents);
        }


         
        private void writeLog(string contents, string date)
        {
            // int a = 1;
            // MessageBox.Show(a.ToString("00")); // 01로 출력됨
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            // 옛날 것이 가장 위에 있는 방식
            //listBox1.Items.Add(logContents);

            // 최근 것이 가장 위에 있는 방식
            // listBox1.Items.Insert(0, logContents);
            listBox1.Items.Insert(0, logContents);
            DataManager.printLog(logContents, date);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Player temp = dataGridView1.CurrentRow.DataBoundItem as Player;
                textBox1.Text = temp.Name;
                textBox2.Text = temp.Number;
                textBox3.Text = temp.Team;
                textBox4.Text = temp.Height;
                textBox5.Text = temp.Number.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
