// SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int inputInt = GetIntInput();

Console.WriteLine("Введите число B");
int inputInt2 = GetIntInput();

int c = Multiply(inputInt, inputInt2);
Console.WriteLine(c);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}


int Multiply(int a, int b)
{
    int mltp = 1;
    for(int i = 1; i <= b; i++)
    {
        mltp = mltp * a;
    }
    return mltp;
}
