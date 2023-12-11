using EntityFramework.Entities;

var db = new ProductContext();

var productsBefore = db.Products.ToList();
foreach (var product in productsBefore)
{
    Console.WriteLine($"{product.ID} {product.Name} {product.Description} {product.Price}");
}
Console.WriteLine("===========================================");

// List and objects are a reference to Db, changes will effect Db  
var productsWithConnection = db.Products;
foreach (var product in productsWithConnection)
{
    product.Price *= 1.1;
    Console.WriteLine($"{product.ID} {product.Name} {product.Description} {product.Price}");
}

//db.SaveChanges();

//// Find: returns 1 item
//var bananasID = db.Products.Find(2);
//var bananasName = db.Products.FirstOrDefault(p => p.Name == "Banan");
//Console.WriteLine(bananasID.Name);
//Console.WriteLine(bananasName.Name);
//Console.ReadLine();


//var deleteProduct = db.Products.FirstOrDefault(p => p.Name == "Banan");
//db.Remove(deleteProduct);
//db.SaveChanges();


//var productsStartingWithB = db.Products.Where(p => p.Name.StartsWith("B")).ToList();

//productsStartingWithB.ForEach(p => p.Price *= 1.1);

//db.Products.UpdateRange(productsStartingWithB);
//db.SaveChanges();
//foreach (var product in productsStartingWithB)
//{
//    Console.WriteLine(product.Name);
//}

//var FruitStore = new Store();
//FruitStore.Name = "Fruit Store";
//db.Stores.Add(FruitStore);

//var fruitStore = db.Stores.Find(1);
//db.SaveChanges();