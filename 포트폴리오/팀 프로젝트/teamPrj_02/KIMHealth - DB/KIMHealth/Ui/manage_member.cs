using KIMHealth.DB;
using System;
using System.Data;
using System.Windows.Forms;

namespace KIMHealth
{
    public partial class manage_member : Form
    {        
        public manage_member()
        {
            InitializeComponent();
            comboBox1_init();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void manage_member_MouseEnter(object sender, EventArgs e)
        {

        }

        private void serch_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "회원번호")
            {
                string count = DaoMs.countMember(serch_txt.Text);
                if (int.Parse(count) == 0)
                {
                    MessageBox.Show("회원정보가 존재하지 않습니다.");
                }
                else
                {
                    try
                    {
                        DataSet ds = DB.DaoMs.SelectId("M_TB", int.Parse(serch_txt.Text));

                        Model.Member m = new Model.Member();
                        m.m_name = ds.Tables[0].Rows[0]["m_name"].ToString();
                        m.m_phone = ds.Tables[0].Rows[0]["m_phone"].ToString();
                        m.m_address = ds.Tables[0].Rows[0]["m_addr"].ToString();
                        m.m_age = ds.Tables[0].Rows[0]["m_age"].ToString();
                        m.m_gender = ds.Tables[0].Rows[0]["m_gender"].ToString();
                        m.m_height = ds.Tables[0].Rows[0]["m_height"].ToString();
                        m.m_weight = ds.Tables[0].Rows[0]["m_weight"].ToString();
                        m.m_bmi = ds.Tables[0].Rows[0]["m_bmi"].ToString();
                        m.m_membership = ds.Tables[0].Rows[0]["m_membership"].ToString();
                        m.m_lent = ds.Tables[0].Rows[0]["m_lent"].ToString();
                        m.m_pt = ds.Tables[0].Rows[0]["m_pt"].ToString();
                        m.m_startday = ds.Tables[0].Rows[0]["m_startday"].ToString();
                        m.m_endday = ds.Tables[0].Rows[0]["m_endday"].ToString();

                        lb_id.Text = serch_txt.Text;
                        lb_name.Text = m.m_name;
                        lb_membership.Text = m.m_membership;
                        lb_lent.Text = m.m_lent;
                        lb_pt.Text = m.m_pt;
                        lb_start.Text = m.m_startday;
                        lb_end.Text = m.m_endday;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.StackTrace);
                    }
                }             
            }
            else if(comboBox1.Text == "회원이름")
            {
                string count = DaoMs.countMemberName(serch_txt.Text);
                if (int.Parse(count) == 0)
                {
                    MessageBox.Show("회원정보가 존재하지 않습니다.");
                }
                else
                {
                    try
                    {
                        DataSet ds = DB.DaoMs.SelectName("M_TB", serch_txt.Text);

                        Model.Member m = new Model.Member();
                        m.m_name = ds.Tables[0].Rows[0]["m_name"].ToString();
                        m.m_phone = ds.Tables[0].Rows[0]["m_phone"].ToString();
                        m.m_address = ds.Tables[0].Rows[0]["m_addr"].ToString();
                        m.m_age = ds.Tables[0].Rows[0]["m_age"].ToString();
                        m.m_gender = ds.Tables[0].Rows[0]["m_gender"].ToString();
                        m.m_height = ds.Tables[0].Rows[0]["m_height"].ToString();
                        m.m_weight = ds.Tables[0].Rows[0]["m_weight"].ToString();
                        m.m_bmi = ds.Tables[0].Rows[0]["m_bmi"].ToString();
                        m.m_membership = ds.Tables[0].Rows[0]["m_membership"].ToString();
                        m.m_lent = ds.Tables[0].Rows[0]["m_lent"].ToString();
                        m.m_pt = ds.Tables[0].Rows[0]["m_pt"].ToString();
                        m.m_startday = ds.Tables[0].Rows[0]["m_startday"].ToString();
                        m.m_endday = ds.Tables[0].Rows[0]["m_endday"].ToString();

                        string id = ds.Tables[0].Rows[0]["m_num"].ToString();

                        lb_id.Text = id;
                        lb_name.Text = m.m_name;
                        lb_membership.Text = m.m_membership;
                        lb_lent.Text = m.m_lent;
                        lb_pt.Text = m.m_pt;
                        lb_start.Text = m.m_startday;
                        lb_end.Text = m.m_endday;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            new manager_form().ShowDialog();           
        }

        public void comboBox1_init()
        {
            comboBox1.Items.Add("회원번호");
            comboBox1.Items.Add("회원이름");
            comboBox1.SelectedIndex = 0;
        }
    }
}
