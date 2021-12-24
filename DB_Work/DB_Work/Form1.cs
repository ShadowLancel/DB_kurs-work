using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DB_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a2 = new Form2();
            a2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a2 = new Form2();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                string s = "a";
                int i = 0;
                while (s != null)
                {
                    s = sr.ReadLine();
                    switch (i)
                    {
                        case 0:
                            a2.textBox1.Text = s;
                            break;
                        case 1:
                            a2.textBox2.Text = s;
                            break;
                        case 2:
                            a2.textBox3.Text = s;
                            break;
                        case 3:
                            a2.textBox4.Text = s;
                            break;
                    }
                    i++;
                }
                a2.Show();
            }

        }
    }
}
