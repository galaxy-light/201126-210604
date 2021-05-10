using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth.DB
{
    public partial class totalInfo : Form
    {
        DataSet ds = new DataSet();
        int nowSelectNum = -1;
        int nowSelectTrainerNum = -1;
        public totalInfo()
        {
            InitializeComponent();
            uiRefresh();

        }

        private void uiRefresh()
        {

            ds = DB.DaoMs.DB_GYM("M_TB");
            dataGridView_member.DataSource = ds;
            dataGridView_member.DataMember = "M_TB";

            ds = DB.DaoMs.DB_GYM("T_TB");
            dataGridView_trainer.DataSource = ds;
            dataGridView_trainer.DataMember = "T_TB";

            ds = DB.DaoMs.DB_GYM("Info_TB");
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "Info_TB";
        }

        private void dataGridView_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var member = dataGridView_member.CurrentRow;
                nowSelectNum = int.Parse(member.Cells[0].Value.ToString());
                m_name_txt.Text = member.Cells[1].Value.ToString();
                m_phone_txt.Text = member.Cells[2].Value.ToString();
                m_addr_txt.Text = member.Cells[3].Value.ToString();
                m_age_txt.Text = member.Cells[4].Value.ToString();
                m_gender_txt.Text = member.Cells[5].Value.ToString();
                m_height_txt.Text = member.Cells[6].Value.ToString();
                m_weight_txt.Text = member.Cells[7].Value.ToString();
                m_bmi_txt.Text = member.Cells[8].Value.ToString();
                m_membership_txt.Text = member.Cells[9].Value.ToString();
                m_lent_txt.Text = member.Cells[10].Value.ToString();
                m_pt_txt.Text = member.Cells[11].Value.ToString();
                m_start_txt.Text = member.Cells[12].Value.ToString();
                m_end_txt.Text = member.Cells[13].Value.ToString();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show(exception.StackTrace);
            }


        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("nowSelectNum " + nowSelectNum);
               DB.DaoMs.DB_Update(nowSelectNum, m_name_txt.Text, m_phone_txt.Text, m_addr_txt.Text, m_age_txt.Text, m_gender_txt.Text,
                    m_height_txt.Text, m_weight_txt.Text, m_bmi_txt.Text, m_membership_txt.Text, m_lent_txt.Text,
                    m_pt_txt.Text, m_start_txt.Text, m_end_txt.Text);
                uiRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("업데이트 실패!" + ex.Message);
                MessageBox.Show(ex.StackTrace);
                return;
            }
            MessageBox.Show("회원정보가 수정되었습니다.");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DB.DaoMs.DB_Delete(m_name_txt.Text);
            MessageBox.Show("회원정보가 삭제되었습니다");
            uiRefresh();
        }

        private void dataGridView_trainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var trainer = dataGridView_trainer.CurrentRow;
                nowSelectTrainerNum = int.Parse(trainer.Cells[0].Value.ToString());
                t_name_txt.Text = trainer.Cells[1].Value.ToString();
                t_age_txt.Text = trainer.Cells[2].Value.ToString();
                t_gender_txt.Text = trainer.Cells[3].Value.ToString();
                t_career_txt.Text = trainer.Cells[4].Value.ToString();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show(exception.StackTrace);
            }
        }

        private void t_edit_btn_Click(object sender, EventArgs e)
        {    
            try
            {
                Console.WriteLine("트레이너 넘버 : " + nowSelectTrainerNum);
                DB.DaoMs.DB_Update_t(nowSelectTrainerNum, t_name_txt.Text, t_age_txt.Text, t_gender_txt.Text, t_career_txt.Text);
                uiRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("업데이트 실패!" + ex.Message);
                MessageBox.Show(ex.StackTrace);
                return;
            }
            MessageBox.Show("회원정보가 수정되었습니다.");
            
        }

        private void t_del_btn_Click(object sender, EventArgs e)
        {
            DB.DaoMs.DB_Delete_t(t_name_txt.Text);
            MessageBox.Show("트레이너 정보가 삭제되었습니다.");
            uiRefresh();

        }
    }
}
