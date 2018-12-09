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
    public partial class Panel_adminstratora : Form
    {

        
        public static string filePath = null;//Zmienna przechowująca sciezke do pliku z pytaniami



        public Panel_adminstratora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     
            if(openFileDialog1.ShowDialog()==DialogResult.OK)//Prawidlowo otwarty plik
            {
                filePath = openFileDialog1.FileName;//Wyłuskanie sciezki do pliku z pytaniami
          
            }

            // Get the data.
            string[,] values = LoadCsv(filePath);
            int num_rows = values.GetUpperBound(0) + 1;
            int num_cols = values.GetUpperBound(1) + 1;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_wyboru Panel_wyboru = new Panel_wyboru();
            Panel_wyboru.Show();
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
    }
}
