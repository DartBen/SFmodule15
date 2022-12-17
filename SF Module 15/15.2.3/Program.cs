internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    static double Average(int[] numbers)
    {
        double avarage = (double)numbers.Sum()/numbers.Length;

        return avarage;
    }
}