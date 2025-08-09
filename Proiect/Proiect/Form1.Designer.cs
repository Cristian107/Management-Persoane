namespace Proiect
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.revizuireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxAngajati = new System.Windows.Forms.ListBox();
            this.panelDrop = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyRight1 = new Proiect.CopyRight();
            this.dateUser1 = new Proiect.DateUser();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revizuireToolStripMenuItem,
            this.graficToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";

            this.revizuireToolStripMenuItem.Name = "revizuireToolStripMenuItem";
            this.revizuireToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.revizuireToolStripMenuItem.Text = "Revizuire";
            this.revizuireToolStripMenuItem.Click += new System.EventHandler(this.revizuireToolStripMenuItem_Click);

            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);

            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.printPreviewToolStripMenuItem.Text = "Previzualizare imprimare";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);

            this.listBoxAngajati.AllowDrop = true;
            this.listBoxAngajati.FormattingEnabled = true;
            this.listBoxAngajati.Location = new System.Drawing.Point(166, 325);
            this.listBoxAngajati.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAngajati.Name = "listBoxAngajati";
            this.listBoxAngajati.Size = new System.Drawing.Size(211, 82);
            this.listBoxAngajati.TabIndex = 20;
            this.listBoxAngajati.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxAngajati_DragEnter);
            this.listBoxAngajati.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxAngajati_MouseDown);

            this.panelDrop.AllowDrop = true;
            this.panelDrop.BackColor = System.Drawing.Color.LightGray;
            this.panelDrop.Location = new System.Drawing.Point(441, 325);
            this.panelDrop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrop.Name = "panelDrop";
            this.panelDrop.Size = new System.Drawing.Size(204, 82);
            this.panelDrop.TabIndex = 21;
            this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
            this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);

            this.errorProvider1.ContainerControl = this;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lista cu persoane";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pune-ti aici persoanele care au nevoie de revizuire";

            this.copyRight1.Location = new System.Drawing.Point(531, 412);
            this.copyRight1.Name = "copyRight1";
            this.copyRight1.Size = new System.Drawing.Size(209, 73);
            this.copyRight1.TabIndex = 24;

            this.dateUser1.Location = new System.Drawing.Point(185, 27);
            this.dateUser1.Name = "dateUser1";
            this.dateUser1.Size = new System.Drawing.Size(401, 250);
            this.dateUser1.TabIndex = 25;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 488);
            this.Controls.Add(this.dateUser1);
            this.Controls.Add(this.copyRight1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDrop);
            this.Controls.Add(this.listBoxAngajati);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Gestiune Resurse Umane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem revizuireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxAngajati;
        private System.Windows.Forms.Panel panelDrop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CopyRight copyRight1;
        private DateUser dateUser1;
    }
}