using System.Text.RegularExpressions;

class numberCounter
{
    public static void Execution()
    {
        string text = "26558??dwdq12312431ªªªºººewdew";

        string pattern = @"[0-9]";
        var regex = new Regex(pattern);

        int numberCounter = regex.Matches(text).Count();

        Console.WriteLine(numberCounter);
    }
}