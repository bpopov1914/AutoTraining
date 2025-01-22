namespace L7Homework;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message)
        : base(message)
    {
    }

}