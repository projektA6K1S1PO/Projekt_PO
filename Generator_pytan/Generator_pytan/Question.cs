using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_pytan
{
    class Question
    {   //atrybuty klasy
        String content; //zmienna tresc pytania 
        int points; //waga punktowa pytania 
        List<Answer> answers; // lista obiektow odpoiwedz ( lista zawiera w sobie obiekty klasy Answer )
        //Question(tu parametry konstruktora!)
        public Question(String content, int points) {//publiczny czyli jest widoczny dla innych klas, konstruktor umozliwia stworzenie obiektu klasy Question
            this.content = content; // przypisuje parametr content (okreslony  w konstruktorze ) do atrybutu klasy content 
            this.points = points; // przypisuje parametr points (okreslony  w konstruktorze ) do atrybutu klasy points
            this.answers = new List<Answer>();  //inicjalizacja listy 

        }


    }
}
