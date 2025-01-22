namespace L7Homework;

public class BankAccount
{
    private string _accountNumber;
    private decimal _balance;

    public BankAccount(string accountNumber, decimal balance)
    {
        _accountNumber = accountNumber;
        _balance = balance;
    }
    public string AccountNumber
    {
        get{return _accountNumber;}
        set{_accountNumber = value;}
    }

    public decimal Balance
    {
        get{return _balance;}
        set{_balance = value;}
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        try
        {
            if (_balance < amount)
            {
                throw new InsufficientFundsException("Insufficient funds.");
            }

            _balance -= amount;
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }
}