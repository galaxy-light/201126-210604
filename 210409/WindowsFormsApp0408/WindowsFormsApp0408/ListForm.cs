using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb; // OLEDB 를 이용한 엑셀 읽기, 수정, 삭제 등 처리 가능
using DataTable = System.Data.DataTable;
using Microsoft.Win32;

namespace WindowsFormsApp0409
{
    public partial class ListForm : MetroForm
    {
        // 코드 참고 : https://link2me.tistory.com/823
        // 12.0 공급자 문제 : https://www.microsoft.com/ko-kr/download/details.aspx?id=13255

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            connectexcel();
        }

        private void connectexcel()
        {
            MessageBox.Show("프로그램 폴더에 있는 엑셀파일을 열어주세요.");
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog()) // 파일 선택창 객체를 생성
                {
                    dlg.Filter = "Excel Files(2007이상)|*.xlsx|Excel Files(97~2003)|*.xls";
                    dlg.InitialDirectory = @"D:\중요\Desktop\School\210409\역대_로또_당첨_번호";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        ImportExcelData_Read(dlg.FileName, dataGridView); // 메서드를 호출
                    }
                }
            }
            catch (Exception ex)  // 엑셀파일이 다른 프로그렘에서 이미 열었거나 에러가 발생하면 에러를 출력
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ImportExcelData_Read(string fileName, DataGridView dgv)
        {
            // 엑셀 문서 내용 추출
            string connectionString = string.Empty;

            if (File.Exists(fileName))  // 파일 확장자 검사
            {
                if (Path.GetExtension(fileName).ToLower() == ".xls")
                {   // Microsoft.Jet.OLEDB.4.0 은 32 bit에서만 동작되므로 빌드할 때 64비트로 하면 에러가 발생
                    connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties=Excel 8.0;", fileName);
                }
                else if (Path.GetExtension(fileName).ToLower() == ".xlsx")
                {
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=Excel 12.0;", fileName);
                }
            }

            DataSet data = new DataSet();

            string strQuery = "SELECT * FROM [Sheet1$]"; // 엑셀 시트명 sheet1의 모든 데이터를 가져오기
            OleDbConnection oleConn = new OleDbConnection(connectionString);
            oleConn.Open();

            OleDbCommand oleCmd = new OleDbCommand(strQuery, oleConn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(oleCmd);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            data.Tables.Add(dataTable);

            dgv.DataSource = data.Tables[0].DefaultView;

            // 데이터에 맞게 칼럼 사이즈 조정하기
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
            }
            dgv.AllowUserToAddRows = false; // 빈 레코드 표시 안하기
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 화면 크기에 맞춰 채우기

            dataTable.Dispose();
            dataAdapter.Dispose();
            oleCmd.Dispose();

            oleConn.Close();
            oleConn.Dispose();
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("공급자 문제가 발생했다면 연결되는 사이트에서 드라이버를 설치해주세요.");
            System.Diagnostics.Process.Start("https://www.microsoft.com/ko-kr/download/details.aspx?id=13255");
        }
    }
}