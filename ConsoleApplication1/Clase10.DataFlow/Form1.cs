﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase10.DataFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task<string> t1 = Task<string>.Factory.StartNew(() =>
            {
                Thread.SpinWait(int.MaxValue);
                return "Hola mundo!";
            });

            Task t2 = t1.ContinueWith((antecedente) =>
            {
                textBox1.Text = antecedente.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
