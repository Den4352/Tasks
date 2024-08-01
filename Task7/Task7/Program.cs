// See https://aka.ms/new-console-template for more information

using System;

try
{
	Console.WriteLine("Введите число: ");
	string s = Console.ReadLine(); //Введенное число в string
	int num = Int32.Parse(s); //Введенное число в int
	if (num > 0 && num <= Math.Pow(10, 9) && s[s.Length-1] != '0') //Условия работы программы (натуральное число, меньше 10^9, не заканчивается на 0)
	{
		char[] str = s.ToCharArray(); //массив элементов введеного числа
		Array.Reverse(str); //реверс массива
		int numRevers = Int32.Parse(str); //реверс числа
		if (num == numRevers) //проверка числа с реверсом
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
	else
		Console.WriteLine("Ошибка ввода");
}
catch
{
	Console.WriteLine("Ошибка ввода");
}


