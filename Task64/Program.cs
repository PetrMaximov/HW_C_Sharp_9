// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void PrintAllNumbers (int N)
{
    if (N == 1) 
    {
        Console.Write(N);
        return;
    }    
    Console.Write(N + ", " );
    PrintAllNumbers(N-1);
}

PrintAllNumbers(8);