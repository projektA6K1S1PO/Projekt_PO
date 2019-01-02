namespace Generator_pytan
{
    partial class Logowanie_administratora
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
            this.button1 = new System.Windows.Forms.Button();
            this.login_box = new System.Windows.Forms.TextBox();
            this.haslo_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(153, 23);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(127, 22);
            this.login_box.TabIndex = 1;
            // 
            // haslo_box
            // 
            this.haslo_box.Location = new System.Drawing.Point(153, 67);
            this.haslo_box.Name = "haslo_box";
            this.haslo_box.PasswordChar = '*';
            this.haslo_box.Size = new System.Drawing.Size(127, 22);
            this.haslo_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // button_powrot
            // 
            this.button_powrot.Location = new System.Drawing.Point(69, 109);
            this.button_powrot.Name = "button_powrot";
            this.button_powrot.Size = new System.Drawing.Size(93, 36);
            this.button_powrot.TabIndex = 5;
            this.button_powrot.Text = "Powrót";
            this.button_powrot.UseVisualStyleBackColor = true;
            this.button_powrot.Click += new System.EventHandler(this.button2_Click);
            // 
            // Logowanie_administratora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 168);
            this.Controls.Add(this.button_powrot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haslo_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Logowanie_administratora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogAdmin_FormClosing);
            this.Load += new System.EventHandler(this.LogAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox haslo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_powrot;
    }
}