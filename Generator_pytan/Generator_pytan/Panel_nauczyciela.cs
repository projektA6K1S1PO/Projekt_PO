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
    public partial class Panel_nauczyciela : Form
    {

        public static string filePath = null;//Zmienna przechowująca sciezke do pliku z pytaniami

        public Panel_nauczyciela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)//Prawidlowo otwarty plik
            {
                filePath = openFileDialog1.FileName;//Wyłuskanie sciezki do pliku z pytaniami
                Question.baza_pytan_array = LoadCsv(filePath); // Pobierz danę z pliku do tablicy
                label2.Text = Question.baza_pytan_array[0, 0];//Wyświetl nazwę zestawu dla użytkownika
            }

           
            
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Powróc do panelu głównego
            Panel_wyboru Panel_wyboru = new Panel_wyboru();
            Panel_wyboru.Show();//Otwórz panel wyboru
        }


        // Załaduj plik CSV do tablicy

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

        private void Panel_adminstratora_Load(object sender, EventArgs e)
        {

        }

        private void widelki_Click(object sender, EventArgs e)
        {
            // niby wszystko ok ale tu wartosci poprawne a po przeniesieniu do Testu wynosza 0 :( 
            
                int ndstDo = Convert.ToInt16(niedostatecznyDo.Text);
                int dstDo = Convert.ToInt16(dostatecznyDo.Text);
                int dbDo = Convert.ToInt16(dobryDo.Text);
            MessageBox.Show(ndstDo + "\n" + dstDo + "\n" + dbDo);

        }

            public static int ndstDo = ndstDo;
            public static int dstDo = dstDo;
            public static int dbDo = dbDo;

    }

}

