using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemPlecakowy;

namespace ProblemPlecakowy
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void Solve_ReturnsAtLeastOneItem_WhenCapacityIsEnough()
        {
            // Arrange
            var problem = new Problem(5, 42); // 5 przedmiotów, seed 42
            int pojemnoscPlecaka = 10; // Plecak ma pojemność 10

            // Act
            var result = problem.Solve(pojemnoscPlecaka);

            // Assert
            Assert.IsTrue(result.PrzedmiotyWPlecaku.Count > 0, "Rozwiązanie powinno zawierać co najmniej jeden przedmiot.");
        }

        [TestMethod]
        public void check_that_nothing_fits()
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot(15, 10),
                new Przedmiot(20, 8),
                new Przedmiot(25, 12)
            };

            var problem = new ProblemMock(przedmioty);

            int pojemnosc = 10; // za mała, by coś się zmieściło

            var wynik = problem.Solve(pojemnosc);

            // Assert
            Assert.AreEqual(0, wynik.PrzedmiotyWPlecaku.Count);
            Assert.AreEqual(0, wynik.SumaWartosci);
            Assert.AreEqual(0, wynik.SumaWagi);

        }

        internal class ProblemMock : Problem
        {
            public ProblemMock(List<Przedmiot> przedmioty) : base(0, 0)
            {
                this.Przedmioty.Clear();
                this.Przedmioty.AddRange(przedmioty);
            }
        }

        [TestMethod]
        public void instancja()
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot(2, 10),  // A
                new Przedmiot(3, 14),  // B
                new Przedmiot(5, 15)   // C
            };

            var problem = new ProblemMock(przedmioty);
            int capacity = 5;

            // Act
            var wynik = problem.Solve(capacity);

            // Assert – sprawdzamy, czy w plecaku są przedmioty A i B
            Assert.AreEqual(2, wynik.PrzedmiotyWPlecaku.Count);
            Assert.AreEqual(24, wynik.SumaWartosci);
            Assert.AreEqual(5, wynik.SumaWagi);

        }

        [TestMethod]
        public void everything_fits() 
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot(1, 2),
                new Przedmiot(2, 3),
                new Przedmiot(3, 4)
            };

            var problem = new ProblemMock(przedmioty);
            var wynik = problem.Solve(10);

            Assert.AreEqual(3, wynik.PrzedmiotyWPlecaku.Count);
            Assert.AreEqual(100, wynik.SumaWartosci);
            Assert.AreEqual(6, wynik.SumaWagi);
        }

        [TestMethod]
        public void thing_with_0_weight()
        {
            var przedmioty = new List<Przedmiot>
            {
                new Przedmiot(0, 100),
                new Przedmiot(2, 3),
                new Przedmiot(3, 4)
            };

            var problem = new ProblemMock(przedmioty);
            var wynik = problem.Solve(3);

            Assert.IsFalse(wynik.PrzedmiotyWPlecaku.Any(p => p.Waga == 0));
            Assert.AreEqual(1, wynik.PrzedmiotyWPlecaku.Count);  
            Assert.AreEqual(3, wynik.SumaWartosci);
            Assert.AreEqual(2, wynik.SumaWagi);
        }

    }

}
