﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Generator_pytan
{
    public partial class Panel_adminstratora : Form
    {

        
        public static string filePath = null;//Zmienna przechowująca sciezke do pliku z pytaniami


        public Panel_adminstratora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     
            if(openFileDialog1.ShowDialog()==DialogResult.OK)//Prawidlowo otwarty plik
            {
                filePath = openFileDialog1.FileName;//Wyłuskanie sciezki do pliku z pytaniami
          
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_wyboru Panel_wyboru = new Panel_wyboru();
            Panel_wyboru.Show();
        }
    }
}
