class InvertString
{

    public static void Execution(string chain)
    {
        // SOLUTION 01
        /*
        string reverseString = "";
        for (int i = chain.Length - 1; i >= 0; i--)
        {
            reverseString += chain[i];
        }
        */

        // SOLUTION 02
        char[] charChain = chain.ToCharArray();
        // Reverse modify reference
        Array.Reverse(charChain);
        string reverseString = new string(charChain);
        Console.WriteLine(reverseString);
    }
}