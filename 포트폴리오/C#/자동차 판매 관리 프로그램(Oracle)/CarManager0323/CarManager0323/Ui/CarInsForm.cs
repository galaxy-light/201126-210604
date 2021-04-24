using CarManager0323.DB;
using CarManager0323.Model;
using CarManager0330.Handler;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0329.Ui
{
    partial class CarInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public CarInsForm()
        {
            InitializeComponent();
        }

        // 오버로딩
        public CarInsForm(DaoOracle oracle) // 매개변수를 가지는 생성자
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        // 오버로딩
        public CarInsForm(DaoOracle oracle, DealHandler dHandler) // 매개변수를 가지는 생성자
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void CarInsForm_Load(object sender, EventArgs e)
        {

        }

        private void addOkay_Click(object sender, EventArgs e)
        {
            // if예외처리(공백 오류 처리)
            if (AddCarModel.Text == "" || AddCarPrice.Text == ""
                || AddCarColor.Text == "" || AddCarCompany.Text == "" || AddCarYear.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.GetDealList(); 

            // try/catch 예외처리(입력 문자 오류 처리)
            try
            {
                // car 객체 생성(텍스트 박스에 입력한 정보를 가져옴)
                Car car = new Car(
                   AddCarModel.Text,
                   Int32.Parse(AddCarPrice.Text),
                   AddCarColor.Text,
                   AddCarCompany.Text,
                   AddCarYear.Text);
                if (list[0].Car == null) // 초기 값이 null(더미 값)이면 저장
                {
                    list[0].Car = car; // 리스트에 저장 / 이렇게만 쓰면 리스트 안에 객체가 없기 때문에 프로그램 동작X -> 해결하기 위해 기본 생성자를 추가하고 Deal정보들을 삽입(DealHandler)
                    oracle.insertCar(car);
                    Console.WriteLine("차량 정보 추가 완료");
                    MessageBox.Show("차량 정보 추가 완료");
                }
                else
                {
                    MessageBox.Show("차량 정보가 이미 저장되었습니다.");
                }               
                Close();
                
            }
            catch(FormatException)
            {                
                MessageBox.Show("가격을 올바른 숫자로 입력하세요.");
                Console.WriteLine("가격을 올바른 숫자로 입력하세요.");
            }           
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
