class hammingDistance
{

    public static void Execution()
    {
        string chain01 = "HolaQueTalGoes";
        string chain02 = "HolaQueTalDias";
        int distance = 0;

        if (chain01.Length != chain02.Length)
        {
            Console.WriteLine("The strings are different");
            return;
        }

        // Solution 01
        /*
        for (int i = 0; i <= chain01.Length - 1; i++)
        {
            if (chain01[i] != chain02[i])
            {
                distance++;
            }
        }
        */

        // Solution 02
        distance = chain01.Where((c, Index) => c != chain02[Index]).Count();

        Console.WriteLine(distance);
    }
}