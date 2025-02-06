namespace FlyWeight.Ex01
{
    // Flyweight Factory: Manages shared TreeType objects
    public class TreeFactory
    {
        private readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string color, string texture)
        {
            var key = $"{name}_{color}_{texture}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
                Console.WriteLine($"Creating a new TreeType: {key}");
            }
            return _treeTypes[key];
        }
    }

}
