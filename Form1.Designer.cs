namespace Task_4._10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LanguagesCountFirst = new System.Windows.Forms.NumericUpDown();
            this.ProgrammCountFirst = new System.Windows.Forms.NumericUpDown();
            this.SurnameFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameSecond = new System.Windows.Forms.TextBox();
            this.ProgrammCountSecond = new System.Windows.Forms.NumericUpDown();
            this.LanguagesCountSecond = new System.Windows.Forms.NumericUpDown();
            this.CorrectProgramms = new System.Windows.Forms.NumericUpDown();
            this.SecondInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesCountFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgrammCountFirst)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgrammCountSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesCountSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectProgramms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstInfo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LanguagesCountFirst);
            this.groupBox1.Controls.Add(this.ProgrammCountFirst);
            this.groupBox1.Controls.Add(this.SurnameFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Программист 1-го уровня";
            // 
            // FirstInfo
            // 
            this.FirstInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstInfo.Location = new System.Drawing.Point(0, 150);
            this.FirstInfo.Name = "FirstInfo";
            this.FirstInfo.Size = new System.Drawing.Size(246, 82);
            this.FirstInfo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LanguagesCountFirst
            // 
            this.LanguagesCountFirst.Location = new System.Drawing.Point(147, 71);
            this.LanguagesCountFirst.Name = "LanguagesCountFirst";
            this.LanguagesCountFirst.Size = new System.Drawing.Size(92, 20);
            this.LanguagesCountFirst.TabIndex = 3;
            // 
            // ProgrammCountFirst
            // 
            this.ProgrammCountFirst.Location = new System.Drawing.Point(148, 45);
            this.ProgrammCountFirst.Name = "ProgrammCountFirst";
            this.ProgrammCountFirst.Size = new System.Drawing.Size(92, 20);
            this.ProgrammCountFirst.TabIndex = 2;
            // 
            // SurnameFirst
            // 
            this.SurnameFirst.Location = new System.Drawing.Point(148, 19);
            this.SurnameFirst.Name = "SurnameFirst";
            this.SurnameFirst.Size = new System.Drawing.Size(92, 20);
            this.SurnameFirst.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:\n\n Количество программ: \n\n Количество языков: \n\n ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.SecondInfo);
            this.groupBox2.Controls.Add(this.CorrectProgramms);
            this.groupBox2.Controls.Add(this.LanguagesCountSecond);
            this.groupBox2.Controls.Add(this.ProgrammCountSecond);
            this.groupBox2.Controls.Add(this.SurnameSecond);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(274, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Программист 2-го уровня";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 91);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия:\n\n Количество программ: \n\n Количество языков: \n\n Количество правильных пр" +
    "ограмм:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SurnameSecond
            // 
            this.SurnameSecond.Location = new System.Drawing.Point(185, 19);
            this.SurnameSecond.Name = "SurnameSecond";
            this.SurnameSecond.Size = new System.Drawing.Size(86, 20);
            this.SurnameSecond.TabIndex = 6;
            // 
            // ProgrammCountSecond
            // 
            this.ProgrammCountSecond.Location = new System.Drawing.Point(185, 45);
            this.ProgrammCountSecond.Name = "ProgrammCountSecond";
            this.ProgrammCountSecond.Size = new System.Drawing.Size(86, 20);
            this.ProgrammCountSecond.TabIndex = 6;
            // 
            // LanguagesCountSecond
            // 
            this.LanguagesCountSecond.Location = new System.Drawing.Point(185, 71);
            this.LanguagesCountSecond.Name = "LanguagesCountSecond";
            this.LanguagesCountSecond.Size = new System.Drawing.Size(86, 20);
            this.LanguagesCountSecond.TabIndex = 6;
            // 
            // CorrectProgramms
            // 
            this.CorrectProgramms.Location = new System.Drawing.Point(185, 97);
            this.CorrectProgramms.Name = "CorrectProgramms";
            this.CorrectProgramms.Size = new System.Drawing.Size(86, 20);
            this.CorrectProgramms.TabIndex = 6;
            // 
            // SecondInfo
            // 
            this.SecondInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecondInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondInfo.Location = new System.Drawing.Point(0, 150);
            this.SecondInfo.Name = "SecondInfo";
            this.SecondInfo.Size = new System.Drawing.Size(277, 82);
            this.SecondInfo.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesCountFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgrammCountFirst)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgrammCountSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesCountSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectProgramms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LanguagesCountFirst;
        private System.Windows.Forms.NumericUpDown ProgrammCountFirst;
        private System.Windows.Forms.TextBox SurnameFirst;
        private System.Windows.Forms.Label FirstInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SecondInfo;
        private System.Windows.Forms.NumericUpDown CorrectProgramms;
        private System.Windows.Forms.NumericUpDown LanguagesCountSecond;
        private System.Windows.Forms.NumericUpDown ProgrammCountSecond;
        private System.Windows.Forms.TextBox SurnameSecond;
    }
}

