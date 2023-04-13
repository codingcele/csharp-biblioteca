using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro : Documento
    {
        public int NumeroPagine { get; set; }

        public Libro(string codice, string titolo, string anno, string settore, string scaffale, string nome, string cognome, int numeroPagine) 
            : base(codice, titolo, anno, settore, scaffale, nome, cognome)
        {
            this.NumeroPagine = numeroPagine;
        }
    }
}
