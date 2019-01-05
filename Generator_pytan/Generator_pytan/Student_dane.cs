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
            int check = 0;
            if ((textBox_imie.Text == "") || (textBox_nazwisko.Text == "") || (textBox_grupa.Text == "") || (textBox_indeks.Text == ""))
            {
                MessageBox.Show("Wypełnij wszytkie pola", "Błąd");
            }
            else
            {
                if (Student_oceny.ilosc_studentow == 0)
                {
                    Student_oceny.listaStudentów.Add(new Student_oceny());

                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Grupa = Convert.ToString(textBox_grupa.Text);//Nadanie Grupy studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Nr_indeksu = Convert.ToString(textBox_indeks.Text);//Nadanie numeru indeksu studentowi
                    Student_oceny.ilosc_studentow++;
                    this.Hide();//Zamknij forme 
                    Test Test = new Test();
                    Test.Show();//Otworz forme test
                }
                else
                {
                    Student_oceny.listaStudentów.Add(new Student_oceny());

                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Grupa = Convert.ToString(textBox_grupa.Text);//Nadanie Grupy studentowi
                    Student_oceny.listaStudentów[Student_oceny.ilosc_studentow].Nr_indeksu = Convert.ToString(textBox_indeks.Text);//Nadanie numeru indeksu studentowi

                    for (int i = 0; i <= Student_oceny.ilosc_studentow-1; i++)
                    {
                        if (Student_oceny.listaStudentów[i].Nr_indeksu == Convert.ToString(textBox_indeks.Text)) check = 1;
                    }

                    if (check==1)
                    {
                        MessageBox.Show("Student o indeksie:" + textBox_indeks.Text + " już rozwiązywał ten test brak możliwości powtórnego podejścia", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Student_oceny.listaStudentów.RemoveRange(Student_oceny.ilosc_studentow, 1);
                    }
                    else
                    {
                        Student_oceny.ilosc_studentow++;

                        this.Hide();//Zamknij forme 
                        Test Test = new Test();
                        Test.Show();//Otworz forme test
                    }
                }


            }
        }
    



        private void Student_dane_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Student_dane_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
