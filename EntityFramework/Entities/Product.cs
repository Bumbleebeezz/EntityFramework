using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Entities;

public class Product
{
    [Key]
    public int ID { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }

    public List<Store> Stores { get; set; } = new();
}

