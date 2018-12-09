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
        public static int numer_pytania=0;
        

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
            generuj_obiekty_pytan();
            napelnij_danymi_obiekty();
        }



        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Bezwarunkowe zamknięcie aplikacji
            //Należy dodać czy napewno użytkownik chce zamknąć aplikację i stracić wynik testu
        }

        private void start_test_Click_1(object sender, EventArgs e)
        {

            //losowanie();//Tutaj musi następować funkcja losowania
            panel_pytan.Visible = true;//Pokaż panel pytań
            but_start_test.Visible = false;//Wyłącz przycisk rozpoczęcie testu

            wyswietlaj_pytanie();//Wyświetlaj pierwsze pytanie żeby nie było pustych labelek
        }

        private void wyswietlaj_pytanie()
        {
            lab_tresc_pytania.Text =    Question.listaPytan[numer_pytania].tresc;//Wyświetl treść pytania
            lab_numer_pytania.Text =    Convert.ToString( numer_pytania);//Wyświetl numer pytania z kolei
            check_odp_1.Text=           Question.listaPytan[numer_pytania].odp_1;//Wyświetlaj kolejno treści odpowiedzi
            check_odp_2.Text =          Question.listaPytan[numer_pytania].odp_2;
            check_odp_3.Text =          Question.listaPytan[numer_pytania].odp_3;
            check_odp_4.Text =          Question.listaPytan[numer_pytania].odp_4;
            check_odp_5.Text =          Question.listaPytan[numer_pytania].odp_5;
        }

        private void generuj_obiekty_pytan()
        {

            for (int i = 0; i < Convert.ToInt16(baza_pytan_array[0, 2]); i++)
            {
                Question.listaPytan.Add(new Question());

            }
        }

        private void napelnij_danymi_obiekty()
        {

            for (int numer_pytania = 0; numer_pytania < Convert.ToInt16(baza_pytan_array[0, 2]); numer_pytania++)
            {
                Question.listaPytan[numer_pytania].tresc = baza_pytan_array[numer_pytania, 1];
                Question.listaPytan[numer_pytania].odp_1 = baza_pytan_array[numer_pytania, 3];
                Question.listaPytan[numer_pytania].odp_2 = baza_pytan_array[numer_pytania, 4];
                Question.listaPytan[numer_pytania].odp_3 = baza_pytan_array[numer_pytania, 5];
                Question.listaPytan[numer_pytania].odp_4 = baza_pytan_array[numer_pytania, 6];
                Question.listaPytan[numer_pytania].odp_5 = baza_pytan_array[numer_pytania, 7];

            }




        }

        private void but_nastepne_pyt_Click(object sender, EventArgs e)
        {
            numer_pytania++;
            wyswietlaj_pytanie();
        }
    }
}
