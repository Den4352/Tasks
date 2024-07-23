// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите натуральное число");

try
{
	UInt32 a = UInt32.Parse(Console.ReadLine());
	if (a % 2 == 1)
		Console.WriteLine("YES");
	else if (a >= 2 && a <= 5)
		Console.WriteLine("NO");
	else if (a >= 6 && a <= 20)
		Console.WriteLine("YES");
	else Console.WriteLine("NO");
}
catch
{
	Console.WriteLine("Введенные данные некорректны");
}	