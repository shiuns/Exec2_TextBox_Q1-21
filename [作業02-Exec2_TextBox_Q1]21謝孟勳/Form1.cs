using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_TextBox_Q1_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rows = 0;
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            string msg = rang(rows);

            MessageBox.Show(msg);

        }

        private double GetRows()
        {
            string input = textBox1.Text;
            bool isDouble = double.TryParse(input, out double rows);

            if (isDouble == false)
            {
                throw new Exception("必須輸入整數");
            }
            return rows;

        }

        private string rang(double rows)
        {
            string msg;
            if (rows > 99 || rows <= 1)
            {
                msg = $"{textBox1.Text}不在1~99範圍內";
            }
            else
            {
                msg = $"{textBox1.Text}在1~99範圍內";
            }
            return msg;
        }
    }
}
