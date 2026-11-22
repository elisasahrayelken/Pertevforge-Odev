//taksimetre

using System;
using System.Diagnostics;

int mUcret = 30;
int bUcret = 120;

Console.WriteLine("mesafe gir km olsun:");
string mesafe = Console.ReadLine();

int yMesafe = int.Parse(mesafe);

int para = (mUcret*yMesafe) + bUcret;

Console.WriteLine($"ücret: {para}");
