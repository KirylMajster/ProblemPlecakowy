using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("test"), InternalsVisibleTo("Gui")]

namespace ProblemPlecakowy
{
    public class Problem
    {
        public List<Przedmiot> Przedmioty { get; }
        public Problem(int n, int seed)
        {
            Przedmioty = new List<Przedmiot>();
            Random random = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                int waga = random.Next(1, 11);
                int wartosc = random.Next(1, 11);
                Przedmioty.Add(new Przedmiot(waga, wartosc));
            }
        }

        public Result Solve(int capacity)
        {
            List<Przedmiot> plecak = new List<Przedmiot>();
            int aktWaga = 0;
            int sumWartosc = 0;


            Przedmioty.Sort((a, b) =>
            {
                double stosunekA = (a.Waga > 0) ? (a.Wartosc / (double)a.Waga) : 0;
                double stosunekB = (b.Waga > 0) ? (b.Wartosc / (double)b.Waga) : 0;
                return stosunekB.CompareTo(stosunekA);
            });

            foreach (var p in Przedmioty)
            {
                if (p.Waga <= 0) continue;
                if (aktWaga + p.Waga <= capacity)
                {
                    plecak.Add(p);
                    aktWaga += p.Waga;
                    sumWartosc += p.Wartosc;
                }
            }

            return new Result(plecak, sumWartosc, aktWaga);
        }

        public override string ToString()
        {
            string wynik = "Lista przedmiotów w problemie plecakowym:\n";

            foreach (var p in Przedmioty)
            {
                wynik += p + "\n";
            }

            return wynik;
        }

    }
}