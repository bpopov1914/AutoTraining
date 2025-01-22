namespace L10Exercise.Entities.Members;

public abstract class Member
{
    public string MemberName{ get; set; }
    
    public int MemberId{ get; set; }
    public string MembershipType{ get; set; }
    public int MaxBooksToBorrow{ get; set; } 
    public int BooksBorrowed{ get; set; }
    
    public abstract void BorrowBook(Book book);
    public abstract void ReturnBook(Book book);
    public override string ToString()
    {
        return $"{MemberName} ({MembershipType})";
    }
}