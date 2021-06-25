namespace examee
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.Panel();
            this.vivod = new System.Windows.Forms.Button();
            this.savee = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.LoanAmount = new System.Windows.Forms.Label();
            this.NumberOfDays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.days1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stavka = new System.Windows.Forms.TextBox();
            this.boxresult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.procent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(417, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // vivod
            // 
            this.vivod.Location = new System.Drawing.Point(226, 26);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(172, 23);
            this.vivod.TabIndex = 1;
            this.vivod.Text = "Вывести таблицу с расчетами";
            this.vivod.UseVisualStyleBackColor = true;
            this.vivod.Click += new System.EventHandler(this.vivod_Click);
            // 
            // savee
            // 
            this.savee.Location = new System.Drawing.Point(226, 122);
            this.savee.Name = "savee";
            this.savee.Size = new System.Drawing.Size(172, 23);
            this.savee.TabIndex = 2;
            this.savee.Text = "Сохранить таблицу";
            this.savee.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(226, 75);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(172, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить результат";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // LoanAmount
            // 
            this.LoanAmount.AutoSize = true;
            this.LoanAmount.Location = new System.Drawing.Point(36, 12);
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Size = new System.Drawing.Size(76, 13);
            this.LoanAmount.TabIndex = 4;
            this.LoanAmount.Text = "Сумма займа";
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.AutoSize = true;
            this.NumberOfDays.Location = new System.Drawing.Point(19, 60);
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.Size = new System.Drawing.Size(93, 13);
            this.NumberOfDays.TabIndex = 5;
            this.NumberOfDays.Text = "Количество дней";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ставка";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // days1
            // 
            this.days1.Location = new System.Drawing.Point(12, 77);
            this.days1.Name = "days1";
            this.days1.Size = new System.Drawing.Size(100, 20);
            this.days1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Сумма выплаты";
            // 
            // stavka
            // 
            this.stavka.Location = new System.Drawing.Point(12, 289);
            this.stavka.Name = "stavka";
            this.stavka.Size = new System.Drawing.Size(117, 20);
            this.stavka.TabIndex = 16;
            // 
            // boxresult
            // 
            this.boxresult.Location = new System.Drawing.Point(277, 289);
            this.boxresult.Name = "boxresult";
            this.boxresult.Size = new System.Drawing.Size(100, 20);
            this.boxresult.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "%(накопительно)";
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(153, 289);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(100, 20);
            this.procent.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxresult);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.days1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumberOfDays);
            this.Controls.Add(this.LoanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stavka);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.savee);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dataGridView1;
        private System.Windows.Forms.Button vivod;
        private System.Windows.Forms.Button savee;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label LoanAmount;
        private System.Windows.Forms.Label NumberOfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox days1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stavka;
        private System.Windows.Forms.TextBox boxresult;
        private System.Windows.Forms.TextBox procent;
        private System.Windows.Forms.Label label2;
    }
}

