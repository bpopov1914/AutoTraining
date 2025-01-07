namespace Lecture10Exercise.Entities.Members;

public class StudentMember : Member
{
    private string _studentName;
    private int _memberId;
    private string _membershipType;
    private int _maxBooksToBorrow = 5; 
    public List<Book> Books = new ();
    
    public StudentMember(string name, int memberId, string membershipType) 
    {
        _studentName = name;
        _memberId = memberId;
        _membershipType = membershipType;
    }

    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public int MemberId
    {
        get { return _memberId; }
        set { _memberId = value; }
    }

    public string MembershipType
    {
        get { return _membershipType; }
        set { _membershipType = value; }
    }

    public int MaxBooksToBorrow
    {
        get { return _maxBooksToBorrow; }
    }
    
    public override bool CanMemberBorrowBook()
    {
        return MaxBooksToBorrow > Books.Count;
    }
    
    public override string ToString()
    {
        return $"{StudentName} ({MembershipType})";
    }
}