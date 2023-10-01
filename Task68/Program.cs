// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack (int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (n == 0) return Ack(m-1, 1);
        return Ack (m-1, Ack(m, n-1)); 
    }
}


int res = Ack(2, 3);
Console.WriteLine(res);