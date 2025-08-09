using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form2 : Form
    {
        private List<Persoane> persoanePentruRevizuire;

        public Form2(List<Persoane> persoane)
        {
            InitializeComponent();
            this.persoanePentruRevizuire = persoane;
            LoadPersoaneRevizuire();
        }

        private void LoadPersoaneRevizuire()
        {
            listBoxRevizuire.Items.Clear();
            foreach (var persoana in persoanePentruRevizuire)
            {
                listBoxRevizuire.Items.Add($"ID: {persoana.Id}, Nume: {persoana.Nume}, Job: {persoana.Job.Nume}, Experiență: {persoana.Job.Experienta}");
            }
        }
    }
}