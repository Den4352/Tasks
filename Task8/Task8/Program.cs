// See https://aka.ms/new-console-template for more information
try
{
	Console.WriteLine("Введите количество проверяемых чисел N: ");
	int num = Int32.Parse(Console.ReadLine());
	if (num > 0 && num <= Math.Pow(10, 5))
	{
		int kol=0; //количество
		for (int i = 0; i < num; i++)
		{
			Console.WriteLine("Введите число для проверки: ");
			int a = Int32.Parse(Console.ReadLine());
			if (a <= 2 * Math.Pow(10, 6))
			{
				if (a % 10 == 0)
				{
					kol += 1;
				}
			}
			else
				Console.WriteLine("Неверно задано число, возможно оно больше 2*10^6");
		}

		Console.WriteLine("Количество чисел заканчивающихся на 0: " + kol);
	}
	else
	{
		Console.WriteLine("Ошибка ввода");
	}
}
catch
{
	Console.WriteLine("Ошибка ввода");
}
