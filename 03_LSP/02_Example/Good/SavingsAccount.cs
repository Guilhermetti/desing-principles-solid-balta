namespace SOLID._03_LSP._02_Example.Good
{
    public class SavingsAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
