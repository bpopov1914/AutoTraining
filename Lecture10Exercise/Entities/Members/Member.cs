namespace Lecture10Exercise.Entities;

public class Member
{
    private string _memberName;
    private int _memberId;
    private string _membershipType;
    public Member(string name, int memberId, string membershipType)
    {
        _memberName = name;
        _memberId = memberId;
        _membershipType = membershipType;
    }

    string MemberName
    {
        get { return _memberName; }
        set { _memberName = value; }
    }

    int MemberID
    {
        get { return _memberId; }
        set { _memberId = value; }
    }

    string MembershipType
    {
        get { return _membershipType; }
        set { _membershipType = value; }
    }

    public override string ToString()
    {
        return $"{MemberName} ({MembershipType})";
    }
    
}