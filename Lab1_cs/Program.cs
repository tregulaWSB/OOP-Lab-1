using System;

namespace Lab1_cs
{
  class Program
  {
    static void Main(string[] args)
    {
      // Zad1();
      // Zad2();
      Zad3();
    }

    static void Zad1()
    {
      Console.WriteLine("Podaj dwie liczby i znak operacji (+, -, * lub /) oddzielone spacją (np. 10 20 +): ");
      string input = Console.ReadLine();

      string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      if (parts.Length != 3)
      {
        Console.WriteLine("Błąd: Niepoprawna ilość argumentów.");
        return;
      }

      if (!double.TryParse(parts[0], out double num1) || !double.TryParse(parts[1], out double num2))
      {
        Console.WriteLine("Błąd: Niepoprawne argumenty.");
        return;
      }

      string operation = parts[2];

      if (operation == "+")
      {
        Console.WriteLine($"Wynik: {num1 + num2}");
      }
      else if (operation == "-")
      {
        Console.WriteLine($"Wynik: {num1 - num2}");
      }
      else if (operation == "*")
      {
        Console.WriteLine($"Wynik: {num1 * num2}");
      }
      else if (operation == "/")
      {
        if (num2 == 0)
        {
          Console.WriteLine("Błąd: Dzielenie przez 0.");
        }
        else
        {
          Console.WriteLine($"Wynik: {num1 / num2}");
        }
      }
      else
      {
        Console.WriteLine("Błąd: Niepoprawny znak operacji.");
        return;
      }
    }

    static void Zad2()
    {
      Console.WriteLine("Podaj kierunek konwersji oraz wartość temperatury oddzielone spacją (np. C 2, F 23): ");
      string input = Console.ReadLine();

      string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      if (parts.Length != 2)
      {
        Console.WriteLine("Błąd: Niepoprawna ilość argumentów.");
        return;
      }

      if (!double.TryParse(parts[1], out double num))
      {
        Console.WriteLine("Błąd: Niepoprawna wartość temperatury.");
        return;
      }

      string destination = parts[0];

      if (destination.Equals("c", StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine($"Wynik: {num}°C = {num * 1.8 + 32}°F");
      }
      else if (destination.Equals("f", StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine($"Wynik: {num}°F = {(num - 32) / 1.8}°C");
      }
      else
      {
        Console.WriteLine("Błąd: Niedozwolony kierunek konwersji.");
        return;
      }
    }

    static void Zad3()
    {
      Console.WriteLine("Podaj liczbę ocen (>0) oraz kolejne oceny ucznia (wartości od 1 do 6) oddzielone spacją (np. 4 5 3 4 2): ");
      string input = Console.ReadLine();

      string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      if (!int.TryParse(parts[0], out int length))
      {
        Console.WriteLine("Błąd: Niepoprawna liczba ocen do wprowadzenia.");
        return;
      }

      if (parts.Length != (length + 1) || length == 0)
      {
        Console.WriteLine("Błąd: Niepoprawna ilość ocen.");
        return;
      }

      int sum = 0;
      int grade;

      for (int i = 1; i <= length; i++)
      {

        if (int.TryParse(parts[i], out grade))
        {
          if (grade < 1 || grade > 6)
          {
            Console.WriteLine("Błąd: Niepoprawna wartość jednej z ocen.");
            return;
          }
        }
        else
        {
          Console.WriteLine("Błąd: Niepoprawna wartość jednej z ocen.");
          return;
        }

        sum += grade;
      }

      double result = sum / (double)length;
      if (result >= 3.0)
      {  
        Console.WriteLine($"Średnia: {result}\nUczeń zdał.");
      }
      else
      {
        Console.WriteLine($"Średnia: {result}\nUczeń nie zdał.");
      }
    }
  }
}
