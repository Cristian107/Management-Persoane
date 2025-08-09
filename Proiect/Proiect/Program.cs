using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
             Joburi job1 = new Joburi();
             Console.WriteLine(job1);
             Joburi job2 = new Joburi(1,"Consultant IT", 'S');
             Console.WriteLine(job2);

             Console.WriteLine();

             Cursuri c1 = new Cursuri();
             Console.WriteLine(c1);
             Cursuri c2 = new Cursuri("Programarea aplicatilor windows", true);
             Console.WriteLine(c2);

             Console.WriteLine();

             List<Cursuri> cursuriLista = new List<Cursuri> {c1, c2};

             Persoane p1 = new Persoane();
             Console.WriteLine(p1);
             Persoane p2 = new Persoane(1, "Marcel", 'M', "Marcel12@gmail.com", job2, cursuriLista);
             Console.WriteLine(p2);
            */
        }
    }
}
