for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - UthyoBasyo");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Uthyo");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Basyo");
    else
        Console.WriteLine($"{i}");
}