namespace Generator_pytan
{
    partial class Panel_nauczyciela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_nauczyciela));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.niedostatecznyDo = new System.Windows.Forms.TextBox();
            this.dostatecznyDo = new System.Windows.Forms.TextBox();
            this.dobryDo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.widelki = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nazwaPliku = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(31, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "       Wczytaj zestaw pytań";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Plik txt (*.txt)|*.txt|All files (*.*)|*.*|Plik CSV (*.csv)|*.csv";
            this.openFileDialog1.FilterIndex = 3;
            this.openFileDialog1.InitialDirectory = "c:\\\\";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(289, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Przejdz do panelu głównego";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wczytany zestaw pytań:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Widełki ocen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "niedostateczna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "dostateczna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "dobry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "     do";
            // 
            // niedostatecznyDo
            // 
            this.niedostatecznyDo.Location = new System.Drawing.Point(177, 201);
            this.niedostatecznyDo.Name = "niedostatecznyDo";
            this.niedostatecznyDo.Size = new System.Drawing.Size(55, 22);
            this.niedostatecznyDo.TabIndex = 22;
            this.niedostatecznyDo.Text = "40";
            // 
            // dostatecznyDo
            // 
            this.dostatecznyDo.Location = new System.Drawing.Point(177, 231);
            this.dostatecznyDo.Name = "dostatecznyDo";
            this.dostatecznyDo.Size = new System.Drawing.Size(55, 22);
            this.dostatecznyDo.TabIndex = 23;
            this.dostatecznyDo.Text = "60";
            // 
            // dobryDo
            // 
            this.dobryDo.Location = new System.Drawing.Point(177, 257);
            this.dobryDo.Name = "dobryDo";
            this.dobryDo.Size = new System.Drawing.Size(55, 22);
            this.dobryDo.TabIndex = 24;
            this.dobryDo.Text = "80";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(238, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "% ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "% ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(238, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "% ";
            // 
            // widelki
            // 
            this.widelki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widelki.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.widelki.Location = new System.Drawing.Point(289, 203);
            this.widelki.Name = "widelki";
            this.widelki.Size = new System.Drawing.Size(115, 78);
            this.widelki.TabIndex = 30;
            this.widelki.Text = "Zapisz progi procentowe";
            this.widelki.UseVisualStyleBackColor = true;
            this.widelki.Click += new System.EventHandler(this.widelki_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nazwa piku z wynikami:";
            // 
            // nazwaPliku
            // 
            this.nazwaPliku.Location = new System.Drawing.Point(169, 131);
            this.nazwaPliku.Name = "nazwaPliku";
            this.nazwaPliku.Size = new System.Drawing.Size(187, 22);
            this.nazwaPliku.TabIndex = 34;
            this.nazwaPliku.Text = "wyniki";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(371, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 33);
            this.button4.TabIndex = 37;
            this.button4.Text = "Wybierz miejsce zapisania pliku";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Panel_nauczyciela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 317);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nazwaPliku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.widelki);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dobryDo);
            this.Controls.Add(this.dostatecznyDo);
            this.Controls.Add(this.niedostatecznyDo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Panel_nauczyciela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Nauczyciela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_nauczyciela_FormClosing);
            this.Load += new System.EventHandler(this.Panel_adminstratora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox niedostatecznyDo;
        private System.Windows.Forms.TextBox dostatecznyDo;
        private System.Windows.Forms.TextBox dobryDo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button widelki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nazwaPliku;
        private System.Windows.Forms.Button button4;
    }
}