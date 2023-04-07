// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int inputInt = GetIntInput();

Console.WriteLine($"Сумма цифр числа {inputInt} равна: " + AmountOfDigits(inputInt));



int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int AmountOfDigits(int a)
{
    int sum = 0;
    int b = 0;

    while (a >= 10)
    {
        b = a % 10;
        sum += b;
        a /= 10;
    }

    if (a < 10)
    {
        sum += a;
    }
    return sum;

}