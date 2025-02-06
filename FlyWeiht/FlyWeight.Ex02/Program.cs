namespace FlyWeight.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chessBoard = new ChessBoard();

            // Place pieces on the board
            chessBoard.PlacePiece("Pawn", "White", 1, 2);
            chessBoard.PlacePiece("Pawn", "White", 1, 3);
            chessBoard.PlacePiece("King", "Black", 7, 7);
            chessBoard.PlacePiece("Pawn", "White", 1, 4); // Reuses "Pawn_White"

            Console.WriteLine("\nDisplaying the chess board:");
            chessBoard.Display();
        }
    }
}
