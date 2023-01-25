using ExtensionMethods;

List<string> _extensions = new List<string>();
_extensions.Add("nevim");
_extensions.Add("jaj");
_extensions.Add("pico");
_extensions.Add("au");

List<string> tonevim = _extensions.ShorterThan(4);
foreach (string extension in tonevim)
{
    Console.WriteLine(extension);
}