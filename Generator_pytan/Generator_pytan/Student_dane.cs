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
            Student_oceny Student = new Student_oceny();//Stworzenie nowego studenta

            Student.Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia studentowi
            Student.Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska studentowi
            Student.Grupa = Convert.ToInt32(textBox_grupa.Text);//Nadanie Grupy studentowi
            Student.Nr_indeksu = Convert.ToInt32(textBox_indeks.Text);//Nadanie numeru indeksu studentowi
        }
    }
}
