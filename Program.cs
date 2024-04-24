using System;
using System.IO;
using System.Text.Json;

namespace JSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Product product = new Product
                {
                    Id = 1,
                    Name = "Telefon",
                    Price = 899.99,
                    Description = "Samsung SM-M556B/DS Galaxy M55 5G 2024 Premium Edition Global TD-LTE 256GB"
                };

             
                string json = ProductToJSON(product);                               
                

               
                Product deserializedProduct = JSONToProduct(json);

                Console.WriteLine("JSON deserialized :");
                Console.WriteLine($"Id: {deserializedProduct.Id}");
                Console.WriteLine($"Name: {deserializedProduct.Name}");
                Console.WriteLine($"Price: {deserializedProduct.Price}");
                Console.WriteLine($"Description: {deserializedProduct.Description}");
            }

            static string ProductToJSON(Product product)
            {
                return JsonSerializer.Serialize(product);
            }

            static Product JSONToProduct(string json)
            {
                return JsonSerializer.Deserialize<Product>(json);
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
        }
    }


 