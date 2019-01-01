using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_pytan
{
    class Question
    {   //atrybuty klasy

        public String tresc { get; set; } //zmienna tresc pytania 
        public int ilosc_odp{ get; set; }
        public String odp_1 { get; set; }
        public String odp_2 { get; set; }
        public String odp_3 { get; set; }
        public String odp_4 { get; set; }
        public String odp_5 { get; set; }
        public int odp_1_poprawna { get; set; }
        public int odp_2_poprawna { get; set; }
        public int odp_3_poprawna { get; set; }
        public int odp_4_poprawna { get; set; }
        public int odp_5_poprawna { get; set; }
        
        //Zmienne publiczne i statyczne
        public static  List<Question> listaPytan = new List<Question>();//Utworzenie nowej listy pytań
        public static string[,] baza_pytan_array;
        public static double maxpkt;  //Max ilość punktów do zdobycia pobrana z pliku z testem
        public static int[] losowanie;//Tablica na potrzeby losowania pytań bez powtórzeń
        


    }
}
