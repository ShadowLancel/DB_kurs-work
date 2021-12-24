using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DB_Work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                                textBox1.Text = s;
                                break;
                            case 1:
                                textBox2.Text = s;
                                break;
                            case 2:
                                textBox3.Text = s;
                                break;
                            case 3:
                                 textBox4.Text = s;
                                 break;
                    }
                    i++;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((((Convert.ToInt32(textBox1.Text)) >= 150) && ((Convert.ToInt32(textBox1.Text)) <= 250)) && (((Convert.ToInt32(textBox2.Text)) >= 0) && (Convert.ToInt32(textBox2.Text)) <= 40) && (Convert.ToInt32(textBox4.Text) == 3 || (Convert.ToInt32(textBox4.Text) == 4 || (Convert.ToInt32(textBox4.Text) == 6 || (Convert.ToInt32(textBox4.Text) == 8)))) && ((Convert.ToInt32(textBox1.Text)) > 0) && ((Convert.ToInt32(textBox2.Text)) > 0) && ((Convert.ToInt32(textBox4.Text)) > 0))
                    if ((((Convert.ToDouble(textBox3.Text)) == 0) || ((Convert.ToDouble(textBox3.Text)) == 0.3)) && ((Convert.ToInt32(textBox3.Text)) >= 0))
                    {
                        label40.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;

                        label7.Visible = true;
                        label16.Visible = true;
                        label7.Visible = true;
                        label18.Visible = true;
                        label19.Visible = true;
                        label20.Visible = true;
                        label21.Visible = true;
                        label22.Visible = true;
                        label29.Visible = true;
                        label1.Visible = true;
                        label30.Visible = true;
                        label31.Visible = true;
                        label32.Visible = true;
                        label39.Visible = true;
                        label38.Visible = true;
                        label37.Visible = true;
                        label36.Visible = true;
                        int aw, a, x1, x2, b, u, y, del_y;
                        double at, atw, m, d1, d2, dw1, dw2, da1, da2, df1, df2, z1, z2, tan_at;
                        aw = Convert.ToInt32(textBox1.Text);
                        b = Convert.ToInt32(textBox2.Text);
                        x1 = Convert.ToInt32(textBox3.Text);
                        u = Convert.ToInt32(textBox4.Text);
                        x2 = (-1) * x1;
                        a = aw;
                        m = 0.01 * aw;
                        z1 = 2 * aw * Math.Cos(b) / (m * (u + 1));
                        Math.Ceiling(z1);
                        z2 = z1 * u;
                        Math.Ceiling(z2);
                        d1 = 2 * aw / (u + 1);
                        dw1 = d1;
                        dw2 = 2 * aw * u / (u + 1);
                        d2 = dw2;
                        tan_at = Math.Tan(20) / Math.Cos(b);
                        at = Math.Atan(tan_at);
                        atw = at;
                        y = 0;
                        del_y = 0;
                        da1 = d1 + 2 * (1 + x1 - del_y);
                        da2 = d2 + 2 * (1 + x2 - y);
                        df1 = d1 - 2 * (1.25 - x1) * m;
                        df2 = d2 - 2 * (1.25 - x2) * m;

                        label7.Text = m.ToString();
                        label16.Text = z1.ToString();
                        label7.Text = z2.ToString();
                        label18.Text = x2.ToString();
                        label19.Text = d1.ToString();
                        label20.Text = d2.ToString();
                        label21.Text = dw1.ToString();
                        label22.Text = dw2.ToString();
                        label29.Text = a.ToString();
                        label1.Text = at.ToString();
                        label30.Text = atw.ToString();
                        label31.Text = y.ToString();
                        label32.Text = del_y.ToString();
                        label39.Text = da1.ToString();
                        label38.Text = da2.ToString();
                        label37.Text = df1.ToString();
                        label36.Text = df2.ToString();
                    }
                    else
                    {
                        label40.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        if (((Convert.ToInt32(textBox1.Text)) <= 150) || ((Convert.ToInt32(textBox1.Text)) >= 250))
                            label40.Visible = true;
                        if (((Convert.ToInt32(textBox2.Text)) <= 0) || (Convert.ToInt32(textBox2.Text)) >= 40)
                            label41.Visible = true;
                        if (((Convert.ToDouble(textBox3.Text)) != 0) || ((Convert.ToDouble(textBox3.Text)) != 0.3))
                            label42.Visible = true;
                        if (Convert.ToInt32(textBox4.Text) != 3 || (Convert.ToInt32(textBox4.Text) != 4 || (Convert.ToInt32(textBox4.Text) != 6 || (Convert.ToInt32(textBox4.Text) != 8))))
                            label43.Visible = true;
                        MessageBox.Show("Выход за пределы допустимых значений переменных. Возле неправильно заполненных ячеек появится предупреждение о неправильном вводе.", "Ошибка записи данных");
                        label7.Visible = false;
                        label16.Visible = false;
                        label7.Visible = false;
                        label18.Visible = false;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = false;
                        label29.Visible = false;
                        label1.Visible = false;
                        label30.Visible = false;
                        label31.Visible = false;
                        label32.Visible = false;
                        label39.Visible = false;
                        label38.Visible = false;
                        label37.Visible = false;
                        label36.Visible = false;
                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string[] lines = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text};
            System.IO.File.WriteAllLines(filename, lines);
            MessageBox.Show("Файл сохранен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string[] lines = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            System.IO.File.WriteAllLines(filename, lines);
            MessageBox.Show("Файл сохранен");
        }
    }
}
