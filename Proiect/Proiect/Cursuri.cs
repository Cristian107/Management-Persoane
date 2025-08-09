using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Cursuri
    {
        private string nume;
        private bool diploma;

        public Cursuri()
        {
            nume = "Necunoscut";
            diploma = false;
        }

        public Cursuri(string n, bool d)
        {
            nume = n;
            diploma = d;
        }

        public string Nume
        {
            get => nume; set => nume = value;
        }

        public bool Diploma
        {
            get => diploma; set => diploma = value;
        }

        public override string ToString()
        {
            return "Cursul "+ nume + " care a oferit diploma: " + diploma;
        }
    }
}
