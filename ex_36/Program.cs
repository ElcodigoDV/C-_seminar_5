/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

int Sum(int[] array)
{
    // int len = array.Length;
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] ArrGenerate(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
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
int[] array = ArrGenerate(arrSize);
int sum = Sum(array);
Console.WriteLine($"[{String.Join(",", array)}] - > {sum}");