namespace Lecture10Exercise.Entities.Members;

public abstract class Member
{
    public string MemberName;
    public int MemberId; 
    public string MembershipType;
    public int MaxBooksToBorrow; 
    public List<Book> Books;

    public abstract bool CanMemberBorrowBook();

}