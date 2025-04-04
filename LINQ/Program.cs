﻿static IEnumerable<int> Fibonacci()
{
    int current = 0;
    int next = 1;
    while (true)
    {
        yield return current;
        int oldCurrent = current;
        current = next;
        next = next + oldCurrent;
    }
}
static void Main()
{
    foreach (var value in Fibonacci())
    {
        Console.WriteLine(value);
        if (value > 1000)
        {
            break;
        }
    }
}