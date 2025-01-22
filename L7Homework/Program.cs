namespace L7Homework;

class Program
{
    static void Main(string[] args)
    {
        ExceptionHandlingUtils exceptionUtils = new ExceptionHandlingUtils();
        //Task 1
        Product productOne = new Product();
        Product productTwo = new Product("Product Two", 49.99m, 5);
        
        decimal productOneTotalCost = productOne.CalculateTotalCost();
        decimal productTwoTotalCost = productTwo.CalculateTotalCost();
        Console.WriteLine("Product One Total Cost: " + productOneTotalCost);
        Console.WriteLine("Product Two Total Cost: " + productTwoTotalCost);
        
        //Task 2
        BankAccount bankAccount = new BankAccount("150 150 150 150", 100.00m);
        Console.WriteLine("Bank Account Balance: " + bankAccount.Balance);
        bankAccount.Deposit(100.00m);
        Console.WriteLine("Bank Account Balance: " + bankAccount.Balance);
        bankAccount.Withdraw(150.00m);
        Console.WriteLine("Bank Account Balance: " + bankAccount.Balance);
        bankAccount.Withdraw(150.00m); //This throws InsufficientFundsException
        
        //Task 3
        Console.WriteLine("Please input divident: ");
        bool canParseDivident = int.TryParse(Console.ReadLine(), out int divident);
        Console.WriteLine("Please input divisor: ");
        bool canParseDivisor = int.TryParse(Console.ReadLine(), out int divisor);
        
        if (canParseDivident && canParseDivisor)
        {
            exceptionUtils.DivideNumbers(divident, divisor);
        }
        else
        {
            Console.WriteLine("Please enter valid numbers.");
        }
        
        //Task 4
        Console.WriteLine("Please enter age: ");
        bool canParseAge = int.TryParse(Console.ReadLine(), out int age);
        if (canParseAge)
        {
            exceptionUtils.ValidateAge(age);
        }
        else
        {
            Console.WriteLine("Please enter valid age.");
        }
        
        //Task 5
        exceptionUtils.ReadFile("testfile.txt"); //Valid
        exceptionUtils.ReadFile("C://testfile.txt"); //Invalid
    }
}