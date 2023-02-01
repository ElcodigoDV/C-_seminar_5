/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int Count (int [] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		{
		if (array [i] % 2 == 0)
			{
			count ++;	
			}
		}
	return count;	
}

int [] ArrGenerate (int size)
{
	int [] array = new int [size];
	for (int i = 0; i < size; i++)
		{
			array[i] = new Random().Next(100,1000);
		}
	return array;
}

int ArraySize(string text)
{
	Console.WriteLine(text);
	int size = Int32.Parse(Console.ReadLine());
	return size;
}

int arrSize = ArraySize("Insert size of the array");
int [] array = ArrGenerate (arrSize);
int count = Count (array);
Console.WriteLine($"[{String.Join(",", array)}] - > {count}");
