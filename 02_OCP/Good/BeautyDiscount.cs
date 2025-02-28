namespace SOLID._02_OCP.Good
{
    public class BeautyDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.3m;
    }
}
