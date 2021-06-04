﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern;

namespace ExamObserverPattern2
{
    public partial class SubForm1 : Form, Observer
    {
        Subject _subject;
        public SubForm1(Subject subject)
        {
            _subject = subject;
            subject.registerObserver(this);
            InitializeComponent();
        }
        public SubForm1()
        {
            InitializeComponent();
        }

        public void update(int value)
        {
            textBoxValue.Text = value.ToString();
        }
    }
}
