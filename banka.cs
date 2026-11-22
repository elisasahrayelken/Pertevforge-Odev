// banka

using System;


int bakiye = 5000;

void paraYatirma(int yatirim)
{
    bakiye = bakiye+yatirim;

    Console.WriteLine($"bakiyeniz: {bakiye}");
}

void paraCekme(int cekme)
{
    bakiye = bakiye-cekme;

    Console.WriteLine($"bakiyeniz: {bakiye}");
}

void sorgu()
{
    Console.WriteLine($"bakiyeniz: {bakiye}");
}

Console.WriteLine("sorgu? cekme? yatirim?");
string islem = Console.ReadLine();

if (islem == "sorgu")
{
    sorgu();
}

else if (islem == "cekme")
{
    Console.WriteLine("çekilcek miktar?");
    int cekme = int.Parse(Console.ReadLine());
    paraCekme(cekme);
}

else if (islem == "yatirim")
{
    Console.WriteLine("yaritirilacak miktar?");
    int yatirim = int.Parse(Console.ReadLine());
    paraYatirma(yatirim);
}