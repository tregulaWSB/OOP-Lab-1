def main():
  # Zad1()
  # Zad2()
  Zad3()

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

def Zad3():
  user_input = input("Podaj liczbę ocen (>0) oraz kolejne oceny ucznia (wartości od 1 do 6) oddzielone spacją (np. 4 5 3 4 2): ")
  parts = user_input.split()

  try:
    length = int(parts[0])
  except (ValueError, IndexError):
    print("Błąd: Niepoprawna liczba ocen do wprowadzenia.")
    return
  
  if len(parts) != (length + 1) or length == 0:
    print("Błąd: Niepoprawna ilość ocen.")
    return
  
  sum = 0

  for i in range(1, length + 1):
    try:
      grade = int(parts[i])
    except ValueError:
      print("Błąd: Niepoprawna wartość jednej z ocen.")
      return
    
    if grade < 1 or grade > 6:
      print("Błąd: Niepoprawna wartość jednej z ocen.")
      return
    
    sum += grade

  result = sum / length
  if result >= 3.0:
    print(f"Średnia: {result}\nUczeń zdał.")
  else:
    print(f"Średnia: {result}\nUczeń nie zdał.")

if __name__ == "__main__":
  main()
