using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examee
{
    public partial class Form1 : Form
    {
        int sum;
        int days;
        public Form1()
        {
            InitializeComponent();
        }

        private void vivod_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text);
            if (a >= 500000)
            {
                MessageBox.Show("Более 500000 не выдаем");
                Application.Restart();
            }
            days = Convert.ToInt32(days1.Text);
            if (days > 0 && days < 6)
            {
                stavka.Text = "1-5 дни 0.9%";
            }

            else if (days > 5 && days < 11)
            {
                stavka.Text = "6-10 дни 0.7%";
            }

            else if (days > 10 && days < 366)
            {
                stavka.Text = "11 и больше дней 0.6%";
            }
            switch (stavka.Text)
            {
                case "1-5 дни 0.9%":

                    if (days > 0 && days < 6)
                    {
                        boxresult.Text = Convert.ToString((a / 100) * 0.9 * days + a);
                        break;
                    }
                    Application.Restart();
                    break;
                case "6-10 дни 0.7%":
                    if (days > 5 && days < 11)
                    {
                        boxresult.Text = Convert.ToString(((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * (days - 5) + a));
                        break;
                    }
                    Application.Restart();
                    break;
                case "11 и больше дней 0.6%":
                    if (days > 10 && days < 366)
                    {
                        double d = ((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * 5) + ((a / 100) * 0.6 * (days - 10) + a);

                        if ((a * 2.5) < d)
                        {
                            d = a * 2.5;
                        }
                        boxresult.Text = Convert.ToString(d);
                        break;
                    }
                    Application.Restart();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

