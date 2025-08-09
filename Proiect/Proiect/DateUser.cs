using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect
{
    public partial class DateUser : UserControl
    {
        private IContainer components = null;
        private TextBox tbCod;
        private TextBox tbNume;
        private ComboBox cbSex;
        private TextBox tbEmail;
        private TextBox tbJob;
        private ComboBox cbExperienta;
        private ComboBox cbCurs;
        private ComboBox cbDiploma;
        private Button button1;
        private Label label1, label2, label3, label4, label5, label6, label7, label8;
        private ErrorProvider errorProvider1;

        public event EventHandler SaveButtonClicked;

        public DateUser()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.cbExperienta = new System.Windows.Forms.ComboBox();
            this.cbCurs = new System.Windows.Forms.ComboBox();
            this.cbDiploma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            this.errorProvider1.ContainerControl = this;

            this.tbCod.Location = new System.Drawing.Point(142, 9);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(76, 20);
            this.tbCod.TabIndex = 0;

            this.tbNume.Location = new System.Drawing.Point(142, 35);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(76, 20);
            this.tbNume.TabIndex = 1;

            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSex.Location = new System.Drawing.Point(142, 69);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(92, 21);
            this.cbSex.TabIndex = 2;

            this.tbEmail.Location = new System.Drawing.Point(142, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(76, 20);
            this.tbEmail.TabIndex = 3;

            this.tbJob.Location = new System.Drawing.Point(142, 130);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(76, 20);
            this.tbJob.TabIndex = 4;

            this.cbExperienta.FormattingEnabled = true;
            this.cbExperienta.Items.AddRange(new object[] {
            "J",
            "S"});
            this.cbExperienta.Location = new System.Drawing.Point(306, 130);
            this.cbExperienta.Name = "cbExperienta";
            this.cbExperienta.Size = new System.Drawing.Size(92, 21);
            this.cbExperienta.TabIndex = 5;

            this.cbCurs.FormattingEnabled = true;
            this.cbCurs.Items.AddRange(new object[] {
            "SQL",
            "C#",
            "PHP",
            "Linux",
            "Python"});
            this.cbCurs.Location = new System.Drawing.Point(142, 159);
            this.cbCurs.Name = "cbCurs";
            this.cbCurs.Size = new System.Drawing.Size(92, 21);
            this.cbCurs.TabIndex = 6;

            this.cbDiploma.FormattingEnabled = true;
            this.cbDiploma.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbDiploma.Location = new System.Drawing.Point(306, 160);
            this.cbDiploma.Name = "cbDiploma";
            this.cbDiploma.Size = new System.Drawing.Size(92, 21);
            this.cbDiploma.TabIndex = 7;

            this.button1.Location = new System.Drawing.Point(142, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adaugă";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click); 

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nume";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sex";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Job";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cursuri";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Diplomă";

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Experiență";

            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.cbExperienta);
            this.Controls.Add(this.cbCurs);
            this.Controls.Add(this.cbDiploma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "PersonInputControl";
            this.Size = new System.Drawing.Size(401, 250);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public int Id => int.TryParse(tbCod.Text, out int id) ? id : -1;
        public string Nume => tbNume.Text;
        public string Sex => cbSex.SelectedItem?.ToString() ?? "";
        public string Email => tbEmail.Text;
        public string Job => tbJob.Text;
        public string Experienta => cbExperienta.SelectedItem?.ToString() ?? "";
        public string Curs => cbCurs.SelectedItem?.ToString() ?? "";
        public bool Diploma => cbDiploma.SelectedItem?.ToString() == "true";

        public bool ValidateInput()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrEmpty(tbCod.Text))
            {
                errorProvider1.SetError(tbCod, "Introduceti codul!");
                isValid = false;
            }
            else if (!int.TryParse(tbCod.Text, out _))
            {
                errorProvider1.SetError(tbCod, "Codul trebuie să fie numeric!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(tbNume.Text))
            {
                errorProvider1.SetError(tbNume, "Introduceti numele!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(cbSex.Text))
            {
                errorProvider1.SetError(cbSex, "Selectati sexul!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                errorProvider1.SetError(tbEmail, "Introduceti email-ul!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(tbJob.Text))
            {
                errorProvider1.SetError(tbJob, "Introduceti job-ul!");
                isValid = false;
            }
            if (cbExperienta.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbExperienta, "Selectati nivelul de experienta!");
                isValid = false;
            }
            if (string.IsNullOrEmpty(cbCurs.Text))
            {
                errorProvider1.SetError(cbCurs, "Introduceti cursul!");
                isValid = false;
            }
            if (cbDiploma.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbDiploma, "Selectati dacă cursul a oferit diplomă!");
                isValid = false;
            }

            return isValid;
        }

        public void Clear()
        {
            tbCod.Clear();
            tbNume.Clear();
            cbSex.SelectedIndex = -1;
            tbEmail.Clear();
            tbJob.Clear();
            cbExperienta.SelectedIndex = -1;
            cbCurs.SelectedIndex = -1;
            cbDiploma.SelectedIndex = -1;
            errorProvider1.Clear();
        }
    }
}