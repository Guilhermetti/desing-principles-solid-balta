namespace SOLID._03_LSP._01_Example.Good
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area() => Largura * Altura;
    }
}
