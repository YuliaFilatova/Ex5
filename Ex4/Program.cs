// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] GetArray(int size)
{
    var array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
int[] Metod(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] newArray = new int[array.Length / 2];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
        }
        return newArray;
    }
    else
    {
        int[] newArray = new int[array.Length / 2 + 1];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i] * array[array.Length - i - 1];
            
        }
        return newArray;
    }
    
}
    
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    return;
}
try
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = GetArray(size);
    Console.WriteLine("Старый массив: ");
    PrintArray(array);
    Console.WriteLine();
    int[] newArray = Metod(array);
    Console.WriteLine("Новый массив: ");
    PrintArray(newArray);
}
catch
{
    Console.WriteLine("Ошибка: не верно введены данные");
}


