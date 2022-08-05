// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSumDigit(int num)
{
    int result = 0;
    for (int i = 0; num > 0; i++)
    {
        int first = num % 10;
        num = num / 10;
        result = result + first;
    }
    return result;
}

int res = GetSumDigit(number);
Console.WriteLine($"{number} -> {res}");