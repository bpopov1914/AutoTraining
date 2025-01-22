using L9Homework.Interfaces;

namespace L9Homework.Classes.Task4;

public class Magazine : LibraryItem, IBorrowable
{
    public int IssueNumber { get; set; }

    public Magazine(string title, int issueNumber)
    {
        Title = title;
        IssueNumber = issueNumber;
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
            Console.WriteLine($"Magazine '{Title}' (Issue {IssueNumber}) borrowed by {Borrower}, due on {DueDate}.");
        }
    }

    public override void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"Magazine '{Title}' (Issue {IssueNumber}) is returned by {Borrower}.");
        }
        else
        {
            Console.WriteLine($"'{Title}' was not borrowed.");
        }
    }
}