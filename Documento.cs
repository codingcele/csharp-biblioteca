using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Documento
    {

        public string Codice { get; set; }
		public string Titolo { get; set; }
        public string Anno { get; set; }
		public string Settore { get; set; }
		public string Scaffale { get; set; }

		public Autore Autore { get; set; }


		public Documento(string codice, string titolo, string anno, string settore, string scaffale, string nome, string cognome)
        {
            Codice = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            Autore = new Autore(nome, cognome);
        }

    }

}