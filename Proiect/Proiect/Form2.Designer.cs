namespace Proiect
{
    partial class Form2
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
            this.listBoxRevizuire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxRevizuire
            // 
            this.listBoxRevizuire.FormattingEnabled = true;
            this.listBoxRevizuire.Location = new System.Drawing.Point(12, 12);
            this.listBoxRevizuire.Name = "listBoxRevizuire";
            this.listBoxRevizuire.Size = new System.Drawing.Size(360, 199);
            this.listBoxRevizuire.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 224);
            this.Controls.Add(this.listBoxRevizuire);
            this.Name = "Form2";
            this.Text = "Persoane pentru Revizuire";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox listBoxRevizuire;
    }
}