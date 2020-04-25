using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMILE
{
    public partial class Form1 : Form
    {
        public static string SetValueForTextBoxEtu = "";
        public static string SetValueForTextBoxSuku = "";
        public static string SetValueForTextBoxOsoite = "";
        public static string SetValueForTextBoxKaupunki = "";
        public static string SetValueForTextBoxPosti = "";
        public static string SetValueForTextBoxPuhelin = "";
        public static string SetValueForTextBoxEmail = "";
        public static string SetValueForTextBoxHlötunnus = "";
        public static string SetValueForTextBoxPassi = "";
        public static string SetValueForTextBoxKansalaisuus = "";
        public static string SetValueForTextBoxSaapuminen = "";
        public static string SetValueForTextBoxLähteminen = "";
        public static string SetValueForTextBoxSyy = "";
        public static string SetValueForTextBoxMarkkinointi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
        SetValueForTextBoxEtu = textBoxEtu.Text;
            SetValueForTextBoxSuku = textBoxSuku.Text;
            SetValueForTextBoxOsoite = textBoxOsoite.Text;
            SetValueForTextBoxKaupunki = textBoxKaupunki.Text;
            SetValueForTextBoxPosti = textBoxPosti.Text;
            SetValueForTextBoxPuhelin = textBoxPuhelin.Text;
            SetValueForTextBoxEmail = textBoxEmail.Text;
            SetValueForTextBoxHlötunnus = textBox3.Text;
            SetValueForTextBoxPassi = textBox10.Text;
            if (radioButtonSuomalainen.Checked == true)
                {
                SetValueForTextBoxKansalaisuus = "Suomalainen";
            }
            else
            {
                SetValueForTextBoxKansalaisuus = textBoxKansalaisuus.Text;
            }
            SetValueForTextBoxSaapuminen = Arrival.Text;
            SetValueForTextBoxLähteminen = Departure.Text;
            if (radioButtonLoma.Checked == true)
            {
                SetValueForTextBoxSyy = "Loma";
            }
            if (radioButtonTyo.Checked == true)
            {
                SetValueForTextBoxSyy = "Työ";
            }
            if (radioButtonKokous.Checked == true)
            {
                SetValueForTextBoxSyy = "Kokous";
            }
            if (radioButtonMuuSyy.Checked == true)
            {
                SetValueForTextBoxSyy = textBoxMuuSyy.Text;
            }
            if (checkBox1.Checked == true)
            {
                SetValueForTextBoxMarkkinointi = "Y";
            }
            else
            {
                SetValueForTextBoxMarkkinointi = "N";
            }


            if (radioButtonSuomalainen.Checked == false 
                && radioButtonMuuKansa.Checked == false 
                || textBoxEtu.Text == "" 
                || textBoxSuku.Text =="" 
                || textBoxOsoite.Text == "" 
                || textBoxKaupunki.Text == "" 
                || textBoxPosti.Text == "" 
                || textBoxPuhelin.Text == "")
            {
                MessageBox.Show("Täytä tähdellä merkityt kentät.");
            }
            else
            {
                var newForm = new Form2();
                newForm.Show();
                Visible = false;
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMuuSyy.Checked)
            {
                textBoxMuuSyy.Enabled = true;
            }
            else
            {
                textBoxMuuSyy.Enabled = false;
                textBoxMuuSyy.Clear();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMuuKansa.Checked)
            {
                textBoxKansalaisuus.Enabled = true;
                textBox10.Enabled = true;
            }
            else
            {
                textBoxKansalaisuus.Enabled = false;
                textBoxKansalaisuus.Clear();
                textBox10.Enabled = false;
                textBox10.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSuomalainen.Checked)
            {
                
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Clear();
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
