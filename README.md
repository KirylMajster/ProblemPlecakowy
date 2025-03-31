# ProblemPlecakowy_Zad1
1. Opis projektu

Celem projektu jest implementacja algorytmu rozwiązującego problem plecakowy (ang. Knapsack Problem) w wersji uproszczonej: bez dzielenia przedmiotów, z wartościami i wagami w całkowitych liczbach. 
Projekt składa się z trzech części:
Logika problemu 
Testy jednostkowe 
Interfejs graficzny 

2. Najważniejsze klasy i funkcje

Klasa Przedmiot – reprezentuje przedmiot z wagą i wartością:
public int Waga { get; }
public int Wartosc { get; }

Klasa Problem – odpowiada za generację losowych przedmiotów oraz rozwiązywanie problemu plecakowego za pomocą algorytmu zachłannego:
public Problem(int n, int seed)
public Result Solve(int capacity)

Algorytm sortuje przedmioty według stosunku wartosc/waga i dodaje je do plecaka, dopóki nie przekroczona zostanie pojemność.

Klasa Result – zawiera wynik rozwiązania:
lista wybranych przedmiotów,
suma wartości,
suma wag.

public List<Przedmiot> PrzedmiotyWPlecaku
public int SumaWartosci
public int SumaWagi

Klasa ProblemMock – klasa testowa pozwalająca podmienić losowo generowane dane na dane statyczne w testach jednostkowych.

3. Testy jednostkowe

Za pomocą MSTest stworzono testy jednostkowe sprawdzające między innymi:
Czy zwracany jest jakikolwiek wynik, gdy pojemność pozwala
Czy wynik jest pusty, gdy żaden przedmiot się nie mieści
Czy algorytm ignoruje przedmioty o wadze 0
Czy wszystko mieści się w plecaku przy dużej pojemności
Czy algorytm wybiera najbardziej opłacalne przedmioty

4. Interfejs graficzny (GUI)

GUI zostało wykonane w technologii Windows Forms (.NET 8.0). Pozwala:
Wprowadzić: Seed, Liczbę przedmiotów, Pojemność plecaka
Rozwiązać problem po kliknięciu przycisku
Wyświetlić listę przedmiotów oraz wynik
Walidować dane (błędne pola podświetlają się na czerwono)

5. Zastosowane techniki i funkcje

Sortowanie po stosunku wartość/waga
Algorytm zachłanny (Greedy)
Walidacja danych wejściowych (TryParse, kolorowanie błędnych pól)
Testy jednostkowe MSTest
Oddzielenie logiki od GUI
Obsługa błędów i przypadków brzegowych (waga = 0, pusta lista)
