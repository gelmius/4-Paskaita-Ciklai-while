// See https://aka.ms/new-console-template for more information


Console.WriteLine("iveskite kelis skaicius");
int x = int.Parse(Console.ReadLine());
int suma = int.Parse(Console.ReadLine()) + x;

while(suma < 100)
{
    Console.WriteLine("Tęskite įvedimą");
    suma = int.Parse(Console.ReadLine()) + suma;
}

Console.WriteLine("Suma viršyta");
