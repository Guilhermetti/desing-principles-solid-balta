namespace SOLID._03_LSP._01_Example.Good
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override double Area() => Lado * Lado;
    }
}
