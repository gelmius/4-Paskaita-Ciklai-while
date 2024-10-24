// See https://aka.ms/new-console-template for more information
Console.WriteLine(" 1 – pirmadienis, 2 – antradienis, 3 - treciadienis, 4 - ketvirtadienis 5 - penktadienis, 6 - sestadienis, 7 - sekmadienis");
Console.WriteLine("Pasirinkite savaites diena");
int diena = int.Parse(Console.ReadLine());

while(diena > 7 && diena < 1)
{
    Console.WriteLine("Netinkamas skaičius, bandykite dar kartą“");
    diena = int.Parse(Console.ReadLine());
}

switch (diena)
{
    case 1:
        Console.WriteLine("pirmadienis.");
        break;
    case 2:
        Console.WriteLine("antradienis.");
        break;
    case 3:
        Console.WriteLine("treciadienis.");
        break;
    case 4:
        Console.WriteLine("ketvirtadienis.");
        break;
    case 5:
        Console.WriteLine("penktadienis.");
        break;
    case 6:
        Console.WriteLine("sestadienis.");
        break;
    case 7:
        Console.WriteLine("sekmadienis.");
        break;
}

