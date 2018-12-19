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

        public static int numer_pytania=0;//Zmienna lokalna,testowa numer aktualnie 
        //wyświetlanego pytania (numer bezwzględny nawet przy losowych pytaniach
        public static int wynik = 0;//Zmienna przechowująca wynik testu
        
        

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Test_Load(object sender, EventArgs e)
        {
            label1.Text = Question.baza_pytan_array[0,0];//Pokaż nazwę zestawu
            generuj_obiekty_pytan();//Generuj obiekty klasy Question
            napelnij_danymi_obiekty();//Napełnij danymi obiekty
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
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            wyswietlaj_pytanie();//Wyświetlaj pierwsze pytanie żeby nie było pustych labelek
        }

        private void wyswietlaj_pytanie()
        {
            //Obsługa kontrolek okienka test
            lab_tresc_pytania.Text =    Question.listaPytan[numer_pytania].tresc;//Wyświetl treść pytania
            lab_numer_pytania.Text =    Convert.ToString(numer_pytania+1);//Wyświetl numer pytania z kolei
            check_odp_1.Text=           Question.listaPytan[numer_pytania].odp_1;//Wyświetlaj kolejno treści odpowiedzi
            check_odp_2.Text =          Question.listaPytan[numer_pytania].odp_2;
            check_odp_3.Text =          Question.listaPytan[numer_pytania].odp_3;
            check_odp_4.Text =          Question.listaPytan[numer_pytania].odp_4;
            check_odp_5.Text =          Question.listaPytan[numer_pytania].odp_5;
            lab_wynik.Text = Convert.ToString(wynik);//Pokaż wynik dla testu (ukryte na form)
            
        }

        //Funkcja generująca obiekty klasy Question
        private void generuj_obiekty_pytan()
        {
            for (int i = 0; i < Convert.ToInt16(Question.baza_pytan_array[0, 2]); i++)
            {
                Question.listaPytan.Add(new Question());

            }
        }
        //Funkcja napełniająca obiekty Question danymi z tablicy bazy pytań
        private void napelnij_danymi_obiekty()
        {
            for (int numer_pytania = 0; numer_pytania < Convert.ToInt16(Question.baza_pytan_array[0, 2]); numer_pytania++)
            {
                Question.listaPytan[numer_pytania].tresc = Question.baza_pytan_array[numer_pytania+2, 1];
                Question.listaPytan[numer_pytania].odp_1 = Question.baza_pytan_array[numer_pytania+2, 3];
                Question.listaPytan[numer_pytania].odp_2 = Question.baza_pytan_array[numer_pytania+2, 4];
                Question.listaPytan[numer_pytania].odp_3 = Question.baza_pytan_array[numer_pytania+2, 5];
                Question.listaPytan[numer_pytania].odp_4 = Question.baza_pytan_array[numer_pytania+2, 6];
                Question.listaPytan[numer_pytania].odp_5 = Question.baza_pytan_array[numer_pytania+2, 7];
                Question.listaPytan[numer_pytania].odp_1_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania+2, 8]);
                Question.listaPytan[numer_pytania].odp_2_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania+2, 9]);
                Question.listaPytan[numer_pytania].odp_3_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania+2, 10]);
                Question.listaPytan[numer_pytania].odp_4_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania+2, 11]);
                Question.listaPytan[numer_pytania].odp_5_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania+2, 12]);
                //Obsługa kolejnych elementów 
            }

        }

        private void but_nastepne_pyt_Click(object sender, EventArgs e)
        {
            sprawdz_odp();//Sprawdz poprawność odp dodaj punkty do wyniku
            zeruj_odp();//Zeruj zaznaczenia checkboxów
            numer_pytania++;//Przejdz do następnego pytania
            if (numer_pytania > (Convert.ToInt16(Question.baza_pytan_array[0, 2]))-1)//Jeżeli koniec testu
            {
                MessageBox.Show("Koniec Testu \nTwój wynik to:"+wynik+" Punktów");
            }
            else
            {
                wyswietlaj_pytanie();
            }
            
            
        }

        //Funkcja sprawdzająca odp na pytania
        private void sprawdz_odp()
        {
            if (check_odp_1.Checked)
            {
                wynik += Question.listaPytan[numer_pytania].odp_1_poprawna;
            }
            if (check_odp_2.Checked)
            {
                wynik += Question.listaPytan[numer_pytania].odp_2_poprawna;
            }
            if (check_odp_3.Checked)
            {
                wynik += Question.listaPytan[numer_pytania].odp_3_poprawna;
            }
            if (check_odp_4.Checked)
            {
                wynik += Question.listaPytan[numer_pytania].odp_4_poprawna;
            }
            if (check_odp_5.Checked)
            {
                wynik += Question.listaPytan[numer_pytania].odp_5_poprawna;
            }

        }
        //Funkcja zerująca zaznaczenia chceckboxów
        private void zeruj_odp()
        {
            check_odp_1.Checked = false;
            check_odp_2.Checked = false;
            check_odp_3.Checked = false;
            check_odp_4.Checked = false;
            check_odp_5.Checked = false;

        }

        private void but_stop_test_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Czy napewno chcesz zakończyć test i opuścić aplikację", "UWAGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void lab_wynik_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
