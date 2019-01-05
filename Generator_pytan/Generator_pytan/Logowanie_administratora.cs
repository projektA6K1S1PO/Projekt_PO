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
    public partial class Logowanie_administratora : Form
    {
        public Logowanie_administratora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_box.Text == Properties.Settings.Default.Login && haslo_box.Text == Properties.Settings.Default.Haslo)//Sprawdzenie hasla i loginu
            {
                this.Hide();//Zamknij forme Logowanie
                Nauczyciele Nauczyciele = new Nauczyciele();
                Nauczyciele.Show();//Otworz panel dodawania nauczycieli
            }
            else
            {
                MessageBox.Show("Zły login lub hasło", "Błędne dane logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);//MsgBox zle dane logowania
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Powróc do panelu głównego
            Panel_wyboru Panel_wyboru = new Panel_wyboru();
            Panel_wyboru.Show();//Otwórz panel wyboru
        }


        private void LogAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Bezwarunkowe zamknięcie aplikacji
        }

        private void Logowanie_administratora_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
  