namespace ProblemPlecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę przedmiotów: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Podaj seed: ");
            int seed = int.Parse(Console.ReadLine());

            Console.Write("Podaj pojemność plecaka: ");
            int capacity = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem);

            Result wynik = problem.Solve(capacity);

            Console.WriteLine("\nRozwiązanie:");
            Console.WriteLine(wynik);
        }
    }
}
