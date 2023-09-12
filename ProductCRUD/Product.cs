using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
    }

    public class GetCRUD
    {
        private List<Product> productlist;
        public GetCRUD()
        {
            productlist = new List<Product>()
            {
            new Product { Id = 1, Name = "Laptop", Price = 36000, Company = "HP" },
            new Product { Id = 2, Name = "Laptop", Price = 39000, Company = "Dell" }
            };
        }
        public List<Product> GetProducts()
        {
            return productlist;
        }
        public Product GetProductbyId(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        public void AddProduct(Product p)
        {
            productlist.Add(p);
        }
        public void UpdateProduct(Product p)
        {
            foreach (Product item in productlist)
            {
             
                if (item.Id == p.Id)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;

                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (Product item in productlist)
            {
                if (item.Id == id)
                {
                    productlist.Remove(item);
                    break;
                }

            }

        }
    }
}
