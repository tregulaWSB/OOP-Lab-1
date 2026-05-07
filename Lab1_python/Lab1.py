def main():
  # Zad1()
  Zad2()

def Zad1():
  user_input = input("Podaj dwie liczby i znak operacji (+, -, * lub /) oddzielone spacją (np. 10 20 +): ")
  parts = user_input.split()

  if len(parts) != 3:
    print("Błąd: Niepoprawna ilość argumentów.")
    return
  
  try:
    num1 = float(parts[0])
    num2 = float(parts[1])
  except ValueError:
    print("Błąd: Niepoprawne argumenty.")
    return
  
  operation = parts[2]

  if operation == "+":
    print(f"Wynik: {num1 + num2}")
  elif operation == "-":
    print(f"Wynik: {num1 - num2}")
  elif operation == "*":
    print(f"Wynik: {num1 * num2}")
  elif operation == "/":
    if num2 == 0:
      print("Błąd: Dzielenie przez 0.")
    else:
      print(f"Wynik: {num1 / num2}")
  else:
    print("Błąd: Niepoprawny znak operacji.")

def Zad2():
  user_input = input("Podaj kierunek konwersji oraz wartość temperatury oddzielone spacją (np. C 2, F 23): ")
  parts = user_input.split()

  if len(parts) != 2:
    print("Błąd: Niepoprawna ilość argumentów.")
    return
  
  try:
    num = float(parts[1])
  except ValueError:
    print("Błąd: Niepoprawna wartość temperatury.")
    return
  
  destination = parts[0]

  if destination.lower() == "c":
    print(f"Wynik: {num}°C = {num * 1.8 + 32}°F")
  elif destination.lower() == "f":
    print(f"Wynik: {num}°F = {(num - 32) / 1.8}°C")
  else:
    print("Błąd: Niedozwolony kierunek konwersji.")

if __name__ == "__main__":
  main()
