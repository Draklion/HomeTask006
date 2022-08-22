try
{
  void CW(string msg)
  {
    Console.WriteLine(msg);
  }
  string CR()
  {
    return Console.ReadLine();
  }

  void existenceTriangle(double[] array, out string msg)
  {
    msg = array[0] > array[1] + array[2] ||
          array[1] > array[0] + array[2] ||
          array[2] > array[0] + array[1] ? "Треугольник не существует" : "Треугольник существует";
  }


  double[] sides = new double[3];
  string str = "";
  for (int i = 0; i < sides.Length; i++)
    sides[i] = Int32.Parse(CR());
  existenceTriangle(sides, out str);
  CW(str);
}
catch { CW("Вы ввели некорректное значение."); }
