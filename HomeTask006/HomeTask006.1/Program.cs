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
  void existenceTriangle(double[] array, out string msg)
  {
    msg = array[0] > array[1] + array[2] ||
          array[1] > array[0] + array[2] ||
          array[2] > array[0] + array[1] ? "Треугольник не существует" : "Треугольник существует";
  }

  CW("Задание 1. Программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.");
  CW("Введите стороны треугольника: ");
  double[] sides = new double[3];
  string str = "";
  for (int i = 0; i < sides.Length; i++)
    sides[i] = Int32.Parse(CR());
  existenceTriangle(sides, out str);
  CW(str);
}
catch { CW("Вы ввели некорректное значение."); }
