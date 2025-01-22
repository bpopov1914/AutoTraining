using System.Runtime.CompilerServices;

namespace L10Exercise.Entities.Members;

public class StudentMember : Member
{
    public List<Book> StudentBooks = new ();
    
    public StudentMember(string name, int memberId) :base()
    {
        MemberName = name;
        MemberId = memberId;
        MembershipType = "Student";
        MaxBooksToBorrow = 5;
    }
    

    public override void BorrowBook(Book book)
    {
        if (MaxBooksToBorrow > BooksBorrowed)
        {
            StudentBooks.Add(book);
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
        StudentBooks.Remove(book);
    }
    
}