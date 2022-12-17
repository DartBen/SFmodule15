internal class Program
{
    private static void Main(string[] args)
    {
        string str1 = "agfgjkag";
        string str2 = "ldklmja";


        var result = str1.Intersect(str2);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }



    }
}