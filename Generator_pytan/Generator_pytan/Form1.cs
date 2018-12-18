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
            if (!(Panel_adminstratora.filePath == null))//Jesli brak sciezki do pliku z pyt to nie pozwol na rozpoczecie testu
            {
                this.Hide();//Zamknij forme wybor
                Test Test = new Test();
                Test.Show();//Otworz forme test
            }
            else
            {

                MessageBox.Show("Administrator nie wczytał zestawu pytań", "Błąd Pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Zamknij forme wybor
            Logowanie Logowanie = new Logowanie();
            Logowanie.Show();//Otworz forme logowanie
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
