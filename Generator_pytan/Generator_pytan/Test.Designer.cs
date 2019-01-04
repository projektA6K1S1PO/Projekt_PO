namespace Generator_pytan
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.label1 = new System.Windows.Forms.Label();
            this.but_start_test = new System.Windows.Forms.Button();
            this.but_stop_test = new System.Windows.Forms.Button();
            this.panel_pytan = new System.Windows.Forms.Panel();
            this.lab_numer_pytania = new System.Windows.Forms.Label();
            this.check_odp_5 = new System.Windows.Forms.CheckBox();
            this.check_odp_4 = new System.Windows.Forms.CheckBox();
            this.check_odp_3 = new System.Windows.Forms.CheckBox();
            this.check_odp_2 = new System.Windows.Forms.CheckBox();
            this.check_odp_1 = new System.Windows.Forms.CheckBox();
            this.lab_tresc_pytania = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_nastepne_pyt = new System.Windows.Forms.Button();
            this.lab_wynik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_imie = new System.Windows.Forms.Label();
            this.label_nazwisko = new System.Windows.Forms.Label();
            this.label_grupa = new System.Windows.Forms.Label();
            this.label_indeks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_pytan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(196, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // but_start_test
            // 
            this.but_start_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_start_test.Location = new System.Drawing.Point(345, 505);
            this.but_start_test.Name = "but_start_test";
            this.but_start_test.Size = new System.Drawing.Size(159, 105);
            this.but_start_test.TabIndex = 2;
            this.but_start_test.Text = "Rozpocznij rozwiązywanie testu";
            this.but_start_test.UseVisualStyleBackColor = true;
            this.but_start_test.Click += new System.EventHandler(this.start_test_Click_1);
            // 
            // but_stop_test
            // 
            this.but_stop_test.ForeColor = System.Drawing.Color.Red;
            this.but_stop_test.Image = ((System.Drawing.Image)(resources.GetObject("but_stop_test.Image")));
            this.but_stop_test.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_stop_test.Location = new System.Drawing.Point(932, 505);
            this.but_stop_test.Name = "but_stop_test";
            this.but_stop_test.Size = new System.Drawing.Size(158, 105);
            this.but_stop_test.TabIndex = 3;
            this.but_stop_test.Text = "Zakończ test bez zapisywania wyniku";
            this.but_stop_test.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_stop_test.UseVisualStyleBackColor = true;
            this.but_stop_test.Click += new System.EventHandler(this.but_stop_test_Click);
            // 
            // panel_pytan
            // 
            this.panel_pytan.Controls.Add(this.lab_numer_pytania);
            this.panel_pytan.Controls.Add(this.check_odp_5);
            this.panel_pytan.Controls.Add(this.check_odp_4);
            this.panel_pytan.Controls.Add(this.check_odp_3);
            this.panel_pytan.Controls.Add(this.check_odp_2);
            this.panel_pytan.Controls.Add(this.check_odp_1);
            this.panel_pytan.Controls.Add(this.lab_tresc_pytania);
            this.panel_pytan.Controls.Add(this.label2);
            this.panel_pytan.Location = new System.Drawing.Point(345, 85);
            this.panel_pytan.Name = "panel_pytan";
            this.panel_pytan.Size = new System.Drawing.Size(744, 401);
            this.panel_pytan.TabIndex = 4;
            this.panel_pytan.Visible = false;
            // 
            // lab_numer_pytania
            // 
            this.lab_numer_pytania.AutoSize = true;
            this.lab_numer_pytania.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_numer_pytania.Location = new System.Drawing.Point(627, 14);
            this.lab_numer_pytania.Name = "lab_numer_pytania";
            this.lab_numer_pytania.Size = new System.Drawing.Size(87, 29);
            this.lab_numer_pytania.TabIndex = 8;
            this.lab_numer_pytania.Text = "label4";
            // 
            // check_odp_5
            // 
            this.check_odp_5.AutoSize = true;
            this.check_odp_5.Location = new System.Drawing.Point(46, 357);
            this.check_odp_5.Name = "check_odp_5";
            this.check_odp_5.Size = new System.Drawing.Size(18, 17);
            this.check_odp_5.TabIndex = 6;
            this.check_odp_5.UseVisualStyleBackColor = true;
            this.check_odp_5.Visible = false;
            // 
            // check_odp_4
            // 
            this.check_odp_4.AutoSize = true;
            this.check_odp_4.Location = new System.Drawing.Point(46, 301);
            this.check_odp_4.Name = "check_odp_4";
            this.check_odp_4.Size = new System.Drawing.Size(18, 17);
            this.check_odp_4.TabIndex = 5;
            this.check_odp_4.UseVisualStyleBackColor = true;
            // 
            // check_odp_3
            // 
            this.check_odp_3.AutoSize = true;
            this.check_odp_3.Location = new System.Drawing.Point(46, 243);
            this.check_odp_3.Name = "check_odp_3";
            this.check_odp_3.Size = new System.Drawing.Size(18, 17);
            this.check_odp_3.TabIndex = 4;
            this.check_odp_3.UseVisualStyleBackColor = true;
            // 
            // check_odp_2
            // 
            this.check_odp_2.AutoSize = true;
            this.check_odp_2.Location = new System.Drawing.Point(46, 185);
            this.check_odp_2.Name = "check_odp_2";
            this.check_odp_2.Size = new System.Drawing.Size(18, 17);
            this.check_odp_2.TabIndex = 3;
            this.check_odp_2.UseVisualStyleBackColor = true;
            // 
            // check_odp_1
            // 
            this.check_odp_1.AutoSize = true;
            this.check_odp_1.Location = new System.Drawing.Point(46, 128);
            this.check_odp_1.Name = "check_odp_1";
            this.check_odp_1.Size = new System.Drawing.Size(18, 17);
            this.check_odp_1.TabIndex = 2;
            this.check_odp_1.UseVisualStyleBackColor = true;
            // 
            // lab_tresc_pytania
            // 
            this.lab_tresc_pytania.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_tresc_pytania.Location = new System.Drawing.Point(84, 21);
            this.lab_tresc_pytania.Name = "lab_tresc_pytania";
            this.lab_tresc_pytania.Size = new System.Drawing.Size(498, 96);
            this.lab_tresc_pytania.TabIndex = 1;
            this.lab_tresc_pytania.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pytanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rozwiązujesz zestaw: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // but_nastepne_pyt
            // 
            this.but_nastepne_pyt.BackColor = System.Drawing.SystemColors.Window;
            this.but_nastepne_pyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_nastepne_pyt.Image = ((System.Drawing.Image)(resources.GetObject("but_nastepne_pyt.Image")));
            this.but_nastepne_pyt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_nastepne_pyt.Location = new System.Drawing.Point(650, 505);
            this.but_nastepne_pyt.Name = "but_nastepne_pyt";
            this.but_nastepne_pyt.Size = new System.Drawing.Size(169, 105);
            this.but_nastepne_pyt.TabIndex = 6;
            this.but_nastepne_pyt.Text = "Następne pytanie";
            this.but_nastepne_pyt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_nastepne_pyt.UseVisualStyleBackColor = false;
            this.but_nastepne_pyt.Visible = false;
            this.but_nastepne_pyt.Click += new System.EventHandler(this.but_nastepne_pyt_Click);
            // 
            // lab_wynik
            // 
            this.lab_wynik.AutoSize = true;
            this.lab_wynik.Location = new System.Drawing.Point(14, 575);
            this.lab_wynik.Name = "lab_wynik";
            this.lab_wynik.Size = new System.Drawing.Size(52, 17);
            this.lab_wynik.TabIndex = 7;
            this.lab_wynik.Text = "label4";
            this.lab_wynik.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(124, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Imie:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(86, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nazwisko:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(107, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grupa:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(80, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nr Indeksu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_imie
            // 
            this.label_imie.AutoSize = true;
            this.label_imie.Location = new System.Drawing.Point(196, 238);
            this.label_imie.Name = "label_imie";
            this.label_imie.Size = new System.Drawing.Size(52, 17);
            this.label_imie.TabIndex = 12;
            this.label_imie.Text = "label8";
            // 
            // label_nazwisko
            // 
            this.label_nazwisko.AutoSize = true;
            this.label_nazwisko.Location = new System.Drawing.Point(196, 270);
            this.label_nazwisko.Name = "label_nazwisko";
            this.label_nazwisko.Size = new System.Drawing.Size(52, 17);
            this.label_nazwisko.TabIndex = 13;
            this.label_nazwisko.Text = "label9";
            // 
            // label_grupa
            // 
            this.label_grupa.AutoSize = true;
            this.label_grupa.Location = new System.Drawing.Point(196, 304);
            this.label_grupa.Name = "label_grupa";
            this.label_grupa.Size = new System.Drawing.Size(61, 17);
            this.label_grupa.TabIndex = 14;
            this.label_grupa.Text = "label10";
            // 
            // label_indeks
            // 
            this.label_indeks.AutoSize = true;
            this.label_indeks.Location = new System.Drawing.Point(196, 337);
            this.label_indeks.Name = "label_indeks";
            this.label_indeks.Size = new System.Drawing.Size(61, 17);
            this.label_indeks.TabIndex = 15;
            this.label_indeks.Text = "label11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_indeks);
            this.Controls.Add(this.label_grupa);
            this.Controls.Add(this.label_nazwisko);
            this.Controls.Add(this.label_imie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_wynik);
            this.Controls.Add(this.but_nastepne_pyt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_pytan);
            this.Controls.Add(this.but_stop_test);
            this.Controls.Add(this.but_start_test);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
            this.Load += new System.EventHandler(this.Test_Load);
            this.panel_pytan.ResumeLayout(false);
            this.panel_pytan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_start_test;
        private System.Windows.Forms.Button but_stop_test;
        private System.Windows.Forms.Panel panel_pytan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_odp_4;
        private System.Windows.Forms.CheckBox check_odp_3;
        private System.Windows.Forms.CheckBox check_odp_2;
        private System.Windows.Forms.CheckBox check_odp_1;
        private System.Windows.Forms.Label lab_tresc_pytania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_odp_5;
        private System.Windows.Forms.Button but_nastepne_pyt;
        private System.Windows.Forms.Label lab_numer_pytania;
        private System.Windows.Forms.Label lab_wynik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_imie;
        private System.Windows.Forms.Label label_nazwisko;
        private System.Windows.Forms.Label label_grupa;
        private System.Windows.Forms.Label label_indeks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}