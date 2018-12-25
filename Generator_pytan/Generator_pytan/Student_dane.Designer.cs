namespace Generator_pytan
{
    partial class Student_dane
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_indeks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_grupa = new System.Windows.Forms.TextBox();
            this.button_nowy_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imie";
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(142, 58);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(95, 22);
            this.textBox_nazwisko.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numer Indeksu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupa";
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(142, 26);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(95, 22);
            this.textBox_imie.TabIndex = 13;
            // 
            // textBox_indeks
            // 
            this.textBox_indeks.Location = new System.Drawing.Point(142, 86);
            this.textBox_indeks.Name = "textBox_indeks";
            this.textBox_indeks.Size = new System.Drawing.Size(95, 22);
            this.textBox_indeks.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nazwisko";
            // 
            // textBox_grupa
            // 
            this.textBox_grupa.Location = new System.Drawing.Point(142, 114);
            this.textBox_grupa.Name = "textBox_grupa";
            this.textBox_grupa.Size = new System.Drawing.Size(95, 22);
            this.textBox_grupa.TabIndex = 16;
            // 
            // button_nowy_student
            // 
            this.button_nowy_student.Location = new System.Drawing.Point(44, 153);
            this.button_nowy_student.Name = "button_nowy_student";
            this.button_nowy_student.Size = new System.Drawing.Size(193, 46);
            this.button_nowy_student.TabIndex = 17;
            this.button_nowy_student.Text = "Zapisz i przejdz do testu";
            this.button_nowy_student.UseVisualStyleBackColor = true;
            this.button_nowy_student.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_dane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 206);
            this.Controls.Add(this.button_nowy_student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_grupa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.textBox_indeks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Student_dane";
            this.Text = "Student dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_indeks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_grupa;
        private System.Windows.Forms.Button button_nowy_student;
    }
}