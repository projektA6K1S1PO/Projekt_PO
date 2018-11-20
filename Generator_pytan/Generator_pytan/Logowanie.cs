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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_box.Text == Properties.Settings.Default.Login &&  haslo_box.Text == Properties.Settings.Default.Haslo)//Sprawdzenie hasla i loginu
            {
                this.Hide();//Zamknij forme Logowanie
                Panel_adminstratora Panel_adminstratora = new Panel_adminstratora();
                Panel_adminstratora.Show();//Otworz panel administratora
            }
            else
            {
                MessageBox.Show("Zły login lub hasło", "Błędne dane logowania",MessageBoxButtons.OK,MessageBoxIcon.Warning);//MsgBox zle dane logowania
            }
          
        }
    }
}
