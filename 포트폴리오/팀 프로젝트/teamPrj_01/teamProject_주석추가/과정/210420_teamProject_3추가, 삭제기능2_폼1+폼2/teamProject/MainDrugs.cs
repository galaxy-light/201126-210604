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
        public MainDrugs()
        {
            InitializeComponent();
            comboBox1.Text = "검색기준";                      
        }

        private void MainDrugs_Load(object sender, EventArgs e)
        {                       
            /*foreach (var item in meds)
            {
                string medName = item.MedName;
                string medCom = item.MedCom;
                string medCode = item.MedCode;
                string medContain = item.MedContain;
                string medListCode = item.MedListCode;                
                int CountMed = item.CountMed1;

                meds.Add(new Drug(medName, medCom, medCode, medContain, medListCode, CountMed));
            }
            dataGridView1.DataSource = meds;*/

            dataGridView1.DataSource = DataManager_count.Drugc;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            /*Drug drug1 = dataGridView1.CurrentRow.DataBoundItem as Drug;
            textBox2.Text = drug1.MedName;*/
            try
            {                
                Drug temp = dataGridView1.CurrentRow.DataBoundItem as Drug;
                textBox2.Text = temp.MedName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            new DrugOrderForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Drug> tempList = new List<Drug>();

            // 의약품명
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var item in DataManager_count.Drugc)
                {
                    if (item.MedName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            // 제조사
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (var item in DataManager_count.Drugc)
                {
                    if (item.MedCom.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            // 품목기준코드
            else if (comboBox1.SelectedIndex == 2)
            {
                foreach (var item in DataManager_count.Drugc)
                {
                    if (item.MedCode.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }                                  
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                button1.Focus();
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkBox1.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                checkBox1.Focus();
            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkBox2.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                checkBox2.Focus();
            }
        }

        private void checkBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2.Focus();
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                button2.Focus();
            }
        }
    }
}
