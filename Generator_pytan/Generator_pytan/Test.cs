using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Generator_pytan
{
    public partial class Test : Form
    {

        public static int numer_pytania = 0;//Zmienna lokalna,testowa numer aktualnie 
        //wyświetlanego pytania (numer bezwzględny nawet przy losowych pytaniach
        public static int wynik = 0;//Zmienna przechowująca wynik testu



        public Test()
        {
            InitializeComponent();
        }


        private void Test_Load(object sender, EventArgs e)
        {
            Question.maxpkt = 0;
            losowanie();//Tutaj musi następować funkcja losowania
            label1.Text = Question.baza_pytan_array[0, 0];//Pokaż nazwę zestawu
            label_imie.Text = Student_oceny.listaStudentów[Student_oceny.ilosc_studentow-1].Imie;//Pokaż dane studenta
            label_nazwisko.Text = Student_oceny.listaStudentów[Student_oceny.ilosc_studentow-1].Nazwisko;//Pokaż dane studenta
            label_grupa.Text = Student_oceny.listaStudentów[Student_oceny.ilosc_studentow-1].Grupa;//Pokaż dane studenta
            label_indeks.Text = Student_oceny.listaStudentów[Student_oceny.ilosc_studentow-1].Nr_indeksu;//Pokaż dane studenta
            generuj_obiekty_pytan();//Generuj obiekty klasy Question
            napelnij_danymi_obiekty();//Napełnij danymi obiekty
        }



        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();

        }

        private void start_test_Click_1(object sender, EventArgs e)
        {

            
            numer_pytania = 0;
            panel_pytan.Visible = true;//Pokaż panel pytań
            but_start_test.Visible = false;//Wyłącz przycisk rozpoczęcie testu
            but_nastepne_pyt.Visible = true;
            wyswietlaj_pytanie();//Wyświetlaj pierwsze pytanie żeby nie było pustych labelek
        }

        private void wyswietlaj_pytanie()
        {
            //Obsługa kontrolek okienka test

            lab_tresc_pytania.Text = Question.listaPytan[numer_pytania].tresc;//Wyświetl treść pytania
            lab_numer_pytania.Text = Convert.ToString(numer_pytania + 1);//Wyświetl numer pytania z kolei
            check_odp_1.Text = Question.listaPytan[numer_pytania].odp_1;//Wyświetlaj kolejno treści odpowiedzi
            check_odp_2.Text = Question.listaPytan[numer_pytania].odp_2;
            check_odp_3.Text = Question.listaPytan[numer_pytania].odp_3;
            check_odp_4.Text = Question.listaPytan[numer_pytania].odp_4;
            check_odp_5.Text = Question.listaPytan[numer_pytania].odp_5;
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
                Question.listaPytan[Question.losowanie[numer_pytania]].tresc = Question.baza_pytan_array[numer_pytania + 2, 1];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_1 = Question.baza_pytan_array[numer_pytania + 2, 3];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_2 = Question.baza_pytan_array[numer_pytania + 2, 4];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_3 = Question.baza_pytan_array[numer_pytania + 2, 5];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_4 = Question.baza_pytan_array[numer_pytania + 2, 6];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_5 = Question.baza_pytan_array[numer_pytania + 2, 7];
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_1_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania + 2, 8]);
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_2_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania + 2, 9]);
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_3_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania + 2, 10]);
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_4_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania + 2, 11]);
                Question.listaPytan[Question.losowanie[numer_pytania]].odp_5_poprawna = Convert.ToInt16(Question.baza_pytan_array[numer_pytania + 2, 12]);
                //Obsługa kolejnych elementów 
            }

        }

        private void losowanie()
        {
            
            int check = 0;
            Question.losowanie = new int[50];

            for (int i = 0; i < Question.losowanie.Length; i++)
            {
                Question.losowanie[i] = 0;
            }

            Random rnd = new Random();
            int temp = 0;

            for (int i = 0; i < Convert.ToInt16(Question.baza_pytan_array[0, 2]); i++)
            {
                do
                {
                    temp = rnd.Next(1, Convert.ToInt16(Question.baza_pytan_array[0, 2])+2) -1;
                    check = 0;
                    for (int b = 0; b < Convert.ToInt16(Question.baza_pytan_array[0, 2]); b++)
                    {
                        if (Question.losowanie[b] == temp)
                        {
                            check = 1;
                            break;
                        }
                    }
                } while (check == 1);
                Question.losowanie[i] = temp;
            }

            for (int i = 0; i < Convert.ToInt16(Question.baza_pytan_array[0, 2]); i++)
            {
                Question.losowanie[i] = Question.losowanie[i]-1;
            }
        }
        private void but_nastepne_pyt_Click(object sender, EventArgs e)
        {

            sprawdz_odp();//Sprawdz poprawność odp dodaj punkty do wyniku
            zeruj_odp();//Zeruj zaznaczenia checkboxów
            numer_pytania++;//Przejdz do następnego pytania
            if ((numer_pytania > (Convert.ToInt16(Question.baza_pytan_array[0, 2])) - 2))
            {
                but_nastepne_pyt.Visible = true;
                but_stop_test.Visible = false;
            }
            if (numer_pytania > (Convert.ToInt16(Question.baza_pytan_array[0, 2])) - 1)//Jeżeli koniec testu
            {
                but_nastepne_pyt.Visible = false;
                panel_pytan.Visible = false;

                //Obliczenie max ilości punktów z zestawu
                for (int i = 0; i < (Convert.ToInt16(Question.baza_pytan_array[0, 2])); i++)
                {
                    for (int b = 0; b < 5; b++)//5 odp w zestawie
                    {
                        if(Convert.ToDouble(Question.baza_pytan_array[i + 2, b + 8]) > 0)
                        {
                            Question.maxpkt = Question.maxpkt + Convert.ToDouble(Question.baza_pytan_array[i + 2, b + 8]);
                        }
                        
                    }
                }
                //MessageBox.Show(Convert.ToString(Question.maxpkt));
                    Student_oceny.procenty = (double)(wynik / Question.maxpkt) * 100;
                string ocena = "0";

                if (Student_oceny.procenty < Student_oceny.ndstDo)
                {
                    ocena = "2";
                }
                else if (Student_oceny.procenty >= Student_oceny.ndstDo && Student_oceny.procenty < Student_oceny.dstDo)
                {
                    ocena = "3";
                }
                else if (Student_oceny.procenty >= Student_oceny.dstDo && Student_oceny.procenty < Student_oceny.dbDo)
                {
                    ocena = "4";
                }
                else if (Student_oceny.procenty >= Student_oceny.dbDo)
                {
                    ocena = "5";
                }
                if(Student_oceny.procenty<= Student_oceny.ndstDo)
                {
                    Student_oceny.procenty = 0;
                }

                DialogResult result;

                result = MessageBox.Show("Koniec Testu \nTwój wynik to: " + wynik + " Punktów \nNa " + Question.maxpkt + " możliwych\nOcena: " + ocena + "\nProcent: " + Student_oceny.procenty,"Koniec Testu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    if (File.Exists(Panel_nauczyciela.folderZapisu))
                    {
                        using (StreamWriter sw = File.AppendText(Panel_nauczyciela.folderZapisu))
                        {

                            sw.WriteLine(Student_oceny.listaStudentów[Student_oceny.ilosc_studentow - 1].Nazwisko 
                                + "  " + Student_oceny.listaStudentów[Student_oceny.ilosc_studentow - 1].Imie + "  " 
                                + Student_oceny.listaStudentów[Student_oceny.ilosc_studentow - 1].Grupa + "  " 
                                + Student_oceny.listaStudentów[Student_oceny.ilosc_studentow - 1].Nr_indeksu 
                                + "   Ocena:" + ocena);
                            sw.Close();
                        }
                    }

                    this.Hide();//Zamknij forme 

                    Panel_wyboru Panel_wyboru = new Panel_wyboru();
                    Panel_wyboru.Show();//Otworz forme test

                    //Application.Exit();
                    //this.Close();
                }


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

            result = MessageBox.Show("Czy napewno chcesz zakończyć test bez zapisu wyniku i opuścić aplikację", "UWAGA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel_pytan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}