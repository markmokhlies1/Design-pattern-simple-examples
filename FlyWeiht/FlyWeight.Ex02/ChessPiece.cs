namespace FlyWeight.Ex02
{
    // Context: Represents a chess piece's position (extrinsic state)
    public class ChessPiece
    {
        private readonly ChessPieceType _pieceType;
        private readonly int _x;
        private readonly int _y;

        public ChessPiece(int x, int y, ChessPieceType pieceType)
        {
            _x = x;
            _y = y;
            _pieceType = pieceType;
        }

        public void Display()
        {
            _pieceType.Display(_x, _y);
        }
    }
}
