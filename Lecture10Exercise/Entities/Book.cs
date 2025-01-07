using Lecture10Exercise.Entities.Members;

namespace Lecture10Exercise.Entities;

public class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private int _availableCopies;
    private bool isBookAvailable;
    
    public Book(string title, string author, string isbn, int availableCopies)
    {
        _title = title;
        _author = author;
        _isbn = isbn;
        _availableCopies = availableCopies;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string ISBN
    {
        get { return _isbn; }
        set { _isbn = value; }
    }

    public int AvailableCopies
    {
        get { return _availableCopies; }
        set { _availableCopies = value; }
    }
    

    public void BorrowBook()
    {
        if (isBookAvailable)
        {
            AvailableCopies--;
            Console.WriteLine($"Book {Title} is borrowed.");
        }
        else
        {
            Console.WriteLine($"Book {Title} is not available");
        }
    }

    public void ReturnBook()
    {
        AvailableCopies++;
    }

    public bool CheckIfBookIsAvailable()
    {
        return AvailableCopies > 0;
    }
    
}