//Дан двумерный массив.
//7 3 2
//4 9 6
//1 8 5
//Отсортировать данные в нем по возрастанию.
//1 2 3
//4 5 6
//7 8 9
//Вывести результат на печать.

class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        for (int pos = 0; pos < a.Length - 1; pos++)
        {
            BubbleSort(a);
        }
        Print(a);
    }

    private static void BubbleSort(int[,] a)
    {
        int pos = 0;
        while (pos < a.Length - 1)
        {
            int row = pos / a.GetLength(0);
            int col = pos % a.GetLength(0);

            int newPos = pos + 1;
            int newRow = newPos / a.GetLength(0);
            int newCol = newPos % a.GetLength(0);

            if (a[row, col] > a[newRow, newCol])
            {
                int temp = a[row, col];
                a[row, col] = a[newRow, newCol];
                a[newRow, newCol] = temp;
            }
            ++pos;
        }
    }

    private static void Print(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
