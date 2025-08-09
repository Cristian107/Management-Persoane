using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form3 : Form
    {
        private List<Persoane> persoane;
        private bool graficIncarcat = false;
        private Graphics gr;
        private const int marg = 10;
        private Color culoare = Color.Blue;
        private Font font = new Font(FontFamily.GenericSansSerif, 12);

        public Form3(List<Persoane> persoane)
        {
            InitializeComponent();
            this.persoane = persoane;
            graficIncarcat = true;
            panelGrafic.Invalidate();
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;
            if (graficIncarcat && persoane.Any())
            {
                var jobCounts = persoane.GroupBy(p => p.Job.Nume)
                                       .Select(g => new { Job = g.Key, Count = g.Count() })
                                       .ToList();

                Rectangle dreptunghiRosu = new Rectangle(
                    panelGrafic.ClientRectangle.X + marg,
                    panelGrafic.ClientRectangle.Y + 2 * marg,
                    panelGrafic.ClientRectangle.Width - 2 * marg,
                    panelGrafic.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, dreptunghiRosu);

                int nrJoburi = jobCounts.Count;
                double latime = dreptunghiRosu.Width / nrJoburi / 2;
                double distanta = (dreptunghiRosu.Width - nrJoburi * latime) / (nrJoburi + 1);
                double maxCount = jobCounts.Max(j => j.Count);

                Brush br = new SolidBrush(culoare);

                for (int i = 0; i < nrJoburi; i++)
                {
                    Rectangle rec = new Rectangle(
                        (int)(dreptunghiRosu.Location.X + (i + 1) * distanta + i * latime),
                        (int)(dreptunghiRosu.Location.Y + dreptunghiRosu.Height - (jobCounts[i].Count / maxCount * dreptunghiRosu.Height)),
                        (int)latime,
                        (int)(jobCounts[i].Count / maxCount * dreptunghiRosu.Height));
                    gr.FillRectangle(br, rec);
                    gr.DrawString(jobCounts[i].Job, font, br,
                        new Point((int)(rec.Location.X + latime / 2 - font.Size * jobCounts[i].Job.Length / 4),
                                  (int)(rec.Location.Y - font.Height)));
                    gr.DrawString(jobCounts[i].Count.ToString(), font, br,
                        new Point((int)(rec.Location.X + latime / 2 - font.Size),
                                  (int)(rec.Location.Y + rec.Height / 2)));
                }
            }
        }
    }
}