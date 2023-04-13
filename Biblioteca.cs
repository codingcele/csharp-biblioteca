using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {

        private List<Utente> Utenti { get; set; }
        private List<Prestito> Prestiti { get; set; }
        private List<Documento> Documenti { get; set; }

        public Biblioteca()
        {
            Utenti = new List<Utente>();
            Prestiti = new List<Prestito>();
            Documenti = new List<Documento>();
        }

        public void AddUtente(Utente utente)
        {
            Utenti.Add(utente);
        }

        public void AddPrestito(Prestito prestito)
        {
            Prestiti.Add(prestito);
        }

        public void AddDocumento(Documento documento)
        {
            Documenti.Add(documento);
        }
        
        public Documento RicercaPerCodice(string codice)
        {
            foreach (Documento documento in Documenti) 
            {
                if (documento.Codice == codice)
                    return documento;
            }
            return null;
        }

        public Documento RicercaPerTitolo(string titolo)
        {
            foreach (Documento documento in Documenti)
            {
                if (documento.Titolo == titolo)
                    return documento;
            }
            return null;
        }

        public void RegistraPrestito(DateTime da, DateTime a, Documento documento, Utente utente) 
        {
            Prestito prestito = new Prestito(da, a, documento, utente);
            AddPrestito(prestito);
        }

        public Prestito RicercaPerNome(string nome, string cognome)
        {
            foreach (Prestito prestito in Prestiti)
            {
                if (prestito.UtentePrestito.Nome == nome && prestito.UtentePrestito.Cognome == cognome)
                    return prestito;
            }
            return null;
        }

    }

}