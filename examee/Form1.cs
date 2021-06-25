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
        int sums;
        int days;
        DataGridView dataGridView1 = new DataGridView();
        void Funtcion()
        {

            dataGridView1.Size = new Size(600, 400);
            /*создание столбцов*/
            //1 столбец, текстовый
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "day";
            column0.HeaderText = "День";
            //2 столбец, текстовый
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "stavka";
            column1.HeaderText = "Ставка";
            //3 столбец, изображение
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "procent";
            column2.HeaderText = "%(накопительно)";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column2.Name = "sum";
            column2.HeaderText = "Сумма выплаты";
            //добавляем столбцы
            dataGridView1.Columns.AddRange(column0, column1, column2, column3);
        }
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            Funtcion();
        }

        
    }
}
