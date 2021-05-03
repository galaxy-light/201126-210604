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

            tooltip();
        }

        private void tooltip()
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip1.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip1.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip1.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip1.SetToolTip(uiSymbolButton_view, "모든 백업 데이터 보기");

            ToolTip tooltip2 = new ToolTip();
            tooltip2.ShowAlways = true;
            tooltip2.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip2.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip2.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip2.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip2.SetToolTip(uiSymbolButton_help4, "도움말");
        }

        private void uiSymbolButton_view_Click(object sender, EventArgs e)
        {
            StreamReader rd = new StreamReader(@"../Debug/parkingHistory/parkingHistory.txt");
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

        private void uiSymbolButton_help4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("백업 파일은 삭제 시 복구가 되지 않습니다. 삭제에 주의하세요.");
        }
    }
}
