using Solsys;

var bolygok = new List<Bolygo>();
using var sr = new StreamReader(@"..\..\..\src\solsys.txt");
while (!sr.EndOfStream) bolygok.Add(new Bolygo(sr.ReadLine()));

Console.WriteLine("3.feladat: ");
Console.WriteLine($"\t3.1: {bolygok.Count} bolygó van a naprendszeben");

var atlagholdak = bolygok.Average(b => b.HoldSzam);
Console.WriteLine($"\t3.2: A naprendszerben egy bolygónak átlagosan {atlagholdak} holdja van");

var legnagyobbbolygo = bolygok.Where(b => b.TerfogatArany == bolygok.Max(m => m.TerfogatArany)).First();
Console.WriteLine($"\t3.3: A legnagyobb térfogatú bolygó a {legnagyobbbolygo.Nev}");

Console.Write("\t3.4: Írd be a keresett bolygó nevét: ");
string keresettbolygo = Console.ReadLine().ToLower();
bool vane = false;
for (int i = 0; i < bolygok.Count; i++)
{
	if (bolygok[i].Nev.ToLower() == keresettbolygo)
	{
		vane = true;
	}
}
if (vane)
{
    Console.WriteLine("\t\tvan ilyen bolygó");
}
else
{
    Console.WriteLine("\t\tNincs ilyen bolygó a naprendszerben");
}

Console.Write("\t3.5 Írj be egy egész számot: ");
int bekertszam = int.Parse(Console.ReadLine());
Console.WriteLine($"\t\tA következő bolygónak van {bekertszam}-nál/nél több holdja:\t");
var tobbhold = bolygok.Where(b => b.HoldSzam > bekertszam);
Console.Write("[");
foreach (var item in tobbhold)
{
    Console.Write($"'{item.Nev}', ");
}
Console.Write("]");