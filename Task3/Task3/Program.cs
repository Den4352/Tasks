// See https://aka.ms/new-console-template for more information
//int a = Int32.Parse(Console.ReadLine());
List<int> b = new List<int>();

int n = -1;
int max = -1;
int s_max = -1;

while (n != 0)
{
	n = Int32.Parse(Console.ReadLine());
	b.Add(n);
	if (n <= 0 || n > 1000)
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
		Console.WriteLine(s_max);
	}
}
if(b.Count < 2)
{
	Console.WriteLine("Элементов меньше 2");
}


