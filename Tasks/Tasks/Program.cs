// See https://aka.ms/new-console-template for more information

	Console.WriteLine("Напиши строку с x или w:");

	string a = Console.ReadLine();
	//int index = 0;
	if (a != null)
	{
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] == 'x' || a[i] == 'w')
			{
				Console.WriteLine(a[i]);
				break;
			}
			else if (i == a.Length -1)
				Console.WriteLine(-1);
		}
	}
	Console.ReadLine();