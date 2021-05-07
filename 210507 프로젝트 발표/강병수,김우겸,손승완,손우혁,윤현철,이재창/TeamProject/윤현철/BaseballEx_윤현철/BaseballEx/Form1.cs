using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaseballEx
{
    public partial class Form1 : Form
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" + "User Id=c##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;
        Rank rank;
        Random r = new Random();
        int[] baseball = new int[3];
        List<string> mylist = new List<string>();
        public List<Rank> rankList = new List<Rank>();
        List<Rank> dummy = new List<Rank>();

        string temp;
        int count = 0;
        int scount = 0;
        int bcount = 0;

        public Timer timer = null;
        public Form1()
        {
            InitializeComponent();

            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
         
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
            try
            {
                string query = "create table saveTB (count number not null, " +
                    "totalTime number not null, " +
                    "rank varchar(200) not null)";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }

            cmd.CommandText = "select count, totalTime, rank from saveTB";
            OracleDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                int a = int.Parse(rd["count"].ToString());
                int b = int.Parse(rd["totalTime"].ToString());
                string c = rd["rank"].ToString();
                rank = new Rank(a, b, c);
                rankList.Add(rank);
            }


            timer = new Timer() { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
            for (int i = 0; i < 3; i++)
            {
                baseball[i] = r.Next(1, 9);
                for (int j = 0; j < i; j++)
                {
                    if (baseball[i] == baseball[j])
                    {
                        i--;
                    }
                }
            }
          
            dummy.Clear();
            dummy.Add(new Rank(0, 0, "a"));


        }


        int totalTime = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            label2.Text = ++totalTime + "초";
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;

        }

        //Form4 form4 = null;

        int a = 0;
        int b = 0;
        int[] baseball2 = new int[3];
        private void button10_Click(object sender, EventArgs e)
        {
            scount = 0;
            bcount = 0;
            if (textBox1.Text.Length != 3)
            {
                MessageBox.Show("잘못 입력하셧습니다.");
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                if (baseball[i] == Convert.ToInt32(textBox1.Text[i].ToString()))
                {
                    scount++;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if (baseball[i] == int.Parse(textBox1.Text[j].ToString()))
                        {
                            bcount++;
                        }
                    }
                }
            }

            count++;
            if (count == 1)
            {
                baseball2 = baseball;
                a = r.Next(0, 3);
                b = r.Next(0, 3);
                while (true)
                {
                    if (a == b)
                    {
                        b = r.Next(0, 3);
                        continue;
                    }

                    break;
                }
            }

            if (count == 5)
            {
                label4.Text = baseball[a] + "   ";
            }
            if (count == 8)
            {
                label4.Text += baseball[b];
            }

            mylist.Add(textBox1.Text + "  " + scount + "S " + bcount + "B  " + count + "번 시도함");
            textBox1.Text = "";
            listBox1.Items.Add(mylist[0]);
            mylist.Clear();

            if (scount == 3)
            {
                MessageBox.Show("정답입니다.");
                label4.Text = "";

                listBox1.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    baseball[i] = r.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        if (baseball[i] == baseball[j])
                        {
                            i--;
                        }
                    }
                }

                timer.Stop();
                rank = new Rank(count, totalTime, DateTime.Now.ToString("yyyy" + "년" + "MM" + "월" + "dd" + "일" + " " +
                    "HH" + "시" + "mm" + "분" + "ss" + "초") + "    기록 :" + totalTime + "초" + "   시도횟수 : " + count);
                rankList.Add(rank);
                if (rankList.Count > 1)
                {

                    for (int i = 0; i < rankList.Count() - 1; i++)
                    {
                        for (int j = i; j < rankList.Count() - 1; j++)
                        {
                            if (rankList[i].TotalTime > rankList[j + 1].TotalTime)
                            {
                                dummy[0] = rankList[i];
                                rankList[i] = rankList[j + 1];
                                rankList[j + 1] = dummy[0];

                            }
                        }
                    }

                    for (int i = 0; i < rankList.Count() - 1; i++)
                    {
                        for (int j = i; j < rankList.Count() - 1; j++)
                        {
                            if (rankList[i].Count1 > rankList[j + 1].Count1)
                            {
                                dummy[0] = rankList[i];
                                rankList[i] = rankList[j + 1];
                                rankList[j + 1] = dummy[0];

                            }
                        }
                    }

                    if (rankList.Count == 11)
                        rankList.RemoveAt(10);
                }

                try
                {
                    string sql = string.Format("DELETE FROM saveTB");
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("에러: " + ex.Message);
                }

                try
                {
                    for (int i = 0; i < rankList.Count; i++)
                    {
                        string sql = string.Format("insert into saveTB values " +
                       "('{0}', {1}, '{2}')",
                       rankList[i].Count1, rankList[i].TotalTime, rankList[i].Rank1);
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("에러: " + ex.Message);
                }

                new Form4(this).ShowDialog();
                totalTime = 0;
                count = 0;

            }

            if (count == 10)
            {
                label4.Text = "";
                timer.Stop();
                //MessageBox.Show("기회를 모두 소진하셧습니다. 게임을 다시 시작합니다.");
                count = 0;
                new Form3(this, baseball2).ShowDialog();
                listBox1.Items.Clear();
                for (int i = 0; i < 3; i++)
                {
                    baseball[i] = r.Next(1, 9);
                    for (int j = 0; j < i; j++)
                    {
                        if (baseball[i] == baseball[j])
                        {
                            i--;
                        }
                    }
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
            if (e.KeyChar == '0')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button10_Click(null, null);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 3)
            {
                textBox1.Text = temp;
                MessageBox.Show("3자리만 입력하세요");
            }
            if (textBox1.Text.Length > 1)
            {
                for (int i = 0; i < textBox1.Text.Length - 1; i++)
                {
                    for (int j = i + 1; j < textBox1.Text.Length; j++)
                    {
                        if (textBox1.Text[i] == textBox1.Text[j])
                        {
                            textBox1.Text = temp;
                            MessageBox.Show("같은 숫자를 입력할수 없습니다.");
                            return;
                        }
                    }
                }
            }

            if (textBox1.Text.Length <= 3)
            {
                temp = textBox1.Text;
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
               
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
