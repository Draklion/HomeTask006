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
  CW("Задание 3. Программа, которая считает сколько чисел больше 0 ввёл пользователь.");
  CW("Введите количество элементов массива: ");

  int number = Int32.Parse(CR());
  int[] sides = new int[number];
  CW("Введите элементы массива: ");

  for (int i = 0; i < number; i++) sides[i] = Int32.Parse(CR());

  Sorting(sides);

  void Sorting(int[] array, int i = 0, int count = 0)
  {
    if (i < array.Length)
    {
      count = array[i] > 0 ? ++count : count;
      if (i == array.Length - 1) CW($"Количество чисел больше 0: {count.ToString()}");
      Sorting(array, i + 1, count);
    }
  }
}
catch (InvalidCastException e) { }
