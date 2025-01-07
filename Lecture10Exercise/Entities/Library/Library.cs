using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise.Entities.Library;

public class Library : LibraryManagement
{
    List<Book> libraryBooks = new();
    public override void AddBookToLibrary(Book book)
    {
        libraryBooks.Add(book);
        Console.WriteLine($"Book \"{book.Title}\" by {book.Author} was successfully added to the library. Copies available: {book.AvailableCopies}.");
    }

    public override void RemoveBookFromLibrary(Book book)
    {
        libraryBooks.Remove(book);
        Console.WriteLine($"Book \"{book.Title}\" by {book.Author} was successfully removed from the library. Copies available: {book.AvailableCopies}.");
    }

    public override void BorrowBookByMember(Member member, Book book)
    {
        
        book.BorrowBook();
        if (book.IsBookAvailable)
        {
            member.BorrowBook(book);
        }
        
    }

    public override void ReturnBookByMember(Member member, Book book)
    {
        member.ReturnBook(book);
        book.ReturnBook();
        Console.WriteLine($"{member} returned the book \"{book.Title}\" - {book.Author}. Copies available: {book.AvailableCopies}.");
    }
    
    
}