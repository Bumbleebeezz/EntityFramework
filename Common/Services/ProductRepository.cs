using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;
using Common.Models;
using EntityFramework.Entities;

namespace Common.Services;

public class ProductRepository
{
    private readonly ProductContext _context;

    public ProductRepository()
    {
        _context = new ProductContext();
    }

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public void AddProduct(ProductModel product)
    {
        _context.Add
        (
            new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            }
        );
        _context.SaveChanges();
    }
}