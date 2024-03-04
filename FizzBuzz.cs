using System.Text;

class FizzBuzz
{
    public static void Execution()
    {
        // 'StringBuilder' Permite construir y manipular cadenas de manera eficiente, sin crear un nuevo objeto de cadena cada vez que se realiza una operación de concatenación 
        StringBuilder FizzBuzz = new StringBuilder();

        for (int i = 1; i <= 100; i++)
        {
            FizzBuzz.Append(
                    (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz " :
                    (i % 3 == 0) ? "Fizz " :
                    (i % 5 == 0) ? "Buzz " :
                    i.ToString() + " "
                );
        }

        Console.WriteLine(FizzBuzz);
    }
}