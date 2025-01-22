namespace Mission3;

public class FoodItem
{
    // CONSTRUCTOR
    public string Name;
    public string Category;
    public int Quantity;
    public string ExpireDate;

    public FoodItem(string name,string category, int quantity,string expireDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpireDate = expireDate;
    }
}