namespace Common.Models;

public class ProductModel
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }

    public List<StoreModel> Stores { get; set; } = new();
}