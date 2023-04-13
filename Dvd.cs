using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dvd : Documento
    {
        public int Durata { get; set; }

        public Dvd(string codice, string titolo, string anno, string settore, string scaffale, string nome, string cognome, int durata)
            : base(codice, titolo, anno, settore, scaffale, nome, cognome)
        {
            this.Durata = durata;
        }
    }
}
