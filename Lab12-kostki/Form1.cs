using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_kostki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 10;
            numericUpDown2.Maximum = 10;
            numericUpDown3.Maximum = 10;
            numericUpDown4.Maximum = 10;
            numericUpDown5.Maximum = 10;
            numericUpDown6.Maximum = 10;
            numericUpDown7.Maximum = 10;
            numericUpDown8.Maximum = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tableLayoutPanel1.Controls.Clear();        
            tableLayoutPanel1.ColumnCount= 10;
            int ccount = 0;
            tableLayoutPanel1.RowCount= 8;      
            
                     

            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Red;
                newLabel.ForeColor = Color.White;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 3).ToString();
                tableLayoutPanel1.Controls.Add(newLabel,ccount,0);
                ccount++;
                System.Threading.Thread.Sleep(2);
            }
            ccount= 0;
            for (int i = 0; i < (int)numericUpDown2.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.FromArgb(255, 128, 0);
                newLabel.ForeColor = Color.White;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 5).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 1);
                ccount++;                
                System.Threading.Thread.Sleep(2);
            }
            ccount= 0;
            for (int i = 0; i < (int)numericUpDown3.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Yellow;
                newLabel.ForeColor = Color.Black;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 7).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 2);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount= 0;
            for (int i = 0; i < (int)numericUpDown4.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Lime;
                newLabel.ForeColor = Color.Black;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 9).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 3);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount = 0;
            for (int i = 0; i < (int)numericUpDown5.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Cyan;
                newLabel.ForeColor = Color.Black;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 11).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 4);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount = 0;
            for (int i = 0; i < (int)numericUpDown6.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Blue;
                newLabel.ForeColor = Color.White;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 13).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 5);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount = 0;
            for (int i = 0; i < (int)numericUpDown7.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Fuchsia;
                newLabel.ForeColor = Color.White;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 21).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 6);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount = 0;
            for (int i = 0; i < (int)numericUpDown8.Value; i++)
            {
                Label newLabel = new Label();
                newLabel.BackColor = Color.Gray;
                newLabel.ForeColor = Color.White;
                newLabel.TextAlign = ContentAlignment.MiddleCenter;
                Random n = new Random();
                newLabel.Text = n.Next(1, 101).ToString();
                tableLayoutPanel1.Controls.Add(newLabel, ccount, 7);
                ccount++; ;
                System.Threading.Thread.Sleep(2);
            }
            ccount = 0;



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {            
            
        }
    }
}
