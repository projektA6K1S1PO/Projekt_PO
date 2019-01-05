using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_pytan
{
    class Student_oceny
    {
        //Atrybuty klasy
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String Nr_indeksu { get; set; }
        public String Grupa { get; set; }

        public static List<Student_oceny> listaStudentów = new List<Student_oceny>();//Utworzenie nowej listy pytań

       
        //Zmienne do widełek ocen
        public static int ndstDo;
        public static int dstDo;
        public static int dbDo;
        // Zmienne przydatne
        public static double procenty;
        public static string nazwa_pliku = "default";
        public static int ilosc_studentow;


    }
}
