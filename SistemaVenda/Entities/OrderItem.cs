using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public OrderItem()
        {

        }

        public OrderItem(int quantity)
        {
            Quantity = quantity;
            Price = Product.Price;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public double SubTotal()
        {
            return Price * Quantity;
  
        }
      
    }
}
