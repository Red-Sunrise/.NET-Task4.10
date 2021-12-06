using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programmers;

namespace Task_4._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = SurnameFirst.Text;
            int programs_count = Convert.ToInt32(ProgrammCountFirst.Value);
            int languages_count = Convert.ToInt32(LanguagesCountFirst.Value);

            ProgrammerFirstLevel programmer = new ProgrammerFirstLevel(surname, programs_count, languages_count);

            FirstInfo.Text = programmer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string surname = SurnameSecond.Text;
            int programs_count = Convert.ToInt32(ProgrammCountSecond.Value);
            int languages_count = Convert.ToInt32(LanguagesCountSecond.Value);
            int correct_programs = Convert.ToInt32(CorrectProgramms.Value);

            ProgrammerSecondLevel programmer = new ProgrammerSecondLevel(surname, programs_count, languages_count, correct_programs);

            SecondInfo.Text = programmer.ToString();
        }
    }
}
