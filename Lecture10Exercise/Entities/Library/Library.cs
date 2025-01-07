using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise.Entities.Library;

public class Library : LibraryManagement
{
    List<Book> libraryBooks = new();
    public override void AddBookToLibrary(Book book)
    {
        libraryBooks.Add(book);
        Console.WriteLine($"Book \"{book.Title}\"-{book.Author} was successfully added to the library.");
    }

    public override void RemoveBookFromLibrary(Book book)
    {
        libraryBooks.Remove(book);
        Console.WriteLine($"Book \"{book.Title}\"-{book.Author} was successfully removed from the library.");
    }

    public override void BorrowBookByMember(Member member, Book book)
    {
        bool canMemberBorrowBook = member.CanMemberBorrowBook();
        bool isBookAvailable = book.CheckIfBookIsAvailable();
        if (canMemberBorrowBook && isBookAvailable)
        {
            book.AvailableCopies--;
            member.Books.Add(book);
            Console.WriteLine($"{member} borrowed the book \"{book.Title}\" - {book.Author}.");
        }
        else if (!canMemberBorrowBook && isBookAvailable)
        {
            Console.WriteLine($"{member} was reached the limit of {member.MaxBooksToBorrow} borrowed from the library.");
        }
        else if (canMemberBorrowBook && !isBookAvailable)
        {
            Console.WriteLine($"Book \"{book.Title}\"-{book.Author} is not available");
        }
    }

    public override void ReturnBookByMember(Member member, Book book)
    {
        member.Books.Remove(book);
        book.AvailableCopies++;
        Console.WriteLine($"{member} returned the book \"{book.Title}\" - {book.Author}.");
    }
    
    
}