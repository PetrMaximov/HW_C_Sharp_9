// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum = 0;
int SummNaturalNumbers(int M, int N)
{
    if (M < (N + 1)) 
    {
        Sum = M + SummNaturalNumbers(M + 1, N);
        return Sum; 
    }
    else return Sum;
}

int res = SummNaturalNumbers(4, 8);
Console.WriteLine(res);