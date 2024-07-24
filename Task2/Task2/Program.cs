// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System;

Console.WriteLine("Введите число a");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Int32.Parse(Console.ReadLine());
if (a <= b)
{
  if (Math.Abs(a) <= 20000 && Math.Abs(b) <= 20000)
  {
		List<int> arr = new List<int>(); 
    for (int i = a; i <= b; i++)
    {
      if (i % 7 == 0)
      {
        arr.Add(i);
      }
    }
    if (arr.Count >0)
    {
			int maxI = arr.Max();
			Console.WriteLine("Максимальное число кратное 7 на отрезке " + a + " и " + b + " = " + maxI);
		}
    else
			Console.WriteLine("NO");
	}
  else
    Console.WriteLine("Одно из чисел больше 2*10^4 по модулю");
}
else
{
  Console.WriteLine(a + " больше " + b);
}