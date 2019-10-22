using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratoriListe
{
    [Serializable]
    public enum Sesso
    {
        N, F, M
    }
    public class Lavoratori
    {

        public string Nome {get; set;}
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        Sesso Genere { get; set; }
        public Lavoratori() { }
        public Lavoratori(string nome, string cognome, DateTime data, Sesso gen)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = data;
            Genere = gen;
        }
        public override string ToString()
        {
            return string.Format("Il lavoratore {0} {1} è nato il {2:d}",
            Nome, Cognome, DataDiNascita);
        }
    }
}
