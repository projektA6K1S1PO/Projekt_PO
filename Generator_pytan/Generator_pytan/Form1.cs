using System;
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
    public partial class Panel_wyboru : Form
    {

     

       
        public Panel_wyboru()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Panel_adminstratora.filePath == null))
            {
                this.Hide();
                Test Test = new Test();
                Test.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie Logowanie = new Logowanie();
            Logowanie.Show();
            
        }
    }
}
