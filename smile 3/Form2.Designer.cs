namespace SMILE
{
    partial class Form2
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
            this.buttonEdellinen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeuraava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSuku = new System.Windows.Forms.Label();
            this.m2Suku = new System.Windows.Forms.TextBox();
            this.m1Suku = new System.Windows.Forms.TextBox();
            this.m3Suku = new System.Windows.Forms.TextBox();
            this.m4Suku = new System.Windows.Forms.TextBox();
            this.m5Suku = new System.Windows.Forms.TextBox();
            this.labelEtu = new System.Windows.Forms.Label();
            this.labelHetu = new System.Windows.Forms.Label();
            this.m2Etu = new System.Windows.Forms.TextBox();
            this.m1Etu = new System.Windows.Forms.TextBox();
            this.m3Etu = new System.Windows.Forms.TextBox();
            this.m4Etu = new System.Windows.Forms.TextBox();
            this.m5Etu = new System.Windows.Forms.TextBox();
            this.m1Hetu = new System.Windows.Forms.TextBox();
            this.m2hetu = new System.Windows.Forms.TextBox();
            this.m3Hetu = new System.Windows.Forms.TextBox();
            this.m4Hetu = new System.Windows.Forms.TextBox();
            this.m5Hetu = new System.Windows.Forms.TextBox();
            this.m1Label = new System.Windows.Forms.Label();
            this.m2Label = new System.Windows.Forms.Label();
            this.m3Label = new System.Windows.Forms.Label();
            this.m4Lable = new System.Windows.Forms.Label();
            this.m5Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEdellinen
            // 
            this.buttonEdellinen.Location = new System.Drawing.Point(15, 457);
            this.buttonEdellinen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdellinen.Name = "buttonEdellinen";
            this.buttonEdellinen.Size = new System.Drawing.Size(107, 34);
            this.buttonEdellinen.TabIndex = 0;
            this.buttonEdellinen.Text = "Edellinen";
            this.buttonEdellinen.UseVisualStyleBackColor = true;
            this.buttonEdellinen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matkustajan  mukana olevan puolison ja alaikäisten lasten henkilötiedot\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSeuraava
            // 
            this.buttonSeuraava.Location = new System.Drawing.Point(753, 457);
            this.buttonSeuraava.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeuraava.Name = "buttonSeuraava";
            this.buttonSeuraava.Size = new System.Drawing.Size(100, 28);
            this.buttonSeuraava.TabIndex = 3;
            this.buttonSeuraava.Text = "Seuraava";
            this.buttonSeuraava.UseVisualStyleBackColor = true;
            this.buttonSeuraava.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // labelSuku
            // 
            this.labelSuku.AutoSize = true;
            this.labelSuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuku.Location = new System.Drawing.Point(28, 92);
            this.labelSuku.Name = "labelSuku";
            this.labelSuku.Size = new System.Drawing.Size(73, 17);
            this.labelSuku.TabIndex = 5;
            this.labelSuku.Text = "Sukunimi";
            this.labelSuku.Click += new System.EventHandler(this.labelSuku_Click);
            // 
            // m2Suku
            // 
            this.m2Suku.Location = new System.Drawing.Point(31, 163);
            this.m2Suku.Margin = new System.Windows.Forms.Padding(4);
            this.m2Suku.Name = "m2Suku";
            this.m2Suku.Size = new System.Drawing.Size(207, 22);
            this.m2Suku.TabIndex = 6;
            this.m2Suku.TextChanged += new System.EventHandler(this.m2Suku_TextChanged);
            // 
            // m1Suku
            // 
            this.m1Suku.Location = new System.Drawing.Point(31, 113);
            this.m1Suku.Margin = new System.Windows.Forms.Padding(4);
            this.m1Suku.Name = "m1Suku";
            this.m1Suku.Size = new System.Drawing.Size(207, 22);
            this.m1Suku.TabIndex = 7;
            this.m1Suku.TextChanged += new System.EventHandler(this.m1Suku_TextChanged);
            // 
            // m3Suku
            // 
            this.m3Suku.Location = new System.Drawing.Point(31, 214);
            this.m3Suku.Margin = new System.Windows.Forms.Padding(4);
            this.m3Suku.Name = "m3Suku";
            this.m3Suku.Size = new System.Drawing.Size(207, 22);
            this.m3Suku.TabIndex = 8;
            this.m3Suku.Visible = false;
            this.m3Suku.TextChanged += new System.EventHandler(this.m3Suku_TextChanged);
            // 
            // m4Suku
            // 
            this.m4Suku.Location = new System.Drawing.Point(31, 262);
            this.m4Suku.Margin = new System.Windows.Forms.Padding(4);
            this.m4Suku.Name = "m4Suku";
            this.m4Suku.Size = new System.Drawing.Size(207, 22);
            this.m4Suku.TabIndex = 9;
            this.m4Suku.TextChanged += new System.EventHandler(this.m4Suku_TextChanged);
            // 
            // m5Suku
            // 
            this.m5Suku.Location = new System.Drawing.Point(31, 307);
            this.m5Suku.Margin = new System.Windows.Forms.Padding(4);
            this.m5Suku.Name = "m5Suku";
            this.m5Suku.Size = new System.Drawing.Size(207, 22);
            this.m5Suku.TabIndex = 10;
            this.m5Suku.TextChanged += new System.EventHandler(this.m5Suku_TextChanged);
            // 
            // labelEtu
            // 
            this.labelEtu.AutoSize = true;
            this.labelEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtu.Location = new System.Drawing.Point(289, 92);
            this.labelEtu.Name = "labelEtu";
            this.labelEtu.Size = new System.Drawing.Size(71, 17);
            this.labelEtu.TabIndex = 16;
            this.labelEtu.Text = "Etunimet";
            this.labelEtu.Click += new System.EventHandler(this.labelEtu_Click);
            // 
            // labelHetu
            // 
            this.labelHetu.AutoSize = true;
            this.labelHetu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHetu.Location = new System.Drawing.Point(579, 92);
            this.labelHetu.Name = "labelHetu";
            this.labelHetu.Size = new System.Drawing.Size(205, 17);
            this.labelHetu.TabIndex = 17;
            this.labelHetu.Text = "Henkilötunnus/syntymäaika";
            this.labelHetu.Click += new System.EventHandler(this.labelHetu_Click);
            // 
            // m2Etu
            // 
            this.m2Etu.Location = new System.Drawing.Point(289, 163);
            this.m2Etu.Margin = new System.Windows.Forms.Padding(4);
            this.m2Etu.Name = "m2Etu";
            this.m2Etu.Size = new System.Drawing.Size(233, 22);
            this.m2Etu.TabIndex = 18;
            this.m2Etu.TextChanged += new System.EventHandler(this.m2Etu_TextChanged);
            // 
            // m1Etu
            // 
            this.m1Etu.Location = new System.Drawing.Point(289, 112);
            this.m1Etu.Margin = new System.Windows.Forms.Padding(4);
            this.m1Etu.Name = "m1Etu";
            this.m1Etu.Size = new System.Drawing.Size(233, 22);
            this.m1Etu.TabIndex = 19;
            this.m1Etu.TextChanged += new System.EventHandler(this.m1Etu_TextChanged);
            // 
            // m3Etu
            // 
            this.m3Etu.Location = new System.Drawing.Point(289, 214);
            this.m3Etu.Margin = new System.Windows.Forms.Padding(4);
            this.m3Etu.Name = "m3Etu";
            this.m3Etu.Size = new System.Drawing.Size(233, 22);
            this.m3Etu.TabIndex = 20;
            this.m3Etu.TextChanged += new System.EventHandler(this.m3Etu_TextChanged);
            // 
            // m4Etu
            // 
            this.m4Etu.Location = new System.Drawing.Point(289, 262);
            this.m4Etu.Margin = new System.Windows.Forms.Padding(4);
            this.m4Etu.Name = "m4Etu";
            this.m4Etu.Size = new System.Drawing.Size(233, 22);
            this.m4Etu.TabIndex = 21;
            this.m4Etu.TextChanged += new System.EventHandler(this.m4Etu_TextChanged);
            // 
            // m5Etu
            // 
            this.m5Etu.Location = new System.Drawing.Point(289, 305);
            this.m5Etu.Margin = new System.Windows.Forms.Padding(4);
            this.m5Etu.Name = "m5Etu";
            this.m5Etu.Size = new System.Drawing.Size(233, 22);
            this.m5Etu.TabIndex = 22;
            this.m5Etu.TextChanged += new System.EventHandler(this.m5Etu_TextChanged);
            // 
            // m1Hetu
            // 
            this.m1Hetu.Location = new System.Drawing.Point(583, 114);
            this.m1Hetu.Margin = new System.Windows.Forms.Padding(4);
            this.m1Hetu.Name = "m1Hetu";
            this.m1Hetu.Size = new System.Drawing.Size(132, 22);
            this.m1Hetu.TabIndex = 28;
            this.m1Hetu.TextChanged += new System.EventHandler(this.m1Hetu_TextChanged);
            // 
            // m2hetu
            // 
            this.m2hetu.Location = new System.Drawing.Point(582, 163);
            this.m2hetu.Margin = new System.Windows.Forms.Padding(4);
            this.m2hetu.Name = "m2hetu";
            this.m2hetu.Size = new System.Drawing.Size(132, 22);
            this.m2hetu.TabIndex = 29;
            this.m2hetu.TextChanged += new System.EventHandler(this.m2hetu_TextChanged);
            // 
            // m3Hetu
            // 
            this.m3Hetu.Location = new System.Drawing.Point(582, 214);
            this.m3Hetu.Margin = new System.Windows.Forms.Padding(4);
            this.m3Hetu.Name = "m3Hetu";
            this.m3Hetu.Size = new System.Drawing.Size(132, 22);
            this.m3Hetu.TabIndex = 30;
            this.m3Hetu.TextChanged += new System.EventHandler(this.m3Hetu_TextChanged);
            // 
            // m4Hetu
            // 
            this.m4Hetu.Location = new System.Drawing.Point(582, 262);
            this.m4Hetu.Margin = new System.Windows.Forms.Padding(4);
            this.m4Hetu.Name = "m4Hetu";
            this.m4Hetu.Size = new System.Drawing.Size(132, 22);
            this.m4Hetu.TabIndex = 31;
            this.m4Hetu.TextChanged += new System.EventHandler(this.m4Hetu_TextChanged);
            // 
            // m5Hetu
            // 
            this.m5Hetu.Location = new System.Drawing.Point(582, 305);
            this.m5Hetu.Margin = new System.Windows.Forms.Padding(4);
            this.m5Hetu.Name = "m5Hetu";
            this.m5Hetu.Size = new System.Drawing.Size(132, 22);
            this.m5Hetu.TabIndex = 32;
            this.m5Hetu.TextChanged += new System.EventHandler(this.m5Hetu_TextChanged);
            // 
            // m1Label
            // 
            this.m1Label.AutoSize = true;
            this.m1Label.Location = new System.Drawing.Point(8, 118);
            this.m1Label.Name = "m1Label";
            this.m1Label.Size = new System.Drawing.Size(16, 17);
            this.m1Label.TabIndex = 38;
            this.m1Label.Text = "1";
            this.m1Label.Click += new System.EventHandler(this.m1Label_Click);
            // 
            // m2Label
            // 
            this.m2Label.AutoSize = true;
            this.m2Label.Location = new System.Drawing.Point(8, 163);
            this.m2Label.Name = "m2Label";
            this.m2Label.Size = new System.Drawing.Size(16, 17);
            this.m2Label.TabIndex = 39;
            this.m2Label.Text = "2";
            this.m2Label.Click += new System.EventHandler(this.m2Label_Click);
            // 
            // m3Label
            // 
            this.m3Label.AutoSize = true;
            this.m3Label.Location = new System.Drawing.Point(8, 214);
            this.m3Label.Name = "m3Label";
            this.m3Label.Size = new System.Drawing.Size(16, 17);
            this.m3Label.TabIndex = 40;
            this.m3Label.Text = "3";
            this.m3Label.Click += new System.EventHandler(this.m3Label_Click);
            // 
            // m4Lable
            // 
            this.m4Lable.AutoSize = true;
            this.m4Lable.Location = new System.Drawing.Point(8, 262);
            this.m4Lable.Name = "m4Lable";
            this.m4Lable.Size = new System.Drawing.Size(16, 17);
            this.m4Lable.TabIndex = 41;
            this.m4Lable.Text = "4";
            this.m4Lable.Click += new System.EventHandler(this.m4Lable_Click);
            // 
            // m5Label
            // 
            this.m5Label.AutoSize = true;
            this.m5Label.Location = new System.Drawing.Point(8, 310);
            this.m5Label.Name = "m5Label";
            this.m5Label.Size = new System.Drawing.Size(16, 17);
            this.m5Label.TabIndex = 42;
            this.m5Label.Text = "5";
            this.m5Label.Click += new System.EventHandler(this.m5Label_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 542);
            this.Controls.Add(this.m5Label);
            this.Controls.Add(this.m4Lable);
            this.Controls.Add(this.m3Label);
            this.Controls.Add(this.m2Label);
            this.Controls.Add(this.m1Label);
            this.Controls.Add(this.m5Hetu);
            this.Controls.Add(this.m4Hetu);
            this.Controls.Add(this.m3Hetu);
            this.Controls.Add(this.m2hetu);
            this.Controls.Add(this.m1Hetu);
            this.Controls.Add(this.m5Etu);
            this.Controls.Add(this.m4Etu);
            this.Controls.Add(this.m3Etu);
            this.Controls.Add(this.m1Etu);
            this.Controls.Add(this.m2Etu);
            this.Controls.Add(this.labelHetu);
            this.Controls.Add(this.labelEtu);
            this.Controls.Add(this.m5Suku);
            this.Controls.Add(this.m4Suku);
            this.Controls.Add(this.m3Suku);
            this.Controls.Add(this.m1Suku);
            this.Controls.Add(this.m2Suku);
            this.Controls.Add(this.labelSuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSeuraava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdellinen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Kanssamatkustajat";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdellinen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSeuraava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSuku;
        private System.Windows.Forms.TextBox m2Suku;
        private System.Windows.Forms.TextBox m1Suku;
        private System.Windows.Forms.TextBox m3Suku;
        private System.Windows.Forms.TextBox m4Suku;
        private System.Windows.Forms.TextBox m5Suku;
        private System.Windows.Forms.Label labelEtu;
        private System.Windows.Forms.Label labelHetu;
        private System.Windows.Forms.TextBox m2Etu;
        private System.Windows.Forms.TextBox m1Etu;
        private System.Windows.Forms.TextBox m3Etu;
        private System.Windows.Forms.TextBox m4Etu;
        private System.Windows.Forms.TextBox m5Etu;
        private System.Windows.Forms.TextBox m1Hetu;
        private System.Windows.Forms.TextBox m2hetu;
        private System.Windows.Forms.TextBox m3Hetu;
        private System.Windows.Forms.TextBox m4Hetu;
        private System.Windows.Forms.TextBox m5Hetu;
        private System.Windows.Forms.Label m1Label;
        private System.Windows.Forms.Label m2Label;
        private System.Windows.Forms.Label m3Label;
        private System.Windows.Forms.Label m4Lable;
        private System.Windows.Forms.Label m5Label;
    }
}