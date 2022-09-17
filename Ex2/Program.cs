// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
GetArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
PrintArray(array);
int sum = 0;

void GetArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
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
for (int i = 0; i < array.Length; i+=2)
{
    sum = sum + array[i];
}
Console.WriteLine($"всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");
