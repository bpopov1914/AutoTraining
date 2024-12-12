namespace Lecture10Exercise.Entities;

public class StudentMember : Member
{
    private string _studentName;
    private int _memberId;
    private string _membershipType;
    private int _maxBooksToBorrow = 5;
    
    public StudentMember(string name, int memberId, string membershipType) : base(name, memberId, membershipType)
    {
        _studentName = name;
        _memberId = memberId;
        _membershipType = membershipType;
    }

    string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
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