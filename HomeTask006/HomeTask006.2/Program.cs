void CWL(string msg)
{
  Console.WriteLine(msg);
}
void CW(string msg)
{
  Console.Write(msg);
}
string CR()
{
  return Console.ReadLine();
}
try
{
  void recursion(int N)
  {
    if (N <= 0)
      return;
    recursion(N / 2);
    CW($"{N % 2}");
  }

  CWL("Задание 2. Программа, которая будет преобразовывать десятичное число в двоичное.");
  CWL("Введите число: ");
  int number = Int32.Parse(CR());
  recursion(number);
}
catch { CWL("Вы ввели некорректное значение."); }
