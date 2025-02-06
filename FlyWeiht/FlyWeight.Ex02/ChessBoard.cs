namespace FlyWeight.Ex02
{
    // Client
    class ChessBoard
    {
        private readonly List<ChessPiece> _pieces = new List<ChessPiece>();
        private readonly ChessPieceFactory _pieceFactory = new ChessPieceFactory();

        public void PlacePiece(string name, string color, int x, int y)
        {
            var pieceType = _pieceFactory.GetPieceType(name, color);
            var piece = new ChessPiece(x, y, pieceType);
            _pieces.Add(piece);
        }

        public void Display()
        {
            foreach (var piece in _pieces)
            {
                piece.Display();
            }
        }
    }
}
