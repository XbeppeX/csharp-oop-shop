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

		

		public void StampaCalcoloPrezzoConIva()
		{
			double ivato = prezzo * iva;
			double prezzoFinale = prezzo + ivato / 100;
			Console.WriteLine("Prezzo finale: " + prezzoFinale + "€ IVA: " + ivato / 100 + " €");
		}

		public double CalcoloPrezzoConIva()
        {
			double ivato = prezzo * iva;
			double prezzoFinale = prezzo + ivato / 100;
			return prezzoFinale;
        }

		public int NumeroCasualeCodice()
        {
			Random r = new Random();
			return r.Next(100000000);
        }
		public void StampaPrezzoSenzaIva()
        {
			Console.WriteLine("Prezzo prodotto senza Iva: " + prezzo + " €");
        }

		public void StampaPrezzoConIva()
		{
			Console.WriteLine("Prezzo prodotto con Iva: " + CalcoloPrezzoConIva() + " €");
		}

		public void StampaNomeCodice()
		{
			Console.WriteLine("Nome esteso prodotto " + NumeroCasualeCodice() + nome);
		}

		public void StampaProdotto()
        {
			Console.WriteLine("---Prodotto---");
			Console.WriteLine("Prezzo senza IVA: " + prezzo + " €");
			Console.WriteLine("Prezzo con IVA: " + CalcoloPrezzoConIva() + " €");
			Console.WriteLine("Descrizione prodotto: " + descrizione);
			Console.WriteLine("Nome esteso prodotto " + NumeroCasualeCodice() + nome);
		}
	}
}

