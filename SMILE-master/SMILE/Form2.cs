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
    public partial class Form2 : Form
    {
        public static string SetValueForTextboxm1Suku= "";
        public static string SetValueForTextboxm1Etu = "";
        public static string SetValueForTextboxm1Hetu = "";
        public static string SetValueForTextboxm2Suku = "";
        public static string SetValueForTextboxm2Etu = "";
        public static string SetValueForTextboxm2Hetu = "";
        public static string SetValueForTextboxm3Suku = "";
        public static string SetValueForTextboxm3Etu = "";
        public static string SetValueForTextboxm3Hetu = "";
        public static string SetValueForTextboxm4Etu = "";
        public static string SetValueForTextboxm4Suku = "";
        public static string SetValueForTextboxm4Hetu = "";
        public static string SetValueForTextboxm5Etu = "";
        public static string SetValueForTextboxm5Suku = "";
        public static string SetValueForTextboxm5Hetu = "";


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       private void button2_Click(object sender, EventArgs e)
        {
            SetValueForTextboxm1Suku = m1Suku.Text;
            SetValueForTextboxm1Etu = m1Etu.Text;
            SetValueForTextboxm1Hetu = m1Hetu.Text;
            SetValueForTextboxm2Suku = m2Suku.Text;
            SetValueForTextboxm2Etu = m2Etu.Text;
            SetValueForTextboxm2Hetu = m2hetu.Text;
            SetValueForTextboxm3Suku = m3Suku.Text;
            SetValueForTextboxm1Etu = m3Etu.Text;
            SetValueForTextboxm3Hetu = m3Hetu.Text;
            SetValueForTextboxm4Suku = m4Suku.Text;
            SetValueForTextboxm4Etu = m4Etu.Text;
            SetValueForTextboxm4Hetu = m4Hetu.Text;
            SetValueForTextboxm5Suku = m5Suku.Text;
            SetValueForTextboxm5Etu = m5Etu.Text;
            SetValueForTextboxm5Hetu = m5Hetu.Text;
            if (MessageBox.Show("Virkailija täyttää loput.", "Kiitos", MessageBoxButtons.OK) == DialogResult.OK)
            {
                var newForm1 = new Form3();
                newForm1.Show();
                Visible = false;
            }
           
        }
        private void Textbox1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fellowbar_Scroll(object sender, EventArgs e)
        {
            

        }

        private void labelSuku_Click(object sender, EventArgs e)
        {

        }

        private void labelEtu_Click(object sender, EventArgs e)
        {

        }

        private void labelHetu_Click(object sender, EventArgs e)
        {

        }

        private void m1Label_Click(object sender, EventArgs e)
        {

        }

        private void m1Suku_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1Etu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1Hetu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m2Label_Click(object sender, EventArgs e)
        {

        }

        private void m2Suku_TextChanged(object sender, EventArgs e)
        {

        }

        private void m2Etu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m2hetu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m3Label_Click(object sender, EventArgs e)
        {

        }

        private void m3Suku_TextChanged(object sender, EventArgs e)
        {

        }

        private void m3Etu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m3Hetu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m4Lable_Click(object sender, EventArgs e)
        {

        }

        private void m4Suku_TextChanged(object sender, EventArgs e)
        {

        }

        private void m4Etu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m4Hetu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m5Label_Click(object sender, EventArgs e)
        {

        }

        private void m5Suku_TextChanged(object sender, EventArgs e)
        {

        }

        private void m5Etu_TextChanged(object sender, EventArgs e)
        {

        }

        private void m5Hetu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
