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
        string connectionString = @"Data Source=LAPTOP-7I6B82VE\SQLEXPRESS;Initial Catalog = TravellerDB; Integrated Security = True";


        string textBoxConfirmPassword = "1234";
        string textBoxConfirmAccount1 = "TK";
        string textBoxConfirmAccount2 = "OH";
        string textBoxConfirmAccount3 = "MS";
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
            labelm1Suku.Text = Form2.SetValueForTextboxm1Suku;
            labelm1Etu.Text = Form2.SetValueForTextboxm1Etu;
            labelm1Hetu.Text = Form2.SetValueForTextboxm1Hetu;
            labelm2Suku.Text = Form2.SetValueForTextboxm2Suku;
            labelm2Etu.Text = Form2.SetValueForTextboxm2Etu;
            labelm2Hetu.Text = Form2.SetValueForTextboxm2Hetu;
            labelm3Suku.Text = Form2.SetValueForTextboxm3Suku;
            labelm3Etu.Text = Form2.SetValueForTextboxm3Etu;
            labelm3Hetu.Text = Form2.SetValueForTextboxm3Hetu;
            labelm3Suku.Text = Form2.SetValueForTextboxm4Suku;
            labelm3Etu.Text = Form2.SetValueForTextboxm4Etu;
            labelm3Hetu.Text = Form2.SetValueForTextboxm4Hetu;
            labelm3Suku.Text = Form2.SetValueForTextboxm5Suku;
            labelm3Etu.Text = Form2.SetValueForTextboxm5Etu;
            labelm3Hetu.Text = Form2.SetValueForTextboxm5Hetu;

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
            else if (textBoxPassword.Text != textBoxConfirmPassword)
            {
                MessageBox.Show("Salasana on väärä", "VIRHE");
            }
            else if (textBoxAccount.Text != textBoxConfirmAccount1 && textBoxAccount.Text != textBoxConfirmAccount2 && textBoxAccount.Text != textBoxConfirmAccount3)
            {
                MessageBox.Show("Virheellinen tunnus", "Virhe");
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Tarkista asiakkaan tiedot","VIRHE");
            }
            else
          {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("CustomerAdd1", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", labelETU.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", labelSUKU.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Nationality", labelKANSALAISUUS.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SocialNumber", labelHETU.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PassportNumber", labelPASSI.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", labelOSOITE.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", labelKAUPUNKI.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PostalCode", labelPOSTI.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PhoneNumber", labelPUHELIN.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", labelEMAIL.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Arrival", labelARRIVAL.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Departure", labelDEPARTURE.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AllowAds", labelMARKKINOINTI.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Reason", labelSYY.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                }

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //button1.Enabled = (checkBox1.CheckState == CheckState.Checked);
        }

        private void Kanssamatkustaja1_Click(object sender, EventArgs e)
        {

        }

        private void m1Suku_Click(object sender, EventArgs e)
        {

        }

        private void m1Etu_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
