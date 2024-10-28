internal class Program
{
    static int rows = 5;
    static int cols = 5;
    static int totalMines = 5;
    static char[,] field = new char[rows, cols];
    static bool[,] mines = new bool[rows, cols];
    static bool gameOver = false;

    private static void Main(string[] args)
    {
        Random random = new Random();
        int minesPlaced = 0;
        int count = 0;

        Console.WriteLine("Willkommen zu Minesweeper!");
        Console.WriteLine("Es gibt " + totalMines + " Minen im Feld.");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                field[i, j] = '-';
            }
        }

        while (minesPlaced < totalMines)
        {
            int row = random.Next(rows);
            int col = random.Next(cols);

            if (!mines[row, col])
            {
                mines[row, col] = true;
                minesPlaced++;
            }
        }
        Console.WriteLine("   1 2 3 4 5");
        Console.WriteLine("  +---------");

        for (int i = 0; i < rows; i++)
        {
            Console.Write((i + 1) + " |");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(" " + field[i, j]);
            }
            Console.WriteLine();
        }

        while (!gameOver)
        {
            Console.Write("Wähle eine Zeile (1-" + rows + "): ");
            int row = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Wähle eine Spalte (1-" + cols + "): ");
            int col = int.Parse(Console.ReadLine()) - 1;

            if (mines[row, col])
            {
                Console.WriteLine("BOOM! Du hast eine Mine getroffen!");
                gameOver = true;
            }
            else
            {

                for (int i = Math.Max(0, row - 1); i <= Math.Min(rows - 1, row + 1); i++)
                {
                    for (int j = Math.Max(0, col - 1); j <= Math.Min(cols - 1, col + 1); j++)
                    {
                        if (mines[i, j])
                        {
                            count++;
                        }
                    }
                }

                field[row, col] = count.ToString()[0];
                Console.WriteLine("   1 2 3 4 5");
                Console.WriteLine("  +---------");

                for (int i = 0; i < rows; i++)
                {
                    Console.Write((i + 1) + " |");
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(" " + field[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}