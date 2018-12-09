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
    public partial class Test : Form
    {

        public static string[,] baza_pytan_array;

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //label1.Text = baza_pytan_array[0,0];//Szybkie wyswietlenie sciezki do pliku
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
