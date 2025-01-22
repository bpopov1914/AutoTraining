using L10Exercise.Entities.Members;

namespace L10Exercise.Entities;

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
    }

    public bool IsBookAvailable
    {
        get { return isBookAvailable; }
    }
    

    public void BorrowBook()
    {
        isBookAvailable = CheckIfBookIsAvailable();
        if (isBookAvailable)
        {
            _availableCopies--;
        }
        else
        {
            Console.WriteLine($"Book \"{Title}\" by {Author} is not available.");
        }
    }

    public void ReturnBook()
    {
        _availableCopies++;
    }

    private bool CheckIfBookIsAvailable()
    {
        return _availableCopies > 0;
    }
    
}