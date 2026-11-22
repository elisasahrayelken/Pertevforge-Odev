// yildiz

using System;

int girdi = int.Parse(Console.ReadLine());

for (int i = 0; i < girdi; i++)
{
    for (int bosluk = 0; bosluk < girdi - 1 - i; bosluk++)
    {
        Console.Write(" ");
    }

    for (int yildiz = 0; yildiz <= i; yildiz++)
    {
        Console.Write("*");
        Console.Write(" ");
    }

    Console.WriteLine();
}