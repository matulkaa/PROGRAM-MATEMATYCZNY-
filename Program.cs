using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("PROGRAM MATEMATYCZNY");
            Console.WriteLine("1. Obliczanie potęgi");
            Console.WriteLine("2. Pole trojkata");
            Console.WriteLine("3. Silnia");
            Console.WriteLine("4. Wyjscie");
            Console.Write("Wybierz opcje: ");

            int wybor = WczytajInt();

            switch (wybor)
            {
                case 1:
                    Potegowanie();
                    break;
                case 2:
                    PoleTrojkata();
                    break;
                case 3:
                    Silnie();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Nie ma takiego wyboru");
                    break;
            }
        }
    }
    static void Potegowanie()
    {
        Console.Write("Podaj podstawe: ");
        double podstawa = WczytajDouble();

        Console.WriteLine("Podaj wykladnik: ");
        double wykladnik = WczytajDouble();

        double Wynik = Math.Pow(podstawa, wykladnik);
        Console.WriteLine($"Wynik = {Wynik}");
    }
    static void PoleTrojkata()
    {
        Console.Write("Podaj dlugosc podstawy a:");
        double a = WczytajDouble();

        Console.WriteLine("Podaj wysokosc h:");
        double h = WczytajDouble();

        double pole = 0.5 * a * h;
        Console.WriteLine($"Pole Trojkata = {pole}");
    }
    static void Silnie()
    {
        Console.WriteLine("Podaj liczbe do obliczenia silni");

        int n = WczytajIntDodatni();

        int silnia = 1;
        for (int i = 1; i <= n; i++)
        {
            silnia *= i;
        }
        Console.WriteLine($"{n} = {silnia}");
    }
    static double WczytajDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double liczba))
                return liczba;

            else Console.WriteLine("Blad. Podaj liczbe typu: 2.5!!!");
        }
    }
    static int WczytajInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int liczba))
                return liczba;

            else Console.WriteLine("Blad. Podaj liczbe calkowita!!!");
        }
    }
    static int WczytajIntDodatni()
    {
        while (true)
        {
             int liczba = WczytajInt() ;
            if (liczba >=0) 
                return liczba;

            else Console.WriteLine("Blad. Podaj liczbe dodatnia!!!");
        }
    }
}   

