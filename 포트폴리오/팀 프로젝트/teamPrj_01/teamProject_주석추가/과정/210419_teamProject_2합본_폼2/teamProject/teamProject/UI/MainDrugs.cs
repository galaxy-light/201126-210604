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
        Random r = new Random();

        public MainDrugs()
        {
            InitializeComponent();
            comboBox1.Text = "검색기준";
        }

        private void MainDrugs_Load(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList"; // URL
            url += "?ServiceKey=" + "Kbg5ok99gLL7L7nQwR3uRoSjPEYTXU2TceiGRQ59%2F6CO%2BzLEl%2F2GcGh4L8BYBXfhtxbTbuUZmGTjb0%2BabDPX6w%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            foreach (var item in element.Descendants("item"))
            {
                string medName = item.Element("ITEM_NAME").Value;
                string medId = item.Element("ITEM_SEQ").Value;
                string medComp = item.Element("ENTP_NAME").Value;
                string chart = item.Element("CHART").Value;
                string formName = item.Element("FORM_NAME").Value;
                string className = item.Element("CLASS_NAME").Value;
                string mainIngr = item.Element("MAIN_INGR").Value;
                int countMed = r.Next(10000);

                meds.Add(new Drug(medName, medId, medComp, chart, formName, className, mainIngr, countMed));
            }          
            dataGridView1.DataSource = meds;
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

        private void button2_Click(object sender, EventArgs e)
        {
            new DrugOrderForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Drug> tempList = new List<Drug>();

            if (comboBox1.SelectedIndex == 0)
            {                
                foreach (var item in meds)
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
                foreach (var item in meds)
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
                foreach (var item in meds)
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
                foreach (var item in meds)
                {
                    if (item.FormName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                foreach (var item in meds)
                {
                    if (item.ClassName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                foreach (var item in meds)
                {
                    if (item.MainIngr.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
