namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            BankAccount account = new BankAccount();
            account.Deposit(300);
            Console.WriteLine(account.GetBalance());


        }
    }
}
