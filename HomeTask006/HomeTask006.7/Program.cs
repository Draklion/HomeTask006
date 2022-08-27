void CW(string msg)
{
  Console.WriteLine(msg);
}
string CR()
{
  return Console.ReadLine();
}

try
{
  CW("Задание 7. Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
  CW("Введите число: ");

  int number = Int32.Parse(CR());

  Factorial(number);

  void Factorial(int number, int i = 1, int composition = 1)
  {
    if (i <= number)
    {
      composition = composition * i;
      if (i == number) CW($"Произведение чисел от 1 до {number}: {composition}");
      Factorial(number, i + 1, composition);
    }
  }
}
catch (InvalidCastException e) { }
