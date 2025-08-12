using System;
using System.Collections.Generic;

class Program
{
	static void Main ()
	{
		List<Produkt> produkter = new List<Produkt>();

		produkter.Add(new Produkt ("Teskedsgumman", 345));

		bool kör = true;

		while (kör)
		{
			try
			{
				Console.Write("Ange tavla, eller skriv 'slut':");
				string namn = Console.ReadLine();

				if(namn.ToLower()=="slut")
				{
					kör = false;
					continue;
				}

				Console.Write("Kostnad:");
				double pris = Convert.ToDouble (Console.ReadLine());
		
				produkter.Add(new Produkt (namn,pris));
			}

			catch (FormatException)
			{
				Console.WriteLine("Du måste ange ett pris");
			}

		}

		Console.WriteLine("\nLista på tavlor");
		foreach (Produkt p in produkter)
		{
			p.VisaInfo();
		}
	}
}
