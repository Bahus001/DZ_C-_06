// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] array = new int[5];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int GreaterZero(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) 
        res ++;
    }
    return res;
}

FillArray(array); 
PrintArray(array);
int result = GreaterZero(array);
Console.Write($" -> {result}");