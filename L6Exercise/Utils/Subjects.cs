namespace L6Exercise.Utils;

public class Subjects
{
    bool isSubjectAllowed;
    private List<string> allowedSubjects = new()
    {
        "Math", "Biology", "History", "English", "Sport", "Physics"
    };

    public bool CheckIfSubjectIsAllowed(string subject)
    {
        foreach (var allowedSubject in allowedSubjects)
        {
            if (allowedSubject == subject)
            {
                isSubjectAllowed = true;
            }
        }
        return isSubjectAllowed;
    }
}