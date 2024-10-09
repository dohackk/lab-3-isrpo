internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество столбцов (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество строк (m): ");
        int m = Convert.ToInt32(Console.ReadLine());

        // Ввод матрицы построчно
        Console.WriteLine("Введите элементы матрицы по столбцам:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Вывод матрицы по столбцам
        Console.WriteLine("Матрица по столбцам:");
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}