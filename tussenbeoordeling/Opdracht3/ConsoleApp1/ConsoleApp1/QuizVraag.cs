using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QuizVraag
    {
        internal string vraag;
        internal string antwoord;
        

        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
        class QuizVraagAntwoord
        {
            internal QuizVraag vraag;
            internal bool goed;
        }
        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("Hoe lang duurt school?", "Telang");
        }
    }
}
