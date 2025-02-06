using Bridge.Ex.Implemention;

namespace Bridge.Ex.Abstraction
{
    // Refined Abstraction: Rectangle
    public class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(IRenderer renderer, double width, double height) : base(renderer)
        {
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            _renderer.RenderRectangle(_width, _height);
        }
    }

}
