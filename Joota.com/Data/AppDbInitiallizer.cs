using Joota.com.Models;

namespace Joota.com.Data
{
    public class AppDbInitiallizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Shoes.Any())
                {
                    context.Shoes.AddRange(new List<Shoes>()
                {
                    new Shoes()
                    {
                        Name = "Sneaker-01",
                        Description = "This is the Sneaker shoes discription",
                        Price = 2999,
                        ImageURL = "Images/sneakers/Sneaker-01.jpg",
                        Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sneakers,
                    },

                    new Shoes()
                    {
                        Name = "Sneaker-02",
                        Description = "This is the Sneaker shoes discription",
                        Price = 4999,
                        ImageURL = "Images/sneakers/Sneaker-02.jpg",
                        Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sneakers,
                    },

                     new Shoes()
                    {
                        Name = "Sandal-01",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-01.jpg",
                        Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },
                       new Shoes()
                    {
                        Name = "Sandal-02",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-02.jpg",
                        Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },

                         new Shoes()
                    {
                        Name = "Sandal-03",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-03.jpg",
                        Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },
                         
                        new Shoes()
                    {
                        Name = "Sandal-04",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-04.jpg",
                       Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },

                      new Shoes()
                    {
                        Name = "Sandal-05",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-05.jpg",
                       Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },
                        new Shoes()
                    {
                        Name = "Sandal-06",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/Sandals/sandal-06.jpg",
                       Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sandals,
                    },
                         new Shoes()
                    {
                        Name = "Sneaker-03",
                        Description = "This is the  shoes discription",
                        Price = 4999,
                        ImageURL = "Images/sneaker/sneaker-03.jpg",
                       Quantity = 5,
                        Size = 36,
                        ShoesCategory = Enums.ShoesCategory.Sneakers,
                    }

                });
                 context.SaveChanges(); 

                }
            }
        } 
        
    }
}
