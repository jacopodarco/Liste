using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratoriListe
{
    class Program
    {
        static void Main(string[] args)
        {
            string Percorso = "C:\\Users\\CORSO 55\\Desktop";
            string FileName = "ListaLavoratori.txt";
            string FullPath = Path.Combine(Percorso, FileName);

            if (!Directory.Exists(Percorso))
            {
                Directory.CreateDirectory(Percorso);
            }

            if (!File.Exists(FullPath))
            {
                File.Create(FullPath);
            }

            List<Lavoratori> listL = new List<Lavoratori>();
            Lavoratori[] Lav = new Lavoratori[]
            {
                new Lavoratori("Lurollo", "Magneton", DateTime.Today, Sesso.N),
                new Lavoratori("Deroki", "Ret", DateTime.Today, Sesso.M),
                new Lavoratori("Frastuono", "Elevato", DateTime.Today, Sesso.F),
                new Lavoratori("Pokker", "Sabaht", DateTime.Today, Sesso.M),
                new Lavoratori("Mohammed", "Rugmenistan", DateTime.Today, Sesso.M)
            };

            listL.AddRange(Lav);

            string print = string.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (var k in listL)
            {
                sb.AppendLine(k.ToString());
            }

            File.WriteAllText(FullPath, sb.ToString());

            string result = File.ReadAllText(FullPath);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
