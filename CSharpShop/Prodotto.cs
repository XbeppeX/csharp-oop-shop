using System;
namespace CSharpShop
{
	public class Prodotto
	{
		private int codice;
		public string nome;
		public string descrizione;
		public int prezzo;
		public int iva;

		public Prodotto(string nome1 , string descrizione1, int prezzo1, int iva1 )
		{
			nome = nome1;
			descrizione = descrizione1;
			prezzo = prezzo1;
			iva = iva1;

		}

		public double CalcoloPrezzoConIva()
        {
			double ivato = prezzo * iva / 100;
			double prezzoFinale = prezzo + ivato;
			return prezzoFinale;
        }

		public int NumeroCasualeCodice()
        {
			Random r = new Random();
			return r.Next(100000000);
        }
		public void StampaPrezzoSenzaIva()
        {
			Console.WriteLine("Prezzo prodotto senza Iva: " + prezzo + "€");
        }

		public void StampaPrezzoConIva()
		{
			Console.WriteLine("Prezzo prodotto con Iva: " + CalcoloPrezzoConIva() + " €");
		}

		public void StampaNomeCodice()
		{
			Console.WriteLine("Nome esteso prodotto " + NumeroCasualeCodice() + nome);
		}
	}
}

