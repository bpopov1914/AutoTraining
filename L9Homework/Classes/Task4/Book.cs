using L9Homework.Interfaces;

namespace L9Homework.Classes.Task4;

public class Book : LibraryItem, IBorrowable
{
    public string Author { get; set; }
    
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsBorrowed = false;
    }
    public override void Borrow(string borrower, DateTime dueDate)
    {
        if (IsBorrowed)
        {
            Console.WriteLine($"'{Title}' is already borrowed.");
        }
        else
        {
            Borrower = borrower;
            DueDate = dueDate;
            IsBorrowed = true;
            Console.WriteLine($"Book '{Title}' by {Author} borrowed by {Borrower}, due on {DueDate}.");
        }
        
    }

    public override void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"Book '{Title}' by {Author} was returned by {Borrower}.");
        }
        else
        {
            Console.WriteLine($"'{Title}' was not borrowed.");
        }
    }
}