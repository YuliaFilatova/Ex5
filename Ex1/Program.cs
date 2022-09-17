// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
GetArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int count = 0;

void GetArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;
{
    Console.WriteLine($"всего {array.Length} чисел в массиве, {count} из них чётные");
}