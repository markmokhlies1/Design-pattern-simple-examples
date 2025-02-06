namespace FlyWeight.Ex01
{
    // Context: Represents a tree with unique position (extrinsic state)
    public class Tree
    {
        private readonly TreeType _treeType;
        private readonly int _x;
        private readonly int _y;

        public Tree(int x, int y, TreeType treeType)
        {
            _x = x;
            _y = y;
            _treeType = treeType;
        }

        public void Draw()
        {
            _treeType.Draw(_x, _y);
        }
    }

}
