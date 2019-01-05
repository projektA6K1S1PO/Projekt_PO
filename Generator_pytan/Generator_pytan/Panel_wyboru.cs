using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_pytan
{
    public partial class Panel_wyboru : Form
    {

        public Panel_wyboru()
        {

            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();

            InitializeComponent();
            //Ładowanie danych
            string str = string.Empty;
            for (int i = 0; i < 70000; i++)
            {
                str += i.ToString();
            }
            //Complete
            t.Abort();

        }

        void Splash()
        {
            splasch frm = new splasch();
            Application.Run(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ( (!(Panel_nauczyciela.filePath == null)) && (!(Panel_nauczyciela.folderZapisu == null)))//Jesli brak sciezki do pliku z pyt to nie pozwol na rozpoczecie testu
            {
                this.Hide();//Zamknij forme wybor
                Student_dane Student_dane = new Student_dane();
                Student_dane.Show();//Otworz forme test
            }
            else
            {

                MessageBox.Show("Administrator nie wczytał zestawu pytań i/lub ścieżki do zapisu wyników", "Błąd Pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//Zamknij forme wybor
            Logowanie_nauczyciela Logowanie = new Logowanie_nauczyciela();
            Logowanie.Show();//Otworz forme logowanie
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();//Zamknij forme wybor
            Logowanie_administratora LogAdmin = new Logowanie_administratora();
            LogAdmin.Show();//Otworz forme logowanie

        }

        private void Panel_wyboru_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Bezwarunkowe zamknięcie aplikacji
        }
    }
    
}
