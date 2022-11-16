/*
Задача 41: Пользователь вводит с клавиатуры М чисел. 
Посчитайте сколько чисел больше 0 ввел пользователь 
0, 7, 8, -2, -3 -> 2
1, -7, 567, 89, 223 ->4
*/

int[] InitialArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Enter {i+1}-number");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int positiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveNumbers++;
    }
    return positiveNumbers;
}

Console.WriteLine("Enter the length array");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = InitialArray(m);
PrintArray(array);
int positiveNumbers = PositiveNumbers(array);
Console.WriteLine($"positive numbers: {positiveNumbers}");



