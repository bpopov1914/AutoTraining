namespace L7Homework;

public class ExceptionHandlingUtils
{
    public void DivideNumbers(int dividend, int divisor)
    {
        try
        {
            if (dividend == 0 || divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            decimal result = dividend / divisor;
            Console.WriteLine($"{dividend} / {divisor} = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }

    public void ValidateAge(int age)
    {
        try
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException("Age cannot be less than zero or over 150.");
            }

            Console.WriteLine("Age is valid.");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void ReadFile(string filePath)
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
                
            int bytesRead = fs.Read(buffer, 0, buffer.Length);

            string fileContents = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine(fileContents);
            
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
                Console.WriteLine("FileStream is closed.");
            }
        }
    }
}