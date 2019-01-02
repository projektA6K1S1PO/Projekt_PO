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
    public partial class Student_dane : Form
    {
        public Student_dane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if((textBox_imie.Text=="") || (textBox_nazwisko.Text=="" )|| (textBox_grupa.Text=="" )|| (textBox_indeks.Text == ""))
            {
                MessageBox.Show("Wypełnij wszytkie pola", "Błąd");
            }
            else
            {
                Student_oceny.listaStudentów.Add(new Student_oceny());

                Question.listaPytan.Add(new Question());

                Student_oceny.listaStudentów[0].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia studentowi
                Student_oceny.listaStudentów[0].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska studentowi
                Student_oceny.listaStudentów[0].Grupa = Convert.ToString(textBox_grupa.Text);//Nadanie Grupy studentowi
                Student_oceny.listaStudentów[0].Nr_indeksu = Convert.ToString(textBox_indeks.Text);//Nadanie numeru indeksu studentowi

                this.Hide();//Zamknij forme 
                Test Test = new Test();
                Test.Show();//Otworz forme test

            }
        }


        private void Student_dane_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
