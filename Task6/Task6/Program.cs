// See https://aka.ms/new-console-template for more information
try
{
	Console.WriteLine("Введите координаты коня");
	Console.Write("x:");
	int horse_x = Int32.Parse(Console.ReadLine());
	Console.Write("y:");
	int horse_y = Int32.Parse(Console.ReadLine());
	Console.WriteLine("Введите координаты фигуры, которую надо бить");
	Console.Write("x:");
	int victim_x = Int32.Parse(Console.ReadLine());
	Console.Write("y:");
	int victim_y = Int32.Parse(Console.ReadLine());
	if ((horse_x >= 0 && horse_x <= 8) || (horse_y >= 0 && horse_y <= 8) || (victim_x >= 0 && victim_x <= 8) || (victim_y >= 0 && victim_y <= 8))
	{
		if ((Math.Abs(horse_x - victim_x)) == 1 && (Math.Abs(horse_y - victim_y)) == 2)
			Console.WriteLine("YES");
		else if((Math.Abs(horse_x - victim_x)) == 2 && (Math.Abs(horse_y - victim_y)) == 1)
			Console.WriteLine("YES");
		else
			Console.WriteLine("NO");
	}
	else
	{
		Console.WriteLine("Ах ты хитрая жопа, координаты неправильные");
	}
}
catch
{
	Console.WriteLine("Ах ты хитрая жопа, координаты неправильные");
}