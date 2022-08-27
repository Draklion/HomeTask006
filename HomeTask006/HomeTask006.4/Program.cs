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
  CW("Задание 4. Программа, которая находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
  CW("Введите значения b1, k1, b2, k2: ");
  string intersectionPoint = "";
  double[] coefficients = new double[4];

  for (int i = 0; i < coefficients.Length; i++) coefficients[i] = Int32.Parse(CR());

  CW(Сalculator(coefficients, out intersectionPoint));

  string Сalculator(double[] array, out string intersectionPoint)
  {
    double x = 0, y = 0;

    intersectionPoint = "";
    x = (array[2] - array[0]) / (array[1] - array[3]);
    y = array[1] * x + array[0];
    intersectionPoint = $"Точка пересечения двух прямых A({x},{y}).";
    return intersectionPoint;
  }
}
catch (InvalidCastException e) { }
