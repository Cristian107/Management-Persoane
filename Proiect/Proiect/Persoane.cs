using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Persoane
    {
        private int id;
        private string nume;
        private char sex;
        private string email;
        Joburi job;
        Cursuri cursFacut;

        public Persoane() {
            id = 0;
            nume = "Anonim";
            sex = 'F';
            email = "Necunoscut";
            job = new Joburi();
            cursFacut = new Cursuri();
        }

        public Persoane(int i, string n, char s, string e, Joburi j,Cursuri c)
        {
            id = i;
            nume = n;
            sex = s;
            email = e;
            job = j;
            cursFacut = c;
        }

        public int Id { 
            get => id ; set => id = value;
        }

        public string Nume {  
            get => nume; set => nume = value; 
        }

        public char Sex { 
            get => sex; set => sex = value;
        }

        public string Email { 
            get => email; set => email = value;
        }

        public Joburi Job { 
            get=> job; set => job = value;
        }

        public Cursuri CursuriFacute
        {
            get => cursFacut; set => cursFacut = value;
        }


        public override string ToString()
        { 
            return "Persoana cu id-ul " + id + ", numita " + nume + " are sexul " + sex + ", adresa de email " + email+ " are jobul de " + job +
                " si a urmat cursul de: " +cursFacut;
        }
    }
}
