namespace FlyWeight.Ex01
{
    // Client
    class Forest
    {
        private readonly List<Tree> _trees = new List<Tree>();
        private readonly TreeFactory _treeFactory = new TreeFactory();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            var treeType = _treeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, treeType);
            _trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in _trees)
            {
                tree.Draw();
            }
        }
    }

}
