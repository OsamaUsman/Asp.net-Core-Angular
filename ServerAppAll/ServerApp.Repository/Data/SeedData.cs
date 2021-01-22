using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerApp.Repository.Data
{
    public class SeedData
    {
        public static void SeedDatabase(MartDbContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0) 
            {
                var s1 = new Supplier
                {
                    Name = "Denims",
                    City = "Karachi",
                    State = "Sindh"
                };
                var s2 = new Supplier
                {
                    Name = "Shan Foods",
                    City = "Islamabad",
                    State = "Punjab"
                };

                var s3 = new Supplier
                {
                    Name = "Artistic",
                    City = "Peshawar",
                    State = "KPK"
                };
                context.Products.AddRange
                    (
                    new Product
                    {
                        Name = "Product1",
                        Category ="Jacket",
                        Description = "Discription 1",
                        Price = 2500,
                        Supplier = s1,
                        Ratings = new List<Rating> 
                        { 
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 2 },
                            new Rating  {Stars = 3 },
                        }
                    },
                    new Product
                    {
                        Name = "Product2",
                        Category = "Bag",
                        Description = "Discription 2",
                        Price = 1200,
                        Supplier = s1,
                        Ratings = new List<Rating>
                        {
                          
                            new Rating  {Stars = 4 },
                            new Rating  {Stars = 5 }
                        }
                    },
                    new Product
                    {
                        Name = "Product3",
                        Category = "Masala",
                        Description = "Discription 3",
                        Price = 150,
                        Supplier = s2,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 5 }
                        }
                    },
                    new Product
                    {
                        Name = "Product4",
                        Category = "Shoes",
                        Description = "Discription 4",
                        Price = 3000,
                        Supplier = s3,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 3 },
                            new Rating  {Stars = 4 },
                            new Rating  {Stars = 4 }
                        }
                    },
                    new Product
                    {
                        Name = "Product5",
                        Category = "Shirt",
                        Description = "Discription 5",
                        Price = 3000,
                        Supplier = s3,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 3 },
                            new Rating  {Stars = 4 },
                            new Rating  {Stars = 4 }
                        }
                    },
                    new Product
                    {
                        Name = "Product6",
                        Category = "Shirt",
                        Description = "Discription 6",
                        Price = 2200,
                        Supplier = s1,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 4 },
                            new Rating  {Stars = 4 }
                        }
                    },
                    new Product
                    {
                        Name = "Product7",
                        Category = "T-Shirt",
                        Description = "Discription 7",
                        Price = 700,
                        Supplier = s3,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 3 }
                        }
                    },
                    new Product
                    {
                        Name = "Product8",
                        Category = "Masala",
                        Description = "Discription 8",
                        Price = 150,
                        Supplier = s2,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 5 }
                        }
                    },
                    new Product
                    {
                        Name = "Product9",
                        Category = "Masala",
                        Description = "Discription 9",
                        Price = 200,
                        Supplier = s2,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 5 },
                            new Rating  {Stars = 4 }
                        }
                    },
                    new Product
                    {
                        Name = "Product10",
                        Category = "Jeans",
                        Description = "Discription 10",
                        Price = 3500,
                        Supplier = s1,
                        Ratings = new List<Rating>
                        {
                            new Rating  {Stars = 4 },
                        }
                    });

            }

        }
    }
}
