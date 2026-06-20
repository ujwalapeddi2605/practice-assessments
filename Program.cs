using System;
using System.Collections.Generic;
namespace InventoryManagementSystem
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, int quantity, double price)
        {
            ProductId = id;
            ProductName = name;
            Quantity = quantity;
            Price = price;
        }
    }
    class Inventory
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>();
        public void AddProduct(Product product)
        {
            products[product.ProductId] = product;
            Console.WriteLine("Product Added Successfully.");
        }
        public void UpdateProduct(int id, int quantity)
        {
            if (products.ContainsKey(id))
            {
                products[id].Quantity = quantity;
                Console.WriteLine("Product Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }
        public void DeleteProduct(int id)
        {
            if (products.Remove(id))
                Console.WriteLine("Product Deleted Successfully.");
            else
                Console.WriteLine("Product Not Found.");
        }
        public void DisplayProducts()
        {
            Console.WriteLine("\nInventory Products:");
            foreach (var product in products.Values)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Qty: {product.Quantity}, Price: {product.Price}");
            }
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddProduct(new Product(101, "Laptop", 10, 55000));
            inventory.AddProduct(new Product(102, "Mouse", 50, 500));
            inventory.DisplayProducts();
            inventory.UpdateProduct(101, 20);
            inventory.DisplayProducts();
            inventory.DeleteProduct(102);
            inventory.DisplayProducts();
        }
    }
}
