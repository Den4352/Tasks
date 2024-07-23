// See https://aka.ms/new-console-template for more information
//int a = Int32.Parse(Console.ReadLine());
List<int> b = new List<int>();

int n = -1;
int max = -1;
int s_max = -1;
n = Int32.Parse(Console.ReadLine());

while (n != 0)
{
	b.Add(n);
	if (n < 0 || n > 1000)
	{
		Console.WriteLine("Ошибка ввода");
		break;
	}
	else
	{
		if (max <= n)
		{
			s_max = max;
			max = n;

		}
		else if (s_max < n)
		{
			s_max = n;
		}
		
	}
	n = Int32.Parse(Console.ReadLine());
}

if (b.Count < 3)
{
	Console.WriteLine("Элементов меньше 2");
}
Console.WriteLine(s_max);
Console.ReadLine();