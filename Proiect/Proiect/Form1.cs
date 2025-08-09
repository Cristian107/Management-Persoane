using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Proiect
{
    public partial class Form1 : Form
    {
        private List<Persoane> persoane = new List<Persoane>();
        private List<Persoane> persoanePentruRevizuire = new List<Persoane>();
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PersoaneDB.accdb;";
            if (!File.Exists(Path.Combine(Application.StartupPath, "PersoaneDB.accdb")))
            {
                MessageBox.Show("Baza de date nu a fost găsită!");
                return;
            }
            this.KeyPreview = true;
            this.KeyDown += Button1_KeyPress;
            this.dateUser1.SaveButtonClicked += PersonInputControl_SaveButtonClicked;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAngajati();
        }

        private void LoadAngajati()
        {
            listBoxAngajati.Items.Clear();
            persoane.Clear();
            using (OleDbConnection conexiune = new OleDbConnection(connectionString))
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand("SELECT * FROM Persoane", conexiune);
                    OleDbDataReader reader = comanda.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nume = reader.GetString(1);
                        char sex = reader.GetString(2)[0];
                        string email = reader.GetString(3);
                        string jobNume = reader.GetString(4);
                        char experienta = reader.GetString(5)[0];
                        string curs = reader.GetString(6);
                        bool diploma = reader.GetBoolean(7);

                        Joburi job = new Joburi(jobNume, experienta);
                        Cursuri cursObj = new Cursuri(curs, diploma);
                        Persoane persoana = new Persoane(id, nume, sex, email, job, cursObj);
                        persoane.Add(persoana);
                        listBoxAngajati.Items.Add(persoana.Nume);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la încărcarea datelor: {ex.Message}");
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void Button1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                PersonInputControl_SaveButtonClicked(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void PersonInputControl_SaveButtonClicked(object sender, EventArgs e)
        {
            if (!dateUser1.ValidateInput())
            {
                return;
            }

            using (OleDbConnection conexiune = new OleDbConnection(connectionString))
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "INSERT INTO Persoane (Id, Nume, Sex, Email, JobNume, Experienta, Curs, Diploma) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    comanda.Parameters.Add("Id", OleDbType.Integer).Value = dateUser1.Id;
                    comanda.Parameters.Add("Nume", OleDbType.Char, 50).Value = dateUser1.Nume;
                    comanda.Parameters.Add("Sex", OleDbType.Char, 1).Value = dateUser1.Sex;
                    comanda.Parameters.Add("Email", OleDbType.Char, 50).Value = dateUser1.Email;
                    comanda.Parameters.Add("JobNume", OleDbType.Char, 50).Value = dateUser1.Job;
                    comanda.Parameters.Add("Experienta", OleDbType.Char, 1).Value = dateUser1.Experienta;
                    comanda.Parameters.Add("Curs", OleDbType.Char, 50).Value = dateUser1.Curs;
                    comanda.Parameters.Add("Diploma", OleDbType.Boolean).Value = dateUser1.Diploma;
                    comanda.ExecuteNonQuery();

                    MessageBox.Show("Persoana a fost salvată cu succes!");
                    dateUser1.Clear();
                    LoadAngajati();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la salvarea datelor: {ex.Message}");
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            float yPos = e.PageBounds.Y + 10;
            float xPos = e.PageBounds.X + 10;
            Brush br = new SolidBrush(Color.Black);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font font = new Font(FontFamily.GenericSansSerif, 12);

            gr.DrawString("Lista Angajați", titleFont, br, new PointF(xPos, yPos));
            yPos += titleFont.Height + 10;

            foreach (var persoana in persoane)
            {
                string line = $"ID: {persoana.Id}, Nume: {persoana.Nume}, Job: {persoana.Job.Nume}, Experiență: {persoana.Job.Experienta}";
                gr.DrawString(line, font, br, new PointF(xPos, yPos));
                yPos += font.Height + 5;
                if (yPos > e.PageBounds.Height - 10)
                    break;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAngajati();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void listBoxAngajati_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxAngajati.SelectedItem != null)
            {
                listBoxAngajati.DoDragDrop(listBoxAngajati.SelectedItem.ToString(), DragDropEffects.Move);
            }
        }

        private void listBoxAngajati_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void panelDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelDrop_DragDrop(object sender, DragEventArgs e)
        {
            string nume = e.Data.GetData(DataFormats.Text).ToString();
            var persoana = persoane.FirstOrDefault(p => p.Nume == nume);
            if (persoana != null)
            {
                persoanePentruRevizuire.Add(persoana);
                MessageBox.Show($"Angajat marcat pentru revizuire: {persoana.Nume}, Job: {persoana.Job.Nume}");
            }
        }

        private void revizuireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(persoanePentruRevizuire);
            form2.ShowDialog();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(persoane);
            form3.ShowDialog();
        }

        private DateUser personInputControl;

    }
}