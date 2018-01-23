using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Sirius.Model
{
    class Questoes
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string RespostaA { get; set; }
        public string RespostaB { get; set; }
        public string RespostaC { get; set; }
        public string RespostaD { get; set; }
        public string RespostaCerta { get; set; }

        public Questoes(int Id, string Pergunta, string AnswerA, string AnswerB, string AnswerC, string AnswerD, string CorrectAnswer)
        {
            this.Id = Id;
            this.Pergunta = Pergunta;
            this.RespostaA = RespostaA;
            this.RespostaB = RespostaB;
            this.RespostaC = RespostaC;
            this.RespostaD = RespostaD;
            this.RespostaCerta = RespostaCerta;
        }
    }
}