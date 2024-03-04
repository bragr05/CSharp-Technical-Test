class countRepeatCharacter
{
    public static void Execution()
    {
        string chain = "AAA-BBB-CCC";
        char search = 'A';
        int repeatCount = 0;

        //SOLUTION 01
        /*
        for (int i = 0; i <= chain.Length - 1; i++)
        {
            if (search == chain[i])
            {
                repeatCount++;
            }
        }
        */

        //SOLUTION 02
        repeatCount = chain.Where(c => c == search).Count();
        Console.WriteLine(repeatCount);
    }
}