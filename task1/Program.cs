// Задача 1: Задайте значения M и N. Напишите программу, которая
//  выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }

    if (start % 2 == 0 && start > 0)
    {
        System.Console.Write(start + " ");
    }
    ShowNumbers(start + 1, finish);
}

ShowNumbers(5, 10);