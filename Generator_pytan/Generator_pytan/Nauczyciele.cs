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
                //Tu pozmieniać
                Student_oceny.listaStudentów.Add(new Student_oceny());

                Question.listaPytan.Add(new Question());




                Student_oceny.listaStudentów[0].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia nauczycielowi
                Student_oceny.listaStudentów[0].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska nauczycielowi
                Student_oceny.listaStudentów[0].Grupa = Convert.ToString(textBox_grupa.Text);//Nadanie Grupy nauczycielowi
                Student_oceny.listaStudentów[0].Nr_indeksu = Convert.ToString(textBox_indeks.Text);//Nadanie numeru indeksu nauczycielowi

                this.Hide();//Zamknij forme 
                Test Test = new Test();
                Test.Show();//Otworz forme test


            }

















            result = MessageBox.Show("Dodasz nowego nauczyciela \nJego dane to: " +  + " Punktów \nNa " + Question.maxpkt + " możliwych\nOcena: " + ocena + "\nProcent: " + Student_oceny.procenty, "Koniec Testu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (File.Exists(Panel_nauczyciela.folderZapisu))
                {
                    using (StreamWriter sw = File.AppendText(Panel_nauczyciela.folderZapisu))
                    {

                        sw.WriteLine(Student_oceny.listaStudentów[0].Nazwisko + "  " + Student_oceny.listaStudentów[0].Imie + "  " + Student_oceny.listaStudentów[0].Grupa + "  " + Student_oceny.listaStudentów[0].Nr_indeksu + "   Ocena:" + ocena);
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
