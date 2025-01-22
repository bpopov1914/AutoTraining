using L10Exercise.Entities.Members;

namespace L10Exercise.Entities.Library;

public abstract class LibraryManagement
{
    public abstract void AddBookToLibrary(Book book);
    public abstract void RemoveBookFromLibrary(Book book);
    public abstract void BorrowBookByMember(Member member, Book book);
    public abstract void ReturnBookByMember(Member member, Book book);
}