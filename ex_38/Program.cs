/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

//макс считаем разницу МАКС - МИН

void PrintDifference (int max, int min, int [] array)
{
	int difference = max - min;
	Console.WriteLine($"[{String.Join(",", array)}] -> {difference}");
}

// ищем мин
int Min (int [] array)
{
	int min = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < min)
		{
			min = array [i];
		}
	}
	return min;
}

//ищем макс
int Max (int [] array)
{
	int max = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array [i];
		}
	}
	return max;
}

//заполняем массив элементами
int [] NewArray (int n)
{
	int [] array = new int [n];
	for (int i = 0; i < n; i++)
	{
		array [i] = new Random().Next(0,100);
	}
	return array;
}

//задаем массив размер
int GetSize (string text)
{
	Console.WriteLine(text);
	int size = Int32.Parse(Console.ReadLine());
	return size;
}

int size = GetSize("Задайте размер массива");
int [] arr = NewArray (size);
int maximum = Max(arr);
int minimum = Min(arr);
PrintDifference(maximum, minimum, arr);