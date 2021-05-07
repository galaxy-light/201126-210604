using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Seal
{
    public partial class MainForm : Form
    {
        List<TabPage> tabPages = new List<TabPage>();
        bool isCreated = false;

        List<Skill> skillList = new List<Skill>();
        List<SkillResult> ResultList = new List<SkillResult>();
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = 
            //comboBox9.SelectedIndex = 0;
            //comboBox10.SelectedIndex = 0;
            //comboBox11.SelectedIndex = 0;
            //sum8.SelectedIndex = 0;
            //sum17.SelectedIndex = 0;
            //sum25.SelectedIndex = 0;
            //sum6.SelectedIndex = 0;
            //sum15.SelectedIndex = 0;
            //sum23.SelectedIndex = 0; 


            for (int i = 0; i < 4; i++)
            {
                Skill skill = new Skill
                {
                    Abilitystone = new TextBox(),
                    Necklace = new TextBox(),
                    Earing1 = new TextBox(),
                    Earing2 = new TextBox(),
                    Ring1 = new TextBox(),
                    Ring2 = new TextBox(),
                    Ring2Seal = new ComboBox(),
                    Ring1Seal = new ComboBox(),
                    AllSkill = new ComboBox()

                };
                skillList.Add(skill);

                Controls.Add(skillList[i].AllSkill);
                Controls.Add(skillList[i].Abilitystone);
                Controls.Add(skillList[i].Necklace);
                Controls.Add(skillList[i].Earing1);
                Controls.Add(skillList[i].Earing2);
                Controls.Add(skillList[i].Ring1);
                Controls.Add(skillList[i].Ring1Seal);
                Controls.Add(skillList[i].Ring2); 
                Controls.Add(skillList[i].Ring2Seal);

            }
            for (int i = 0; i < skillList.Count; i++)
            {
                skillList[i].AllSkill.Location = new Point(150 + i * 170, 60); 
                skillList[i].Abilitystone.Location = new Point(150 + i * 170, 100);
                skillList[i].Necklace.Location = new Point(150 + i * 170, 140);
                skillList[i].Earing1.Location = new Point(150 + i * 170, 180);
                skillList[i].Earing2.Location = new Point(150 + i * 170, 220);
                skillList[i].Ring1.Location = new Point(150 + i * 170, 260);
                skillList[i].Ring1Seal.Location = new Point(150 + i * 170, 300);
                skillList[i].Ring2.Location = new Point(150 + i * 170, 340);
                skillList[i].Ring2Seal.Location = new Point(150 + i * 170, 380);
                skillList[i].Abilitystone.Text = 0.ToString();
                skillList[i].Necklace.Text = 0.ToString();
                skillList[i].Earing1.Text = 0.ToString();
                skillList[i].Earing2.Text = 0.ToString();
                skillList[i].Ring1.Text = 0.ToString();
                skillList[i].Ring1Seal.Text = 0.ToString();
                skillList[i].Ring2.Text = 0.ToString();
                skillList[i].Ring2Seal.Text = 0.ToString();

            }

            string[] SealList = File.ReadAllLines("SealList.txt");
            for (int i = 0; i < skillList.Count; i++)
            {
                foreach (var item in SealList)
                {
                    skillList[i].AllSkill.Items.Add(item);
                }

                for (int j = 0; j <= 4; j++)
                {
                    skillList[i].Ring1Seal.Items.Add(j*3);
                    skillList[i].Ring2Seal.Items.Add(j*3);

                }
                
            }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < skillList.Count; i++)
                {
                    int sum = 0;

                    sum += Convert.ToInt32(skillList[i].Abilitystone.Text);
                    sum += Convert.ToInt32(skillList[i].Necklace.Text);
                    sum += Convert.ToInt32(skillList[i].Earing1.Text);
                    sum += Convert.ToInt32(skillList[i].Earing2.Text);
                    sum += Convert.ToInt32(skillList[i].Ring1.Text);
                    sum += Convert.ToInt32(skillList[i].Ring1Seal.Text);
                    sum += Convert.ToInt32(skillList[i].Ring2.Text);
                    sum += Convert.ToInt32(skillList[i].Ring2Seal.Text);

                    int level = 0;
                    int over = sum % 5;

                    if (sum>=0 && sum<=4)
                    {
                        level = 0;
                    }

                    else if (sum>=5 && sum<= 9)
                    {
                        level = 1;
                    }
                    else if (sum>=10 && sum<=14)
                    {
                        level = 2;
                    }
                    else
                    {
                        level = 3;
                    }
                    string format = level.ToString();
                    if (level > 0 && over > 0)
                    {
                        format += "(+" + over + ")";
                    }

                    ResultList.Add(new SkillResult
                    {
                        Name = skillList[i].AllSkill.Text,
                        Total = sum,
                        Level = format

                    });

                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ResultList;

            }
            catch (Exception)
            {
                MessageBox.Show("숫자를 입력해주세요.");

            }
        }
    }
}
