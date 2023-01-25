using ExtensionMethods;

List<string> _extensions = new List<string>();
_extensions.Add("Nevim");
_extensions.Add("jaj");
_extensions.Add("pIco");
_extensions.Add("aU");

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