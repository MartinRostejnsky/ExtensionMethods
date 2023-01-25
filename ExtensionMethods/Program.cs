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
int jafaktnevim = 255;

Console.WriteLine(jafaktnevim.AsHex());

List<int> ints= new List<int>();
ints.Add(jafaktnevim);
ints.Add(54);
ints.Add(12);
ints.Add(27);

foreach (int i in (ints.Process(x => (x * 2))))
{
Console.WriteLine(i);
}

foreach (int i in (ints.Condition(x => x > 27)))
{
    Console.WriteLine(i);
}