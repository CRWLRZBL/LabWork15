namespace Task1
{
    internal class Task1
    {
        public delegate void MathDelegate(int x);

        public static int FactorialCounter(int y)
        {
            if (y < 0)
                return -1;

            if (y == 0)
                return 1;

            int result = 1;
            for (int i = 1; i < y + 1; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            MathDelegate actions = (x) => Console.WriteLine($"Квадрат числа {x} = {x * x}");
            actions += (x) => Console.WriteLine($"Факториал числа {x} = {FactorialCounter(x)}");
            actions += (x) => Console.WriteLine($"Модуль числа {x} = {Math.Abs(x)}");

            actions(8);
        }
    }
}
