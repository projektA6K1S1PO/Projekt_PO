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
        public static int numer_pytania=2;

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Test_Load(object sender, EventArgs e)
        {
            label1.Text = baza_pytan_array[0,0];//Pokaż nazwę zestawu
        }



        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Bezwarunkowe zamknięcie aplikacji
            //Należy dodać czy napewno użytkownik chce zamknąć aplikację i stracić wynik testu
        }

        private void start_test_Click_1(object sender, EventArgs e)
        {

            //Tutaj musi następować funkcja losowania)
            panel_pytan.Visible = true;//Pokaż panel pytań
            but_start_test.Visible = false;//Wyłącz przycisk rozpoczęcie testu

            wyswietlaj_pytanie();//Wyświetlaj pierwsze pytanie żeby nie było pustych labelek
        }

        private void wyswietlaj_pytanie()
        {
            lab_tresc_pytania.Text = baza_pytan_array[numer_pytania, 1];//Wyświetl treść pytania
            lab_numer_pytania.Text = Convert.ToString( numer_pytania);//Wyświetl numer pytania z kolei
            check_odp_1.Text= baza_pytan_array[numer_pytania, 2];//Wyświetlaj kolejno treści odpowiedzi
            check_odp_2.Text = baza_pytan_array[numer_pytania, 3];
            check_odp_3.Text = baza_pytan_array[numer_pytania, 4];
            check_odp_4.Text = baza_pytan_array[numer_pytania, 5];
            check_odp_5.Text = baza_pytan_array[numer_pytania, 6];


        }
    }
}
