using L10Exercise.Entities;
using L10Exercise.Entities.Library;
using L10Exercise.Entities.Members;

namespace L10Exercise;

class Lecture10Exercise
{
    static void Main(string[] args)
    {
        var library = new Library();
        var book1 = new Book("Title 1", "Author 1", "1234567890asas", 2);
        var book2 = new Book("Title 2", "Author 2", "asdasdsd234234", 1);
        var book3 = new Book("Title 3", "Author 3", "rth234fdbvasas", 1);
        var book4 = new Book("Title 4", "Author 4", "452345234523as", 1);
        var book5 = new Book("Title 5", "Author 5", "utymfghgfghasa", 5);
        var book6 = new Book("Title 6", "Author 6", "asdasd234234ga", 5);
        var student1 = new StudentMember("Student One", 1);
        var student2 = new StudentMember("Student Two", 2);
        var staff1 = new StaffMember("Staff One", 3);
        var staff2 = new StaffMember("Staff Two", 4);
        
        library.AddBookToLibrary(book1);
        library.AddBookToLibrary(book2);
        library.AddBookToLibrary(book3);
        library.AddBookToLibrary(book4);
        library.AddBookToLibrary(book5);
        library.AddBookToLibrary(book6);
        
        library.BorrowBookByMember(student1, library.libraryBooks[0]); //Borrow Book 1 successfully 
        library.BorrowBookByMember(student2, library.libraryBooks[1]); //Borrow Book 2 successfully 
        library.BorrowBookByMember(student1, library.libraryBooks[1]); //No Book 2 copies available
        library.BorrowBookByMember(student1, library.libraryBooks[0]); //Borrow Book 1 successfully 
        library.BorrowBookByMember(student1, library.libraryBooks[2]); //Borrow Book 3 successfully 
        library.BorrowBookByMember(student1, library.libraryBooks[3]); //Borrow Book 4 successfully 
        library.BorrowBookByMember(student1, library.libraryBooks[4]); //Borrow Book 5 successfully 
        library.BorrowBookByMember(student1, library.libraryBooks[4]); //Student reached max books to borrow
        library.BorrowBookByMember(staff1, library.libraryBooks[4]); //Borrow Book 5 successfully 
        library.BorrowBookByMember(staff1, library.libraryBooks[5]); //Borrow Book 6 successfully 
        library.BorrowBookByMember(staff2, library.libraryBooks[4]); //Borrow Book 5 successfully 
        
        library.ReturnBookByMember(student1, book1);
        library.ReturnBookByMember(student1, book1);
        library.ReturnBookByMember(student2, book2);
        library.ReturnBookByMember(student1, book3);
        library.ReturnBookByMember(student1, book4);
        library.ReturnBookByMember(student1, book5);
        library.ReturnBookByMember(student1, book5);
        library.ReturnBookByMember(staff1, book5);
        library.ReturnBookByMember(staff1, book6);
        
        library.RemoveBookFromLibrary(book1);
        library.RemoveBookFromLibrary(book2);
        library.RemoveBookFromLibrary(book3);
        library.RemoveBookFromLibrary(book4);
        library.RemoveBookFromLibrary(book5);
        library.RemoveBookFromLibrary(book6);
        
    }
}