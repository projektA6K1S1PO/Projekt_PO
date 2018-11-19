using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_pytan
{
    class Answer
    { // atrybuty klasy
        String content;// zmienna tresc odpowiedzi 
        bool correctness;// zmienna boolowska prawda fałsza 
        public Answer(String content, bool correctness) {//konstruktor umozliwia stworzenie obiektu klasy Answer
            
            this.content = content;// przypisuje parametr content (okreslony  w konstruktorze ) do atrybutu klasy content 
            this.correctness = correctness;// przypisuje parametr correctness (okreslony  w konstruktorze ) do atrybutu klasy correctness

        }

    }
}
