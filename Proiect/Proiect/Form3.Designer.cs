namespace Proiect
{
    partial class Form3
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
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGrafic
            // 
            this.panelGrafic.BackColor = System.Drawing.Color.White;
            this.panelGrafic.Location = new System.Drawing.Point(12, 12);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(360, 300);
            this.panelGrafic.TabIndex = 0;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 324);
            this.Controls.Add(this.panelGrafic);
            this.Name = "Form3";
            this.Text = "Vizualizare Grafic";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelGrafic;
    }
}