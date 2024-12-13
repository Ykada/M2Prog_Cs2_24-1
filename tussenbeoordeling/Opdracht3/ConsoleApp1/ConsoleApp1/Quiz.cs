using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
        internal Quiz(int aantalvragen)
        {
            vragen = new QuizVraag[aantalvragen];
        }
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;

        }
        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizvraag = new QuizVraag(vraag,antwoord);
            VoegVraagToeOpIndex(index, quizvraag);
        }
        internal void StelVraag(int vraagIndex)
        {
            QuizVraag vraag = vragen[vraagIndex];
        }
    }
}
