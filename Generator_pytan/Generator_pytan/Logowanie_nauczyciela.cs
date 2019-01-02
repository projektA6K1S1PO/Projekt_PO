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
    public partial class Logowanie_nauczyciela : Form
    {
        public Logowanie_nauczyciela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int poprawny_login = 0;//Zmienna 0/1 zły/poprawny login
            Nauczyciele_dane.baza_nauczycieli_array = LoadCsv(Nauczyciele_dane.fileName); // Pobierz danę z pliku do tablicy

            for (int i = 0; i < LoadCsvLines(Nauczyciele_dane.fileName); i++)//Sprawdz wszystkich nauczycieli
            {
                if (login_box.Text == Nauczyciele_dane.baza_nauczycieli_array[i,4] && haslo_box.Text == Nauczyciele_dane.baza_nauczycieli_array[i, 5])//Sprawdzenie hasla i loginu
                {
                    poprawny_login = 1;
                }
            }
            if (poprawny_login == 1)//Sprawdzenie hasla i loginu
            {
                this.Hide();//Zamknij forme Logowanie
                Panel_nauczyciela Panel_nauczyciela = new Panel_nauczyciela();
                Panel_nauczyciela.Show();//Otworz panel administratora
            }
            else
            {
                MessageBox.Show("Zły login lub hasło", "Błędne dane logowania",MessageBoxButtons.OK,MessageBoxIcon.Warning);//MsgBox zle dane logowania
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Powróc do panelu głównego
            Panel_wyboru Panel_wyboru = new Panel_wyboru();
            Panel_wyboru.Show();//Otwórz panel wyboru
        }

        private void Logowanie_nauczyciela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Bezwarunkowe zamknięcie aplikacji
        }

        private string[,] LoadCsv(string filename)
        {
            // Wyłuskaj cały tekst z pliku
            string whole_file = File.ReadAllText(filename);

            // Podziel na linię
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Zbadaj ile kolumn oraz wierszy jest w pliku
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(';').Length;

            // Utwórz nową tablicę o wymaganych wymiarach
            string[,] values = new string[num_rows, num_cols];

            // Załaduj danymi
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < num_cols; c++)
                {
                    values[r, c] = line_r[c];
                }
            }

            // Zwróc tablicę w wyniku
            return values;
        }

        private int LoadCsvLines(string filename)
        {
            // Wyłuskaj cały tekst z pliku
            string whole_file = File.ReadAllText(filename);

            // Podziel na linię
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Zbadaj ile kolumn oraz wierszy jest w pliku
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(';').Length;

            
            return num_rows;
        }
    }
}
