using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestito
    {
        public DateTime Da { get; set; }
        public DateTime A { get; set; }
        public Documento DocumentoPrestato { get; set; }
        public Utente UtentePrestito { get; set; }

        public Prestito(DateTime da, DateTime a, Documento documentoPrestato, Utente utentePrestito)
        {
            Da = da;
            A = a;
            DocumentoPrestato = documentoPrestato;
            UtentePrestito = utentePrestito;
        }
    }
}
