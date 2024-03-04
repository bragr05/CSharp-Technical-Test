using System.Text.RegularExpressions;
class WordCounter
{
    public static void Execution()
    {
        string text = "   un texto   que tiene    palabras            ";

        // Clean white spaces (start and end) | replace at least 1 or more spaces with regex (middle)

        text = Regex.Replace(text, @"\s+", " ").Trim();

        string[] textStrings = text.Split(' ');

        Console.WriteLine(textStrings.Length);
    }
}