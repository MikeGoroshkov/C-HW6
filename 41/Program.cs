/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] arr = InputArray(5);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(CountPositiveNums(arr));

int[] InputArray(int countNumbers)
{
    int[] array = new int[countNumbers];
    for (int i = 0; i < countNumbers; i++)
    {
        Console.WriteLine($"Введите число №{i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CountPositiveNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}