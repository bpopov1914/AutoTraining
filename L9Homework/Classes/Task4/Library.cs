namespace L9Homework.Classes.Task4;

public class Library
{
    private List<LibraryItem> items;
    private Dictionary<string, List<LibraryItem>> borrowerRecords;

    public Library()
    {
        items = new List<LibraryItem>();
        borrowerRecords = new Dictionary<string, List<LibraryItem>>();
    }

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }

    public void BorrowItem(string borrower, LibraryItem item, DateTime dueDate)
    {
        if (!borrowerRecords.ContainsKey(borrower))
        {
            borrowerRecords[borrower] = new List<LibraryItem>();
        }

        if (borrowerRecords[borrower].Count >= 3)
        {
            Console.WriteLine($"{borrower} cannot borrow more than 3 items.");
            return;
        }

        item.Borrow(borrower, dueDate);
        if (item.IsBorrowed)
        {
            borrowerRecords[borrower].Add(item);
        }
    }

    public void ReturnItem(string borrower, LibraryItem item)
    {
        if (borrowerRecords.ContainsKey(borrower) && borrowerRecords[borrower].Contains(item))
        {
            item.Return();
            borrowerRecords[borrower].Remove(item);
        }
        else
        {
            Console.WriteLine($"No borrowed item found for {borrower}.");
        }
    }

    public void ShowLibraryStatus()
    {
        Console.WriteLine("\nLibrary Status:");
        foreach (var item in items)
        {
            item.CheckStatus();
        }
    }
}