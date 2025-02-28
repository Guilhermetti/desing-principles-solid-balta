namespace SOLID._03_LSP._01_Example.Bad
{
    public class Quadrado : Retangulo
    {
        public override double Largura
        {
            set { base.Largura = base.Altura = value; }
        }

        public override double Altura
        {
            set { base.Largura = base.Altura = value; }
        }
    }
}
