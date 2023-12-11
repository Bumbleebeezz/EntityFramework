namespace Common.Models;

public class StoreModel
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public IList<ProductModel> Products { get; set; } = new List<ProductModel>();
}