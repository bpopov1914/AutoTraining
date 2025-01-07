namespace Lecture10Exercise.Entities.Members;

public class StaffMember : Member
{
    private string _staffName;
    private int _memberId;
    private string _membershipType;
    private int _maxBooksToBorrow = 10;
    public List<Book> Books = new ();
    
    public StaffMember(string name, int memberId, string membershipType)
    {
        _staffName = name;
        _memberId = memberId;
        _membershipType = membershipType;
    }

    public string StaffName
    {
        get { return _staffName; }
        set { _staffName = value; }
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
        return $"{StaffName} ({MembershipType})";
    }
}