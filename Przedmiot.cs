using System;

namespace ProblemPlecakowy
{
	public class Przedmiot
	{
		public int Waga { get; }
		public int Wartosc { get; }
		public Przedmiot(int waga, int wartosc)
		{
			Waga = waga;
			Wartosc = wartosc;
		}

		public override string ToString()
		{
			return $"Przedmiot - Waga: {Waga}, Wartosc: {Wartosc}";
		}
	}
}