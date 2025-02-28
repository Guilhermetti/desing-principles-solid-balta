namespace SOLID._03_LSP._01_Example.Bad
{
    public class Square : Rectangle
    {
        public override double Width
        {
            set { base.Width = base.Height = value; }
        }

        public override double Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
