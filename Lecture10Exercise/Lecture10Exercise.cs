using Lecture10Exercise.Entities;
using Lecture10Exercise.Entities.Library;
using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise;

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
        
        library.BorrowBookByMember(student1, book1); //Add successfully 
        library.BorrowBookByMember(student2, book2); //Add successfully 
        library.BorrowBookByMember(student1, book2); //No book copies available
        library.BorrowBookByMember(student1, book1); //Add successfully 
        library.BorrowBookByMember(student1, book3); //Add successfully 
        library.BorrowBookByMember(student1, book4); //Add successfully 
        library.BorrowBookByMember(student1, book5); //Add successfully 
        library.BorrowBookByMember(student1, book5); //Student reached max books to borrow
        library.BorrowBookByMember(staff1, book5); //Add successfully 
        library.BorrowBookByMember(staff1, book6); //Add successfully 
        library.BorrowBookByMember(staff2, book5); //Add successfully 
        
    }
}