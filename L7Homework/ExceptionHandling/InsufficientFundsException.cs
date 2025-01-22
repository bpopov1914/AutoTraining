namespace L7Homework;

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}