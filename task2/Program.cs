// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int start, int finish)
{
    if (start == 0 && finish == 0)
    {
        return 0;
    }
    else if (start == finish)
    {
        return start;
    }
    else if (start > finish)
    {
        return -1;
    }
    return start + SumNumbers(start + 1, finish);
}

System.Console.Write(SumNumbers(1, 3));
