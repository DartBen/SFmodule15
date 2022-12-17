using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            var result = int.TryParse(Console.ReadLine(), out var i);

            if (result)
            {
                Console.WriteLine(Factorial(i));
            }
        }
        while (true) ;

    }

    static long Factorial(int number)
    {
        if (number == 1 || number == 0)
            return 1;
        else if (number < 0)
            return -1;
        else
        {
            var ints = new List<int>();
            for (int z = 1; z <= number; z++)
                ints.Add(z);

            long result = ints.Aggregate((x, y) => x * y);
            return result;
        }
    }
}