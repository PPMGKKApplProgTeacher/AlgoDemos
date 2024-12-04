

internal class NthQueenSolver
{
    private static void Main(string[] args)
    {
        // init

        // Number of queens and dimentions
        int n = 8;
        string[,] board = new string[n, n];
        // Queen logo
        string queen = "\u2655";

        // Execute
        PlaceQueens(board, 0, queen);
    }

    private static void PlaceQueens(string[,] board, int row, string queen)
    {
        if (row == board.GetLength(0))
        {
            Console.WriteLine("Solution: ");
            PrintBoard(board);
            return;
        }
        for (int i = 0; i < board.GetLength(1); i++)
        {
            if ( CanPlace(board, row, i, queen) ) {

                // Place the queen
                board[row, i] = queen;

                // Recursively place queens in the next row
                PlaceQueens(board, row + 1, queen);

                // Backtrack: Remove the queen
                board[row, i] = null;
            }
        }
    }

    private static bool CanPlace(string[,] board, int row, int col, string queen)
    {
        bool output = true;

        // Check Column Above
        for (int i = 0; i < row; i++)
        {
            if (board[i, col] == queen)
            {
                output =  false;
            }
        }
        // Check top-left diagonal
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j-- )
        {
            if (board[i, j] == queen)
            {
                output = false;
            }
        }
        // Check top-right diagonal
        for( int i = row - 1, j = col + 1; i >= 0 && j <= board.GetLength(1)-1; i--, j++)
        {
            if (board[i, j] == queen)
            {
                output = false;
            }
        }
        return output;
    }

    public static void PrintBoard(string[,] board)
    {
        // Make sure the queens can be shown as queens
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write( ( board[i, j] ?? "-" )  + " ");
            }
            Console.WriteLine();
        }
    }

}
