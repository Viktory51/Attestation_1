// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] finish(string[] strings)
{
    string[] new_arr = new string[strings.Length];
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            new_arr[i] = strings[i];
        }
    }
    return new_arr;
}

void PrintArray(string[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
}

string[] strings = { "Hello", "world", "i", "am", "Viktory", "555", ":-)" };
PrintArray(strings);
Console.WriteLine();
PrintArray(finish(strings));



