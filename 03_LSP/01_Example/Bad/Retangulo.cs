namespace SOLID._03_LSP._01_Example.Bad
{
    public class Retangulo
    {
        public virtual double Largura { get; set; }
        public virtual double Altura { get; set; }

        public double Area() => Largura * Altura;
    }
}
