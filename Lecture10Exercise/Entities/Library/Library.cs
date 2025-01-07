using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise.Entities.Library;

public class Library : LibraryManagement
{
    List<Book> libraryBooks = new();
    public override void AddBookToLibrary(Book book)
    {
        libraryBooks.Add(book);
        Console.WriteLine($"Book \"{book.Title}\" by {book.Author} was successfully added to the library.");
    }

    public override void RemoveBookFromLibrary(Book book)
    {
        libraryBooks.Remove(book);
        Console.WriteLine($"Book \"{book.Title}\" by {book.Author} was successfully removed from the library.");
    }

    public override void BorrowBookByMember(Member member, Book book)
    {
        bool canMemberBorrowBook = member.CanMemberBorrowBook();
        if (canMemberBorrowBook)
        {
            book.BorrowBook();
            member.BorrowBook(book);
            Console.WriteLine($"{member} borrowed the book \"{book.Title}\". Books borrowed: {member.Books.Count}/{member.MaxBooksToBorrow}.");
        }
        else
        {
            Console.WriteLine($"{member} has reached the limit of {member.MaxBooksToBorrow} borrowed from the library.");
        }
    }

    public override void ReturnBookByMember(Member member, Book book)
    {
        member.ReturnBook(book);
        book.ReturnBook();
        Console.WriteLine($"{member} returned the book \"{book.Title}\" - {book.Author}. Copies available: {book.AvailableCopies}.");
    }
    
    
}