using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Joburi
    {
        private string nume;
        private char experienta; //J - junior sau S - Senior

        public Joburi()
        {
            nume = "Necunoscut";
            experienta = 'J';
        }

        public Joburi(string n, char e)
        {
            nume = n;
            experienta = e;
        }

        public string Nume
        {
            get => nume; set => nume = value;
        }

        public char Experienta
        {
            get => experienta; set => experienta = value;
        }

        public override string ToString()
        {
            return nume + " cu experienta de "+experienta;
        }

    }
}
