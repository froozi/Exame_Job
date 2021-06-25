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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vivod = new System.Windows.Forms.Button();
            this.savee = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.LoanAmount = new System.Windows.Forms.Label();
            this.NumberOfDays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 327);
            this.panel1.TabIndex = 0;
            // 
            // vivod
            // 
            this.vivod.Location = new System.Drawing.Point(616, 12);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(172, 23);
            this.vivod.TabIndex = 1;
            this.vivod.Text = "Вывести таблицу с расчетами";
            this.vivod.UseVisualStyleBackColor = true;
            // 
            // savee
            // 
            this.savee.Location = new System.Drawing.Point(616, 70);
            this.savee.Name = "savee";
            this.savee.Size = new System.Drawing.Size(172, 23);
            this.savee.TabIndex = 2;
            this.savee.Text = "Сохранить таблицу";
            this.savee.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(616, 41);
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
            this.label3.Location = new System.Drawing.Point(199, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процентная ставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0-5 день";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "6-10 день";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "11 и больше дней";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(264, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfDays);
            this.Controls.Add(this.LoanAmount);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.savee);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vivod;
        private System.Windows.Forms.Button savee;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label LoanAmount;
        private System.Windows.Forms.Label NumberOfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

