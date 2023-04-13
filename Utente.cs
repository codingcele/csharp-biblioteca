using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Utente
    {

        public string Nome { get; set; }
		public string Cognome { get; set; }
        public string Email { get; set; }
		public string Password { get; set; }
		public string RecapitoTelefonico { get; set; }


        public Utente(string nome, string cognome, string email, string password, string recapitoTelefonico)
        {
            this.Nome = nome;
			this.Cognome = cognome;
			this.Email = email;
            this.Password = password;
            this.RecapitoTelefonico = recapitoTelefonico;

        }

        public double PrezzoBase()
        {
            Console.WriteLine("Il prezzo base del prodotto è: " + this.prezzo.ToString());
            return this.prezzo;
        }

        public double PrezzoConIva()
        {
            double prezzoConIva = this.prezzo * (1 + this.iva);
            Console.WriteLine("Il prezzo con Iva del prodotto è: " + prezzoConIva.ToString());
            return prezzoConIva;
        }

        public string NomeCompleto()
        {
            string nomeCompleto = this.codice.ToString() + this.nome;
            Console.WriteLine("Il nome completo del prodotto è: " + nomeCompleto);
            return nomeCompleto;
        }
    }
     
}