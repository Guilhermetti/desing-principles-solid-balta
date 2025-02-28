namespace SOLID._03_LSP._02_Example.Good
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public abstract void Withdraw(decimal amount);
    }
}
