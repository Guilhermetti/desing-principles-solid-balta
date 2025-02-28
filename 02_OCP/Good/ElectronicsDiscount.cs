namespace SOLID._02_OCP.Good
{
    public class ElectronicsDiscount : Discount
    {
        public override decimal Calculate(decimal price)
            => price * 0.1m;
    }
}
