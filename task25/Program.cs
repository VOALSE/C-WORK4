// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

Console.Clear();

Console.Write("Введите число для возведения в степень: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int second = Convert.ToInt32(Console.ReadLine());

int GetExpDigit(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

int result = GetExpDigit(first, second);
Console.WriteLine($"Число {first} в {second} степени = {result}");