namespace SOLID._03_LSP._01_Example.Bad
{
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double Area() => Width * Height;
    }
}
