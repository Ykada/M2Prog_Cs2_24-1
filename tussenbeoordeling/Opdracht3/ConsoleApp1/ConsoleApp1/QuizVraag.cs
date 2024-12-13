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
            Quiz.VoegVraagToeOpIndex(0, quizvraag);
            Quiz quiz = new Quiz(10);
            QuizVraag quizVraag = new QuizVraag("Hoe lang duurt school?", 
                "Telang", 
                "What’s a hobby or activity you’ve always wanted to try but haven’t yet?", 
                "If you could change one thing about the world, what would it be?",
                "Do you believe in fate, free will, or a mix of both?",
                "What’s your idea of the perfect vacation?",
                "If you could instantly learn any skill, what would you choose?",
                "If you could have dinner with any historical figure, who would it be and why?");
        }
    }
}
