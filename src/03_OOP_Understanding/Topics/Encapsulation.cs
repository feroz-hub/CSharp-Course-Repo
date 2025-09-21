namespace OOP.Understanding.Topics;

// Topic 02: Encapsulation
// Definition: Bundle data and behavior, and hide internal details through access modifiers and properties.
public static class Encapsulation
{
    public static void Run()
    {
        var account = new BankAccount("Ava", initialBalance: 100m);
        account.Deposit(50m);
        var ok = account.Withdraw(120m);
        Console.WriteLine($"Withdraw success? {ok}; Balance = {account.Balance}");
        // The following would not compile if fields were private (as intended):
        // account._balance = -999m;
    }

    public class BankAccount
    {
        // private field hidden from outside
        private decimal _balance;

        // public read-only property; mutation via methods only
        public decimal Balance => _balance;
        public string Owner { get; }

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            if (initialBalance < 0) throw new ArgumentOutOfRangeException(nameof(initialBalance));
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0) return false;
            if (amount > _balance) return false;
            _balance -= amount;
            return true;
        }
    }
}
