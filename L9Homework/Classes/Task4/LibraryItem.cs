
using L9Homework.Interfaces;

namespace L9Homework.Classes.Task4;

public abstract class LibraryItem : IBorrowable
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string Borrower { get; set; }
    public DateTime DueDate { get; set; }

    public void CheckStatus()
    {
        if (IsBorrowed)
        {
            Console.WriteLine($"Title: {Title}, Borrowed by: {Borrower}, Due on: {DueDate}");
        }
        else
        {
            Console.WriteLine($"Title: {Title}, Available for borrowing.");
        }
    }

    public void ExtendDueDate(int days)
    {
        if (IsBorrowed)
        {
            DueDate = DueDate.AddDays(days);
            Console.WriteLine($"Due date extended for '{Title}' by {days} days. New due date is {DueDate.ToShortDateString()}.");
        }
        else
        {
            Console.WriteLine($"Title: {Title} is not borrowed.");
        }
    }
    public abstract void Borrow(string borrower, DateTime dueDate);
    public abstract void Return();
}