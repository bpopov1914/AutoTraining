namespace Lecture10Exercise.Entities.Members;

public class StaffMember : Member
{
    public List<Book> StaffBooks = new ();
    
    public StaffMember(string name, int memberId) : base()
    {
        MemberName = name;
        MemberId = memberId;
        MembershipType = "Staff";
        MaxBooksToBorrow = 10;
    }

    public override void BorrowBook(Book book)
    {
        if (MaxBooksToBorrow > BooksBorrowed)
        {
            StaffBooks.Add(book);
            BooksBorrowed++;
            Console.WriteLine($"{base.ToString()} borrowed the book \"{book.Title}\". Books borrowed: {BooksBorrowed}/{MaxBooksToBorrow}.");
        }
        else
        {
            Console.WriteLine($"{MemberName} has reached the limit of {MaxBooksToBorrow} borrowed from the library.");
        }
        
    }

    public override void ReturnBook(Book book)
    {
        StaffBooks.Remove(book);
    }
    
}