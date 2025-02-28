namespace SOLID._03_LSP._02_Example.Bad
{
    public class BankAccount
    {
        public virtual void Withdraw(decimal amount)
        {
            Console.WriteLine($"Withdrew {amount:C} from bank account.");
        }
    }
}
