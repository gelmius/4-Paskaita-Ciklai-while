// See https://aka.ms/new-console-template for more information
string slaptazodis = "123456", ivestas = "";
Console.WriteLine("Iveskite slaptazodi");
ivestas = Console.ReadLine();
while (ivestas != slaptazodis)
{
    Console.WriteLine("Slaptazodis neteisingas");
    Console.WriteLine("Iveskite slaptazodi");
    ivestas = Console.ReadLine();

}
Console.WriteLine("Slaptazodis teisingas");
