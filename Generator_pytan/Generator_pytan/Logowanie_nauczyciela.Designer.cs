﻿namespace Generator_pytan
{
    partial class Logowanie_nauczyciela
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.haslo_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(139, 20);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(145, 22);
            this.login_box.TabIndex = 2;
            this.login_box.TextChanged += new System.EventHandler(this.login_box_TextChanged);
            // 
            // haslo_box
            // 
            this.haslo_box.Location = new System.Drawing.Point(139, 67);
            this.haslo_box.Name = "haslo_box";
            this.haslo_box.PasswordChar = '*';
            this.haslo_box.Size = new System.Drawing.Size(145, 22);
            this.haslo_box.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Powrót ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Logowanie_nauczyciela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 152);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.haslo_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Logowanie_nauczyciela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie nauczyciela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logowanie_nauczyciela_FormClosing);
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox haslo_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}