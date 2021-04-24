using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program.Ui
{
    public partial class Txt_view_Form : MaterialForm
    {
        // 코드 참고 : https://manniz.tistory.com/entry/CC-text-%ED%8C%8C%EC%9D%BC-%EC%9D%BD%EA%B8%B0-C-txt-%ED%8C%8C%EC%9D%BC-%EC%9D%BD%EA%B8%B0-C-text-read-C-txt-read

        public Txt_view_Form()
        {
            InitializeComponent();            
        }      

        private void uiSymbolButton_view_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"D:\중요\Desktop\School\포트폴리오\주차 관리 프로그램\Managing_Car_Program\Managing_Car_Program\bin\Debug\parkingHistory\parkingHistory.txt");
            // 읽어들일 TXT 파일의 경로를 매개변수로 StreamReader 생성

            // 한 줄씩 읽기
            /*string line; //한 줄씩 읽은 후, 그 값을 저장시킬 변수 
            string result = ""; // 전체 라인을 저장시킬 변수
            while ((line = rd.ReadLine()) != null) //line변수에 SR에서 한줄을 읽은 걸 저장, 읽은 줄이 null이 아닐때까지 반복
            {
                result += line; //전체 라인 변수에 그 값을 저장
                result += "\r\n"; //표출을 위해서 추가
            }

            textBox1.Text = result; // textbox폼에 전체 읽은 문구를 표출
            rd.Close();*/ // StreamReader를 닫아줌

            string result = ""; //읽은 TXT파일을 저장시킬 변수
            result = rd.ReadToEnd();

            richTextBox1.Text = result; // textbox폼에 전체 읽은 문구를 표출           
            rd.Close(); // StreamReader를 닫아줌

            string str = $"백업 데이터를 조회했습니다.";
            viewwriteLog(str);
            DataManager.Save();
        }

        private void viewwriteLog(string txtcontents)
        {
            string viewlogcontents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{txtcontents}";
            DataManager.printLog(viewlogcontents);
        }
    }
}
