namespace Task2
{
    internal class Program
    {
        delegate void MathFunctions(int x, int y);

        static void Main(string[] args)
        {
            MathFunctions function = (x, y) => Console.WriteLine($"Сумма {x} и {y} = {x + y}");
            function += (x, y) => Console.WriteLine($"Разность {x} и {y} = {x - y}");
            function += (x, y) => Console.WriteLine($"Произведение {x} и {y} = {x * y}");
            function += (x, y) => Console.WriteLine($"Частное {x} и {y} = {x / y}");

            function(13, 11);
        }
    }
}
