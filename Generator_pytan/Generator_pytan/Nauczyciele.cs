using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Generator_pytan
{
    public partial class Nauczyciele : Form
    {
        public Nauczyciele()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox_imie.Text == "") || (textBox_nazwisko.Text == "") || (textBox_stopien.Text == "") || (textBox_przedmiot.Text == "") || (textBox_login.Text == "") || (textBox_haslo.Text == ""))
            {
                MessageBox.Show("Wypełnij wszytkie pola", "Błąd");
            }
            else
            {
                
                Nauczyciele_dane.listaNauczycieli.Add(new Nauczyciele_dane());

                //Question.listaPytan.Add(new Question());




                Nauczyciele_dane.listaNauczycieli[0].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Stopien = Convert.ToString(textBox_stopien.Text);//Nadanie stopnia nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Przedmiot = Convert.ToString(textBox_przedmiot.Text);//Nadanie numeru indeksu nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Login = Convert.ToString(textBox_login.Text);//Nadanie loginu nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Haslo = Convert.ToString(textBox_haslo.Text);//Nadanie hasla nauczycielowi
                this.Hide();//Zamknij forme 
                

            }


            DialogResult nauczyciel;
            string zawartosc = "Dodasz nowego nauczyciela \nJego dane to:\n" + Nauczyciele_dane.listaNauczycieli[0].Stopien + Nauczyciele_dane.listaNauczycieli[0].Imie + " " + Nauczyciele_dane.listaNauczycieli[0].Nazwisko + " \nProwadźący przedmiot: " + Nauczyciele_dane.listaNauczycieli[0].Przedmiot + "\nLogin: " + Nauczyciele_dane.listaNauczycieli[0].Login + "\nHasło: " + Nauczyciele_dane.listaNauczycieli[0].Haslo;
            

            nauczyciel = MessageBox.Show( zawartosc ,"Zapisz",MessageBoxButtons.OK, MessageBoxIcon.Information);

            //tworzenie nowego pliku z nauczycielami
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "newFolder"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "newFolder");
            }
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "newFolder\\wyniki.csv";

            if (nauczyciel == DialogResult.OK)
            {
                if (File.Exists(Nauczyciele_dane.nazwa_pliku_nauczyciele))
                {
                    using (StreamWriter sw = File.AppendText(Panel_nauczyciela.folderZapisu))
                    {

                        sw.WriteLine(Nauczyciele_dane.listaNauczycieli[0].Stopien + "  " + Nauczyciele_dane.listaNauczycieli[0].Imie + "  " + Nauczyciele_dane.listaNauczycieli[0].Nazwisko + "  " + Nauczyciele_dane.listaNauczycieli[0].Przedmiot + "  " + Nauczyciele_dane.listaNauczycieli[0].Login + " " + Nauczyciele_dane.listaNauczycieli[0].Haslo);
                        sw.Close();
                    }
                }


            }
        }

        private void imie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
