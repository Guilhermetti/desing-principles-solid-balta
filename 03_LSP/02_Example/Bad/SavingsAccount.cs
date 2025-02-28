namespace SOLID._03_LSP._02_Example.Bad
{
    public class SavingsAccount : BankAccount
    {
        public decimal Balance { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
                throw new InsufficientFundsException();

            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from savings account. Remaining balance: {Balance:C}");
        }
    }
}
