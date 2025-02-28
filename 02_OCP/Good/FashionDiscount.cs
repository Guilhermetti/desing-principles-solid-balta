namespace SOLID._02_OCP.Good
{
    public class FashionDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.4m;
    }
}
