namespace SOLID._02_OCP.Good
{
    public class HealthDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.2m;
    }
}
