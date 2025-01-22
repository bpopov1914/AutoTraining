namespace L9Homework.Interfaces;

public interface IBorrowable
{
    void Borrow(string borrower, DateTime dueDate);
    void Return();

}