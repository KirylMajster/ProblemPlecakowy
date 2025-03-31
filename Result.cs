
namespace ProblemPlecakowy
{
    public class Result
    {
        public List<Przedmiot> PrzedmiotyWPlecaku { get; }
        public int SumaWartosci { get; }
        public int SumaWagi { get; }

        public Result(List<Przedmiot> przedmioty, int sumaWartosci, int sumaWagi)
        {
            PrzedmiotyWPlecaku = przedmioty;
            SumaWartosci = sumaWartosci;
            SumaWagi = sumaWagi;
        }

        public override string ToString()
        {
            string wynik = "Przedmioty w plecaku:\n";
            foreach (var p in PrzedmiotyWPlecaku)
            {
                wynik += p + "\n";
            }
            wynik += $"Łączna wartość: {SumaWartosci}, Łączna waga: {SumaWagi}";
            return wynik;
        }
    }
}

