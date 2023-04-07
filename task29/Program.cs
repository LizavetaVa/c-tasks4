// Задача 29: Напишите программу, которая приниматет на вход длину массива, 
// минимальное значение массива и максимальное значение массива, 
//создаёт массив с заданными параметрами и выводит значения на экран
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите длину массива: ");
int arrayLength = GetIntInput();
Console.WriteLine("Введите минимальное значение массива: ");
int minValue = GetIntInput();
Console.WriteLine("Введите максимальное значение массива: ");
int maxValue = GetIntInput();

int[] array = new int[arrayLength];
FillArray(array, minValue, maxValue);
PrintArray(array);


int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void FillArray(int[] collection, int a, int b)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(a, b + 1);
    }
 
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    Console.Write("[");
    while (position < count - 1)
    {
        Console.Write($"{coll[position]}, ");
        position++;
    }
    Console.Write($"{coll[position]}");
    Console.Write("]");
}
 