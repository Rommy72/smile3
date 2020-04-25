using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMILE
{
    public partial class Form3 : Form 
    {
        string connectionString = "";

        string textBoxConfirmPassword = "1234";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelKANSALAISUUS.Text = Form1.SetValueForTextBoxKansalaisuus;
            labelHETU.Text = Form1.SetValueForTextBoxHlötunnus;
            labelPASSI.Text = Form1.SetValueForTextBoxPassi;
            labelETU.Text = Form1.SetValueForTextBoxEtu;
            labelSUKU.Text = Form1.SetValueForTextBoxSuku;
            labelOSOITE.Text = Form1.SetValueForTextBoxOsoite;
            labelKAUPUNKI.Text = Form1.SetValueForTextBoxKaupunki;
            labelPOSTI.Text = Form1.SetValueForTextBoxPosti;
            labelPUHELIN.Text = Form1.SetValueForTextBoxPuhelin;
            labelEMAIL.Text = Form1.SetValueForTextBoxEmail;
            labelSYY.Text = Form1.SetValueForTextBoxSyy;
            labelARRIVAL.Text = Form1.SetValueForTextBoxSaapuminen;
            labelDEPARTURE.Text = Form1.SetValueForTextBoxLähteminen;
            labelMARKKINOINTI.Text = Form1.SetValueForTextBoxMarkkinointi;
            labelETUNIMET.text = Form2.SetValueForTextboxm2Etu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            if (textBoxCompany.Text == "" || textBoxCompanyId.Text == "" || textBoxCompanyAddress.Text == "")
            {
                MessageBox.Show("Täytä vaadittavat kentät","VIRHE");
            }
            else if (textBoxPassword.Text != textBoxConfirmPassword)
            {
                MessageBox.Show("Tunnus on väärä","VIRHE");
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Tarkista asiakkaan tiedot","VIRHE");
            }
            else
          {
                MessageBox.Show("Testi onnistui");
                //Tähän tulee SQL lauseet, jotka suoritettaan vasta kun ylläolevat parametrit täyttyvät
             /*   using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("CustomerAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textBoxEtu.Text.Trim());
                }
                */
          }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //button1.Enabled = (checkBox1.CheckState == CheckState.Checked);
        }

        private void label28_Click(object sender, EventArgs e)//kanssamatkustaja 1
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)//kanssamatkustaja2 
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)// kanssamatkustaja 3

        {
            

        }


        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)// kanssamatkustaja 4
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)//kanssamatkustaja 5
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }
    }
}
