<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


public class Program
{
	public static void Main()
	{
		var account = new Account(1000);
        var tasks = new Task[100];
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() => RandomlyUpdate(account));
        }
        Task.WaitAll(tasks);
		
        Console.ReadLine();
	}
}
static void RandomlyUpdate(Account account)
    {
        var rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            var amount = rnd.Next(1, 100);
            bool doCredit = rnd.NextDouble() < 0.5;
            if (doCredit)
            {
                account.Credit(amount);
            }
            else
            {
                account.Debit(amount);
            }
        }
    }
public class Account
{
    private readonly object balanceLock = new object();
    private decimal balance;

    public Account(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal Debit(decimal amount)
    {
        lock (balanceLock)
        {
            if (balance >= amount)
            {
                Console.WriteLine("Balance before debit :" + balance);
                Console.WriteLine("Amount to remove     :" + amount);
                balance = balance - amount;
                Console.WriteLine("Balance after debit  :"+ balance);
                return amount;
            }
            else
            {
                return 0;
            }
        }
    }

    public void Credit(decimal amount)
    {
        lock (balanceLock)
        {
			Console.WriteLine("Balance before credit: {0} ", balance);
            //Console.WriteLine("Balance before credit:"+ balance);
            Console.WriteLine("Amount to add        :"+ amount);
            balance = balance + amount;
            Console.WriteLine("Balance after credit :"+balance);
        }
    }
}