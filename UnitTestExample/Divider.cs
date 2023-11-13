namespace UnitTestExample
{
    public class Divider
    {
        //Add class - BankAccount(100)
        //Add method - Withdraw(double amount) return balance - amount
        //Add test - Withdraw(30) -> Balance = 70
        double Balance { get; set; }

        public Divider(double balance)
        {
            Balance = balance;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

    }
}
