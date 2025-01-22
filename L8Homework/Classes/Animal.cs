namespace L8Homework.Classes;

public class Animal
{
    private string _name;
    private string _favouriteFood;

    public string Name
    {
        get{return _name;}
        set{_name = value;}
    }

    public string FavoriteFood
    {
        get{return _favouriteFood;}
        set{_favouriteFood = value;}
    }
    public virtual string ExplainSelf()
    {
        return null;
    }
    public void Eat()
    {
        Console.WriteLine("eating...");
    }
}