// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite varda");
string vardas = Console.ReadLine();

while(vardas.Length < 4)
{
    Console.WriteLine("Vardas pertrumpas, bandykite dar karta");
    vardas = Console.ReadLine();
}
