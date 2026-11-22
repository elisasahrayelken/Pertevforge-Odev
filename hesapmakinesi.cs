// hesap makinesi

using System;
using System.Data;
using System.Diagnostics;

Console.WriteLine("ilk sayi?");
string saYi1 = Console.ReadLine();
int sayi1 = int.Parse(saYi1);

Console.WriteLine("ikinci sayi?");
string saYi2 = Console.ReadLine();
int sayi2 = int.Parse(saYi2);

Console.WriteLine("olay nedir? (+ - * veya / yazcan)");
string operasyon = Console.ReadLine();

if (operasyon=="+")
{
    Console.WriteLine($"sonuç: {sayi1+sayi2}");
}

else if (operasyon=="-")
{
    Console.WriteLine($"sonuç: {sayi1-sayi2}");
}

else if (operasyon=="*")
{
    Console.WriteLine($"sonuç: {sayi1*sayi2}");
}

else if (operasyon=="/")
{
    Console.WriteLine($"sonuç: {sayi1/sayi2}");
}