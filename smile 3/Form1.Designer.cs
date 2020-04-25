namespace SMILE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEtu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSuku = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxOsoite = new System.Windows.Forms.TextBox();
            this.textBoxPuhelin = new System.Windows.Forms.TextBox();
            this.Arrival = new System.Windows.Forms.DateTimePicker();
            this.Departure = new System.Windows.Forms.DateTimePicker();
            this.textBoxMuuSyy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxKaupunki = new System.Windows.Forms.TextBox();
            this.textBoxPosti = new System.Windows.Forms.TextBox();
            this.groupBoxSyy = new System.Windows.Forms.GroupBox();
            this.radioButtonMuuSyy = new System.Windows.Forms.RadioButton();
            this.radioButtonKokous = new System.Windows.Forms.RadioButton();
            this.radioButtonTyo = new System.Windows.Forms.RadioButton();
            this.radioButtonLoma = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBoxKansalaisuus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonMuuKansa = new System.Windows.Forms.RadioButton();
            this.radioButtonSuomalainen = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxSyy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEtu
            // 
            this.textBoxEtu.Location = new System.Drawing.Point(136, 191);
            this.textBoxEtu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEtu.Name = "textBoxEtu";
            this.textBoxEtu.Size = new System.Drawing.Size(175, 19);
            this.textBoxEtu.TabIndex = 1;
            this.textBoxEtu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etunimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Henkilötunnus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Osoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Puhelinnumero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saapuminen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lähteminen";
            // 
            // textBoxSuku
            // 
            this.textBoxSuku.Location = new System.Drawing.Point(136, 225);
            this.textBoxSuku.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSuku.Name = "textBoxSuku";
            this.textBoxSuku.Size = new System.Drawing.Size(175, 19);
            this.textBoxSuku.TabIndex = 9;
            this.textBoxSuku.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(123, 99);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 19);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxOsoite
            // 
            this.textBoxOsoite.Location = new System.Drawing.Point(136, 257);
            this.textBoxOsoite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOsoite.Name = "textBoxOsoite";
            this.textBoxOsoite.Size = new System.Drawing.Size(175, 19);
            this.textBoxOsoite.TabIndex = 11;
            this.textBoxOsoite.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxPuhelin
            // 
            this.textBoxPuhelin.Location = new System.Drawing.Point(136, 353);
            this.textBoxPuhelin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPuhelin.Name = "textBoxPuhelin";
            this.textBoxPuhelin.Size = new System.Drawing.Size(175, 19);
            this.textBoxPuhelin.TabIndex = 12;
            this.textBoxPuhelin.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(470, 34);
            this.Arrival.Margin = new System.Windows.Forms.Padding(4);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(298, 19);
            this.Arrival.TabIndex = 13;
            this.Arrival.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(470, 64);
            this.Departure.Margin = new System.Windows.Forms.Padding(4);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(298, 19);
            this.Departure.TabIndex = 14;
            // 
            // textBoxMuuSyy
            // 
            this.textBoxMuuSyy.Enabled = false;
            this.textBoxMuuSyy.Location = new System.Drawing.Point(21, 141);
            this.textBoxMuuSyy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMuuSyy.Name = "textBoxMuuSyy";
            this.textBoxMuuSyy.Size = new System.Drawing.Size(175, 19);
            this.textBoxMuuSyy.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(675, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Seuraava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Postinumero";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kaupunki";
            // 
            // textBoxKaupunki
            // 
            this.textBoxKaupunki.Location = new System.Drawing.Point(136, 289);
            this.textBoxKaupunki.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKaupunki.Name = "textBoxKaupunki";
            this.textBoxKaupunki.Size = new System.Drawing.Size(175, 19);
            this.textBoxKaupunki.TabIndex = 26;
            this.textBoxKaupunki.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxPosti
            // 
            this.textBoxPosti.Location = new System.Drawing.Point(136, 320);
            this.textBoxPosti.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPosti.Name = "textBoxPosti";
            this.textBoxPosti.Size = new System.Drawing.Size(175, 19);
            this.textBoxPosti.TabIndex = 27;
            this.textBoxPosti.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBoxSyy
            // 
            this.groupBoxSyy.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxSyy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxSyy.Controls.Add(this.radioButtonMuuSyy);
            this.groupBoxSyy.Controls.Add(this.radioButtonKokous);
            this.groupBoxSyy.Controls.Add(this.radioButtonTyo);
            this.groupBoxSyy.Controls.Add(this.radioButtonLoma);
            this.groupBoxSyy.Controls.Add(this.textBoxMuuSyy);
            this.groupBoxSyy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSyy.Location = new System.Drawing.Point(367, 131);
            this.groupBoxSyy.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxSyy.Name = "groupBoxSyy";
            this.groupBoxSyy.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxSyy.Size = new System.Drawing.Size(401, 180);
            this.groupBoxSyy.TabIndex = 28;
            this.groupBoxSyy.TabStop = false;
            this.groupBoxSyy.Text = "Majoittautumisen syy";
            // 
            // radioButtonMuuSyy
            // 
            this.radioButtonMuuSyy.AutoSize = true;
            this.radioButtonMuuSyy.Location = new System.Drawing.Point(18, 114);
            this.radioButtonMuuSyy.Name = "radioButtonMuuSyy";
            this.radioButtonMuuSyy.Size = new System.Drawing.Size(90, 17);
            this.radioButtonMuuSyy.TabIndex = 26;
            this.radioButtonMuuSyy.TabStop = true;
            this.radioButtonMuuSyy.Text = "Muu, mikä?";
            this.radioButtonMuuSyy.UseVisualStyleBackColor = true;
            this.radioButtonMuuSyy.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButtonKokous
            // 
            this.radioButtonKokous.AutoSize = true;
            this.radioButtonKokous.Location = new System.Drawing.Point(18, 87);
            this.radioButtonKokous.Name = "radioButtonKokous";
            this.radioButtonKokous.Size = new System.Drawing.Size(67, 17);
            this.radioButtonKokous.TabIndex = 25;
            this.radioButtonKokous.TabStop = true;
            this.radioButtonKokous.Text = "Kokous";
            this.radioButtonKokous.UseVisualStyleBackColor = true;
            // 
            // radioButtonTyo
            // 
            this.radioButtonTyo.AutoSize = true;
            this.radioButtonTyo.Location = new System.Drawing.Point(18, 60);
            this.radioButtonTyo.Name = "radioButtonTyo";
            this.radioButtonTyo.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTyo.TabIndex = 24;
            this.radioButtonTyo.TabStop = true;
            this.radioButtonTyo.Text = "Työ";
            this.radioButtonTyo.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoma
            // 
            this.radioButtonLoma.AutoSize = true;
            this.radioButtonLoma.Location = new System.Drawing.Point(18, 33);
            this.radioButtonLoma.Name = "radioButtonLoma";
            this.radioButtonLoma.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLoma.TabIndex = 23;
            this.radioButtonLoma.TabStop = true;
            this.radioButtonLoma.Text = "Loma";
            this.radioButtonLoma.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBoxKansalaisuus);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButtonMuuKansa);
            this.groupBox2.Controls.Add(this.radioButtonSuomalainen);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 170);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kansalaisuus";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(307, 129);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(307, 102);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 69);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 48);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(140, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "*";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(123, 129);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(175, 19);
            this.textBox10.TabIndex = 31;
            // 
            // textBoxKansalaisuus
            // 
            this.textBoxKansalaisuus.Enabled = false;
            this.textBoxKansalaisuus.Location = new System.Drawing.Point(7, 69);
            this.textBoxKansalaisuus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKansalaisuus.Name = "textBoxKansalaisuus";
            this.textBoxKansalaisuus.Size = new System.Drawing.Size(283, 19);
            this.textBoxKansalaisuus.TabIndex = 27;
            this.textBoxKansalaisuus.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Passin numero";
            // 
            // radioButtonMuuKansa
            // 
            this.radioButtonMuuKansa.AutoSize = true;
            this.radioButtonMuuKansa.Location = new System.Drawing.Point(7, 46);
            this.radioButtonMuuKansa.Name = "radioButtonMuuKansa";
            this.radioButtonMuuKansa.Size = new System.Drawing.Size(90, 17);
            this.radioButtonMuuKansa.TabIndex = 1;
            this.radioButtonMuuKansa.TabStop = true;
            this.radioButtonMuuKansa.Text = "Muu, mikä?";
            this.radioButtonMuuKansa.UseVisualStyleBackColor = true;
            this.radioButtonMuuKansa.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButtonSuomalainen
            // 
            this.radioButtonSuomalainen.AutoSize = true;
            this.radioButtonSuomalainen.Location = new System.Drawing.Point(7, 19);
            this.radioButtonSuomalainen.Name = "radioButtonSuomalainen";
            this.radioButtonSuomalainen.Size = new System.Drawing.Size(97, 17);
            this.radioButtonSuomalainen.TabIndex = 0;
            this.radioButtonSuomalainen.TabStop = true;
            this.radioButtonSuomalainen.Text = "Suomalainen";
            this.radioButtonSuomalainen.UseVisualStyleBackColor = true;
            this.radioButtonSuomalainen.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Sähköposti";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(136, 383);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 19);
            this.textBoxEmail.TabIndex = 31;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(469, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Tietojani saa käyttää markkinointitarkoituksiin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 230);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 260);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 292);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(321, 320);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 350);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 424);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSyy);
            this.Controls.Add(this.textBoxPosti);
            this.Controls.Add(this.textBoxKaupunki);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.textBoxPuhelin);
            this.Controls.Add(this.textBoxOsoite);
            this.Controls.Add(this.textBoxSuku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEtu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sukunimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSyy.ResumeLayout(false);
            this.groupBoxSyy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSuku;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxOsoite;
        private System.Windows.Forms.TextBox textBoxPuhelin;
        private System.Windows.Forms.DateTimePicker Arrival;
        private System.Windows.Forms.DateTimePicker Departure;
        private System.Windows.Forms.TextBox textBoxMuuSyy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxKaupunki;
        private System.Windows.Forms.TextBox textBoxPosti;
        private System.Windows.Forms.GroupBox groupBoxSyy;
        private System.Windows.Forms.RadioButton radioButtonMuuSyy;
        private System.Windows.Forms.RadioButton radioButtonKokous;
        private System.Windows.Forms.RadioButton radioButtonTyo;
        private System.Windows.Forms.RadioButton radioButtonLoma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKansalaisuus;
        private System.Windows.Forms.RadioButton radioButtonMuuKansa;
        private System.Windows.Forms.RadioButton radioButtonSuomalainen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

