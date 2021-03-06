﻿using System;
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
    public partial class Nauczyciele : Form
    {
        public Nauczyciele()
        {
            InitializeComponent();

            //tworzenie nowego pliku z nauczycielami (jeśli go nie ma wraz ze ścieżką)
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "newFolder"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "newFolder");
            }
            if (!(File.Exists(Nauczyciele_dane.fileName)))
            {
                File.Create(Nauczyciele_dane.fileName).Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox_imie.Text == "") || (textBox_nazwisko.Text == "") || (textBox_stopien.Text == "") || (textBox_przedmiot.Text == "") || (textBox_login.Text == "") || (textBox_haslo.Text == ""))
            {
                MessageBox.Show("Wypełnij wszytkie pola", "Błąd");
            }
            else
            {
                Nauczyciele_dane.listaNauczycieli.Add(new Nauczyciele_dane());
                Nauczyciele_dane.listaNauczycieli[0].Imie = Convert.ToString(textBox_imie.Text);//Nadanie imienia nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Nazwisko = Convert.ToString(textBox_nazwisko.Text);//Nadanie nazwiska nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Stopien = Convert.ToString(textBox_stopien.Text);//Nadanie stopnia nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Przedmiot = Convert.ToString(textBox_przedmiot.Text);//Nadanie numeru indeksu nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Login = Convert.ToString(textBox_login.Text);//Nadanie loginu nauczycielowi
                Nauczyciele_dane.listaNauczycieli[0].Haslo = Convert.ToString(textBox_haslo.Text);//Nadanie hasla nauczycielowi


                DialogResult nauczyciel;
                string zawartosc = "Dodasz nowego nauczyciela \nJego dane to:\n" + 
                    Nauczyciele_dane.listaNauczycieli[0].Stopien + 
                    Nauczyciele_dane.listaNauczycieli[0].Imie + " " + 
                    Nauczyciele_dane.listaNauczycieli[0].Nazwisko + 
                    " \nProwadźący przedmiot: " +Nauczyciele_dane.listaNauczycieli[0].Przedmiot + 
                    "\nLogin: " + Nauczyciele_dane.listaNauczycieli[0].Login + 
                    "\nHasło: " + Nauczyciele_dane.listaNauczycieli[0].Haslo;

                nauczyciel = MessageBox.Show(zawartosc, "Zapisz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (nauczyciel == DialogResult.OK)
                {
                    if (File.Exists(Nauczyciele_dane.fileName))
                    {
                        using (StreamWriter sw = File.AppendText(Nauczyciele_dane.fileName))
                        {
                            sw.WriteLine(Nauczyciele_dane.listaNauczycieli[0].Stopien + ";" 
                                + Nauczyciele_dane.listaNauczycieli[0].Imie + ";" 
                                + Nauczyciele_dane.listaNauczycieli[0].Nazwisko + ";" 
                                + Nauczyciele_dane.listaNauczycieli[0].Przedmiot + ";" 
                                + Nauczyciele_dane.listaNauczycieli[0].Login + ";" 
                                + Nauczyciele_dane.listaNauczycieli[0].Haslo, Encoding.UTF8);

                            sw.Close();

                            this.Hide();//Powróc do panelu głównego
                            Panel_wyboru Panel_wyboru = new Panel_wyboru();
                            Panel_wyboru.Show();//Otwórz panel wyboru
                        }
                    }
                }

            }



        }

    }
}
