namespace Lecture10Exercise.Entities.Members;

public class StaffMember : Member
{
    private string _staffName;
    private int _memberId;
    private string _membershipType;
    private int _maxBooksToBorrow = 10;
    
    public StaffMember(string name, int memberId, string membershipType) : base(name, memberId, membershipType)
    {
        _staffName = name;
        _memberId = memberId;
        _membershipType = membershipType;
    }

    string StaffName
    {
        get { return _staffName; }
        set { _staffName = value; }
    }

    int MemberId
    {
        get { return _memberId; }
        set { _memberId = value; }
    }

    string MembershipType
    {
        get { return _membershipType; }
        set { _membershipType = value; }
    }

    int MaxBooksToBorrow
    {
        get { return _maxBooksToBorrow; }
    }
}