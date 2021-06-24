using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Task<string> t0 = Task<string>.Factory.StartNew(() =>
            {
                int suma = valor1 + valor2;
                Thread.SpinWait(int.MaxValue);
                textBox1.Text = suma.ToString();
                Thread.SpinWait(int.MaxValue);
                return textBox1.Text ;
            });

            Task<int> t1= Task.Factory.StartNew(() =>
            {
               Thread.SpinWait(int.MaxValue);
               int valor1 = int.Parse(textBox2.Text);
                return valor1;
            });

            Task<int>t2 = Task.Factory.StartNew(() =>
            {
                Thread.SpinWait(int.MaxValue);
                int valor2 = int.Parse(textBox3.Text);
                return valor2;
            });


            Task t3 = t1.ContinueWith((antecedente) =>
            {
              textBox1.Text = antecedente.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
           

        }
       

       
    }
}
