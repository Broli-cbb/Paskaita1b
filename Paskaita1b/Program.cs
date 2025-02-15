// Antros dalies, pirma uzduotis
// Vidutinio greicio ir keliones trukmes skaiciuokle
using System;


Console.WriteLine("Iveskite norima nuvaziuota atstuma");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Iveskite vidutini greiti");
double b = double.Parse(Console.ReadLine());

double kelionesTrukme = a / b;

Console.WriteLine("Keliones trukme:" + kelionesTrukme + " valandos");

//kintamoji galune

//antra uzduotis kuro sanaudu is islaidu skaiciuokle
//.00 hmmm

/*
using System;

Console.WriteLine("Iveskite sunaudojamo kuro kieki 100 kilometru:");
decimal a = decimal.Parse(Console.ReadLine());

Console.WriteLine("Iveskite nuvaziuota atstuma:");
decimal b = decimal.Parse(Console.ReadLine());
Console.WriteLine("Musu prielaida, kad kuras kainuoja 1e:");
decimal c = 1;
decimal sunaudotasKura = (b / 100) * a;
decimal kaina = (sunaudotasKura * a); 

Console.WriteLine("Sunaudotas kuras");

Console.WriteLine(sunaudotasKura);

Console.WriteLine("Keliones kaina");
Console.WriteLine(kaina);
*/






