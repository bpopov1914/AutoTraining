using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise.Entities.Library;

public class Library : LibraryManagement
{
    public override void AddBookToLibrary(Book book)
    {
        throw new NotImplementedException();
    }

    public override void RemoveBookFromLibrary(Book book)
    {
        throw new NotImplementedException();
    }

    public override void BorrowBookByMember(Member member, Book book)
    {
        throw new NotImplementedException();
    }

    public override void ReturnBookByMember(Member member, Book book)
    {
        throw new NotImplementedException();
    }
}