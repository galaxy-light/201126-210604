using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern;
using System.Collections;

namespace ExamObserverPattern2
{
    public partial class MainForm : Form, Subject
    {
        SubForm1 _subForm1 = null;
        SubForm2 _subForm2 = null;
        IList _observers = new ArrayList();
        public MainForm()
        {
            InitializeComponent();

            _subForm1 = new SubForm1(this);
            _subForm1.TopLevel = false;
            _subForm1.FormBorderStyle = FormBorderStyle.None;
            _subForm1.Dock = DockStyle.Fill;
            panelTab1.Controls.Add(_subForm1);
            _subForm1.Show();

            _subForm2 = new SubForm2(this);
            _subForm2.TopLevel = false;
            _subForm2.FormBorderStyle = FormBorderStyle.None;
            _subForm2.Dock = DockStyle.Fill;
            panelTab2.Controls.Add(_subForm2);
            _subForm2.Show();
        }

        public void notifyObservers()
        {
            foreach (Observer o in _observers)
                o.update(Convert.ToInt32(textBoxValue.Text));
        }

        public void registerObserver(Observer o)
        {
            _observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            _observers.Remove(o);
        }

        private void TextBoxValue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int value = Convert.ToInt32(textBoxValue.Text);
                notifyObservers();
            }
        }
    }
}
