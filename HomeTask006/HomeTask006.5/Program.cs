void CW(string msg)
{
  Console.WriteLine(msg);
}
void CWR(string msg)
{
  Console.WriteLine(msg);
}
string CR()
{
  return Console.ReadLine();
}

try
{
  CW("Задание 5. Программа, которая выводит первые N чисел Фибоначчи.");
  CW("Введите количество чисел, которые необходимо вывести: ");
  int number = Int32.Parse(CR());
  int[] array = new int[number];

  int firstNumberFibonacci = 0;
  int secondNumberFibonacci = 1;

  array[0] = firstNumberFibonacci;
  array[1] = secondNumberFibonacci;

  for (int i = 2; i < number; i++)
  {
    if (number < 2) break;

    array[i] = firstNumberFibonacci + secondNumberFibonacci;
    firstNumberFibonacci = secondNumberFibonacci;
    secondNumberFibonacci = array[i];
  }
  CW(string.Join(",", array));
}
catch (InvalidCastException e) { }
