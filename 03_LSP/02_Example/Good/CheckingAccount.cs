namespace SOLID._03_LSP._02_Example.Good
{
    public class CheckingAccount : BankAccount
    {
        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
