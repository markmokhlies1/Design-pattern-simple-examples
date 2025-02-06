using Bridge.Ex.Implemention;

namespace Bridge.Ex.Abstraction
{
    // Refined Abstraction: Circle
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(IRenderer renderer, double radius) : base(renderer)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            _renderer.RenderCircle(_radius);
        }
    }

}
