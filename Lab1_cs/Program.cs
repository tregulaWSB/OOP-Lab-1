using System;

namespace Lab1_cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Zad1();
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
  }
}
