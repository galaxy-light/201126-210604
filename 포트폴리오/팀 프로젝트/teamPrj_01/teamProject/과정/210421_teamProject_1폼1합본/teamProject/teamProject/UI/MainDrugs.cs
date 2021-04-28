using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace teamProject
{
    public partial class MainDrugs : Form
    {
        List<Drug> meds = new List<Drug>();
        public MainDrugs()
        {
            InitializeComponent();
            comboBox1.Text = "검색기준";
        }

        private void MainDrugs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataManager.drugs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Drug drug1 = dataGridView1.CurrentRow.DataBoundItem as Drug;
            textBox2.Text = drug1.MedName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; //빈칸 만들기
            List<Drug> tempList = new List<Drug>();  //

            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedComp.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedId.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.Chart.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.FormName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.ClassName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MainIngr.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                MessageBox.Show(textBox2.Text + "수량" + textBox3.Text + "개 가 주문서에 추가 되었습니다.");
            }
            else if (textBox3.Text.Trim() =="")
            {
                MessageBox.Show("수량을 입력해주세요");
            }
            else
            {
                MessageBox.Show("약품명을 입력해주세요");
            }

        }
    }
}

