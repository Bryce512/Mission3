namespace Mission3;

public class FoodItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public DateTime ExpireDate;

    // CONSTRUCTOR
    public FoodItem(string name, string category, int quantity,DateTime expireDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpireDate = expireDate;
    }
}