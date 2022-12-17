using System.Linq.Expressions;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> listInt = new List<int>();
        do
        {
            var result = int.TryParse(ReadLine(), out var i);

            if (result)
            {
                listInt.Add(i);

                WriteLine("Количество элементов: "+listInt.Count);
                WriteLine("Сумма: "+listInt.Sum());
                WriteLine("Минимальное: " + listInt.Min());
                WriteLine("Максимальное: " + listInt.Max());
                WriteLine("Среднее: " + listInt.Average());
            }
            else
            {
                WriteLine("Неверный ввод");
                continue;
            }
        }
        while (true);
    }
}