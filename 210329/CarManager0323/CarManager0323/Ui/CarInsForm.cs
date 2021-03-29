using CarManager0323.DB;
using CarManager0323.Model;
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

        public CarInsForm()
        {
            InitializeComponent();
        }

        public CarInsForm(DaoOracle oracle) // 매개변수를 가지는 생성자
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        private void CarInsForm_Load(object sender, EventArgs e)
        {

        }

        private void addOkay_Click(object sender, EventArgs e)
        {
            Car car = new Car(
                AddCarModel.Text, Int32.Parse(AddCarPrice.Text),
                AddCarColor.Text, AddCarCompany.Text, AddCarYear.Text);
            oracle.insertCar(car);
            Close();
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
