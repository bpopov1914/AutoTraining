namespace Lecture10Exercise.Entities.Members;

public abstract class Member
{
    public string MemberName;
    public int MemberId; 
    public string MembershipType;
    public int MaxBooksToBorrow; 
    public List<Book> Books;

    public abstract bool CanMemberBorrowBook();
    public abstract void BorrowBook(Book book);
    public abstract void ReturnBook(Book book);
}