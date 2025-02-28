namespace SOLID._03_LSP._01_Example.Good
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area() => Side * Side;
    }
}
