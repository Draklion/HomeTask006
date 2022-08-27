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
  CW("Задание 6. Программа,  которая будет создавать копию заданного массива с помощью поэлементного копирования.");
  CW("Введите количество элементов массива: ");

  int number = Int32.Parse(CR());
  int[] sides = new int[number];
  CW("Введите элементы массива: ");

  for (int i = 0; i < number; i++) sides[i] = Int32.Parse(CR());

  Сopying(sides);

  void Сopying(int[] array, int i = 0)
  {
    int[] arrayCopy = new int[array.Length];
    if (i < array.Length)
    {
      arrayCopy[i] = array[i];
      if (i == arrayCopy.Length - 1) CW($"Скопированный массив:[{string.Join(",", array)}]");
      Сopying(array, i + 1);
    }
  }
}
catch (InvalidCastException e) { }
