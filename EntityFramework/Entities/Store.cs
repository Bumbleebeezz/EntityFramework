namespace EntityFramework.Entities;

public class Store
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public IList<Product> Products { get; set; } = new List<Product>();
}