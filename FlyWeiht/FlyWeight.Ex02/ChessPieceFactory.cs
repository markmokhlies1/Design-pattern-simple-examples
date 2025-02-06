namespace FlyWeight.Ex02
{
    // Flyweight Factory: Manages shared ChessPieceType objects
    public class ChessPieceFactory
    {
        private readonly Dictionary<string, ChessPieceType> _pieceTypes = new Dictionary<string, ChessPieceType>();

        public ChessPieceType GetPieceType(string name, string color)
        {
            var key = $"{name}_{color}";

            if (!_pieceTypes.ContainsKey(key))
            {
                _pieceTypes[key] = new ChessPieceType(name, color);
                Console.WriteLine($"Creating a new ChessPieceType: {key}");
            }
            return _pieceTypes[key];
        }
    }
}
