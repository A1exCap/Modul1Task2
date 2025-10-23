namespace Modul1Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[5,5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Array[i, j] = rand.Next(-100, 101);
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[] rowsSum = new int[5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                   if (Array[i,j] > 0)
                   rowsSum[i] += Array[i, j];
                }
            }

            Console.WriteLine();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sum of rows {i + 1}: {rowsSum[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(rowsSum.Max());
        }
    }
}
