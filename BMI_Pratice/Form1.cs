using BMI_Pratice.Models;
using BMI_Pratice.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BMI_Pratice.Factory.GenderFactory;

namespace BMI_Pratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HighText = textBox1.Text;
            string WeightText = textBox2.Text;
            int High;
            int Weight;
            Gender gender = Gender.Man;
            if (!GetAndCheckNumber(HighText, out High))
            {
                MessageBox.Show("請輸入身高數字");
            }
            if (!GetAndCheckNumber(WeightText, out Weight))
            {
                MessageBox.Show("請輸入體重數字");
            }
            if (radioButton2.Checked)
            {
                gender = Gender.Woman;
            }
            Person PersonData = new Person
            {
                PersonGende = gender,
                PersonHigh = High,
                PersonWeight = Weight
            };
            HealthExamination Examination = new HealthExamination(PersonData);
            Examination.GetMessageAndBMI();
            textBox3.Text = Examination.Message;
            textBox4.Text = Examination.PersonBMI.ToString();
        }
        private bool GetAndCheckNumber(string NumberText,out int Number)
        {
            bool IsNumber = int.TryParse(NumberText, out Number);
            return IsNumber;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
