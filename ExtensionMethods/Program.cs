using ExtensionMethods;

List<string> _extensions = new List<string>();
_extensions.Add("Nevim");
_extensions.Add("jaj");
_extensions.Add("pIco");
_extensions.Add("aU");
_extensions.Add("Passw0rD");

List<string> tonevim = _extensions.ShorterThan(4);
foreach (string extension in tonevim)
{
    Console.WriteLine(extension);
}
Console.WriteLine();

List<string> tonevim2 = _extensions.ContainsUpperLetter();
foreach (string extension in tonevim2)
{
    Console.WriteLine(extension);
}

Console.WriteLine();

foreach (string i in _extensions.Upper())
{
    Console.WriteLine(i);
}

Console.WriteLine();

foreach (string i in _extensions.SuitableAsPassword())
{
    Console.WriteLine(i);
}