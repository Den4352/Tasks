// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] array = {3, 4, 5, 6, 98, 79, 233, 434, 423, 3, 44, 56};
for (int i = 0; i < array.Length; i++)
{
	Console.Write(array[i] + " ");
}
Console.WriteLine();
int t;
for (int i = 0; i < array.Length; i++)
{
	for (int j = 0; j < array.Length - 1 - i; j++)
	{
		if (array[j] > array[j+1])
		{

			t = array[j];
			array[j] = array[j+1];
			array[j + 1] = t;
		}
	}
}
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < array.Length; i++)
{
	Console.Write(array[i] + " ");
}