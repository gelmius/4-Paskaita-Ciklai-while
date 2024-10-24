// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite amziu");
int amzius = int.Parse(Console.ReadLine());

switch (amzius)
{
    case int n when (n >= 0 && n <= 12):
        Console.WriteLine("Vaikas.");
        break;
    case int n when (n >= 13 && n <= 17):
        Console.WriteLine("Paauglys.");
        break;
    case int n when (n >= 18 && n <= 64):
        Console.WriteLine("Suauges.");
        break;
    case int n when (n >= 65):
        Console.WriteLine("Senjoras.");
        break;
    default:
        Console.WriteLine("Neteisingai ivestas amzius.");
        break;
}
