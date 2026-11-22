// asal

using System;
using System.Data;

int girdi = int.Parse(Console.ReadLine());

Console.WriteLine("İşte aradaki asallar:");

for (int i = 2; i <= girdi; i++)
{
    bool asalMi = true;

    for (int a = 2; a < i; a++)
    {
        if (i % a == 0)
        {
            asalMi = false;
            break;
        }
        
    }
   
   if (asalMi == true)
    {
        Console.WriteLine(i);
    }

}